using iTextSharp.text.pdf;
using iTextSharp.text;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZXing;



namespace TaskManager
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBoxQRCode;

        private const string connectionString = "Host=195.46.187.72;Username=postgres;Password=1337;Database=task";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadTasks_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskNumber = txtTaskNumber.Text;
            string projectName = txtProjectName.Text;
            string description = txtDescription.Text;
            string assignee = txtAssignee.Text;
            string priority = cmbPriority.SelectedItem.ToString();
            string status = cmbStatus.SelectedItem.ToString();
            DateTime creationDate = DateTime.Now;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tasks (task_number, creation_date, project_name, description, priority, assignee, status) " +
                                   "VALUES (@taskNumber, @creationDate, @projectName, @description, @priority, @assignee, @status)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("taskNumber", taskNumber);
                        cmd.Parameters.AddWithValue("creationDate", creationDate);
                        cmd.Parameters.AddWithValue("projectName", projectName);
                        cmd.Parameters.AddWithValue("description", description);
                        cmd.Parameters.AddWithValue("priority", priority);
                        cmd.Parameters.AddWithValue("assignee", assignee);
                        cmd.Parameters.AddWithValue("status", status);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Задача добавлена успешно!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении задачи: {ex.Message}");
                }
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            string taskNumber = txtTaskNumber.Text;

            if (string.IsNullOrWhiteSpace(taskNumber))
            {
                MessageBox.Show("Пожалуйста, введите номер задачи для удаления.");
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM tasks WHERE task_number = @taskNumber";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("taskNumber", taskNumber);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Задача успешно удалена.");
                            LoadTasks();
                        }
                        else
                        {
                            MessageBox.Show("Задача с таким номером не найдена.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении задачи: {ex.Message}");
                }
            }
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            string taskNumber = txtTaskNumber.Text;

            if (string.IsNullOrWhiteSpace(taskNumber))
            {
                MessageBox.Show("Пожалуйста, введите номер задачи для редактирования.");
                return;
            }

            string projectName = txtProjectName.Text;
            string description = txtDescription.Text;
            string assignee = txtAssignee.Text;
            string priority = cmbPriority.SelectedItem.ToString();
            string status = cmbStatus.SelectedItem.ToString();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE tasks SET project_name = @projectName, description = @description, assignee = @assignee, " +
                                   "priority = @priority, status = @status WHERE task_number = @taskNumber";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("taskNumber", taskNumber);
                        cmd.Parameters.AddWithValue("projectName", projectName);
                        cmd.Parameters.AddWithValue("description", description);
                        cmd.Parameters.AddWithValue("assignee", assignee);
                        cmd.Parameters.AddWithValue("priority", priority);
                        cmd.Parameters.AddWithValue("status", status);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Задача успешно обновлена.");
                            LoadTasks();
                        }
                        else
                        {
                            MessageBox.Show("Задача с таким номером не найдена.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при редактировании задачи: {ex.Message}");
                }
            }
        }

        private void LoadTasks(string searchKeyword = "")
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM tasks";

                // Если ключевое слово введено, добавляем условие поиска
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    query += " WHERE project_name ILIKE @searchKeyword OR description ILIKE @searchKeyword";
                }
                query += " ORDER BY creation_date DESC";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        cmd.Parameters.AddWithValue("searchKeyword", "%" + searchKeyword + "%");
                    }

                    var dataAdapter = new NpgsqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewTasks.DataSource = dataTable;
                }
            }
        }
        private void btnSearchTask_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tasks WHERE task_number ILIKE @searchQuery OR description ILIKE @searchQuery";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("searchQuery", "%" + searchQuery + "%");

                        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridViewTasks.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при поиске задач: {ex.Message}");
                }
            }
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();  // Загружаем все задачи при запуске
        }

        // Очистка формы после операций
        private void ClearForm()
        {
            txtTaskNumber.Clear();
            txtProjectName.Clear();
            txtDescription.Clear();
            txtAssignee.Clear();
            cmbPriority.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dtpDueDate.Value = DateTime.Now;
            txtSearch.Clear();
        }
        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            // Данные для QR-кода
            string qrData = "https://vk.com/id570088156";  // Это может быть любой текст или URL

            // Генерация QR-кода
            BarcodeWriter barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 250,   // Ширина QR-кода
                    Height = 250   // Высота QR-кода
                }
            };

            // Генерация изображения QR-кода
            Bitmap qrCodeImage = barcodeWriter.Write(qrData);

            // Отображение QR-кода в PictureBox
            pictureBox1.Image = qrCodeImage;
        }
        private void CalculateStatistics(DateTime startDate, DateTime endDate)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();


                // Среднее время выполнения задач
                string queryAvgDuration = "SELECT AVG(completion_date - creation_date) AS avg_duration FROM tasks WHERE status = 'Выполнено' AND completion_date BETWEEN @startDate AND @endDate";
                using (var cmd = new NpgsqlCommand(queryAvgDuration, connection))
                {
                    cmd.Parameters.AddWithValue("startDate", startDate);
                    cmd.Parameters.AddWithValue("endDate", endDate);
                    var avgDuration = cmd.ExecuteScalar();
                    labelAvgDuration.Text = $"Среднее время выполнения: {avgDuration}";
                }

                // Статистика по проектам
                string queryProjectStats = "SELECT project_name, COUNT(*) AS task_count, COUNT(CASE WHEN status = 'Выполнено' THEN 1 END) AS completed_tasks FROM tasks GROUP BY project_name";
                using (var cmd = new NpgsqlCommand(queryProjectStats, connection))
                {
                    var dataAdapter = new NpgsqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewProjectStats.DataSource = dataTable;
                }
                
                // Статистика по исполнителям
                string queryAssigneeStats = "SELECT assignee, COUNT(*) AS task_count, COUNT(CASE WHEN status = 'Выполнено' THEN 1 END) AS completed_tasks FROM tasks GROUP BY assignee";
                using (var cmd = new NpgsqlCommand(queryAssigneeStats, connection))
                {
                    var dataAdapter = new NpgsqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewAssigneeStats.DataSource = dataTable;
                }
            }
        }

        // Обработчик для кнопки расчета статистики
        private void buttonCalculateStatistics_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;
            CalculateStatistics(startDate, endDate);
        }

        private void labelAvgDuration_Click(object sender, EventArgs e)
        {

        }

       


    }

}

