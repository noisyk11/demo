using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
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

        private void LoadTasks()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tasks";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridViewTasks.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке задач: {ex.Message}");
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

        // 1. Статистика по выполненным задачам
        private void btnStatCompletedTasks_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM tasks WHERE status = 'Выполнено' AND due_date BETWEEN @startDate AND @endDate";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("startDate", dtpStartDate.Value);
                        cmd.Parameters.AddWithValue("endDate", dtpEndDate.Value);

                        var result = cmd.ExecuteScalar();
                        lblCompletedTasks.Text = $"Выполнено задач: {result}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при расчёте статистики выполненных задач: {ex.Message}");
            }
        }

        // 2. Статистика по среднему времени выполнения задач
        private void btnAvgCompletionTime_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT AVG(EXTRACT(EPOCH FROM (due_date - created_at)) / 3600) FROM tasks WHERE status = 'Выполнено' AND due_date BETWEEN @startDate AND @endDate";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("startDate", dtpStartDate.Value);
                        cmd.Parameters.AddWithValue("endDate", dtpEndDate.Value);

                        var result = cmd.ExecuteScalar();
                        //lblAvgCompletionTime.Text = $"Среднее время выполнения: {result} ч";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при расчёте среднего времени выполнения: {ex.Message}");
            }
        }

        // 3. Статистика по проектам и исполнителям
        private void btnProjectAssigneeStats_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT project_name, assignee, COUNT(*) FROM tasks GROUP BY project_name, assignee";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            lstProjectAssigneeStats.Items.Clear();
                            while (reader.Read())
                            {
                                string projectName = reader.GetString(0);
                                string assignee = reader.GetString(1);
                                int taskCount = reader.GetInt32(2);

                                lstProjectAssigneeStats.Items.Add($"{projectName} - {assignee}: {taskCount} задач");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при расчёте статистики по проектам и исполнителям: {ex.Message}");
            }
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
    }

}

