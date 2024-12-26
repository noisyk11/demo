using System.Windows.Forms;

namespace TaskManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм

        private void InitializeComponent()
        {


            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.labelAvgDuration = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCalculateStatistics = new System.Windows.Forms.Button();
            this.dataGridViewProjectStats = new System.Windows.Forms.DataGridView();
            this.dataGridViewAssigneeStats = new System.Windows.Forms.DataGridView();
            this.txtTaskNumber = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAssignee = new System.Windows.Forms.TextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.lblTaskNumber = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAssignee = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchTask = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLoadTasks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenerateQRCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigneeStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

          

            // dataGridViewTasks
            // 
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(381, 30);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowTemplate.Height = 24;
            this.dataGridViewTasks.Size = new System.Drawing.Size(600, 250);
            this.dataGridViewTasks.TabIndex = 15;
            // 
            // labelAvgDuration
            // 
            this.labelAvgDuration.AutoSize = true;
            this.labelAvgDuration.Location = new System.Drawing.Point(1308, 9);
            this.labelAvgDuration.Name = "labelAvgDuration";
            this.labelAvgDuration.Size = new System.Drawing.Size(162, 13);
            this.labelAvgDuration.TabIndex = 8;
            this.labelAvgDuration.Text = "Среднее время выполнения: 0";
            this.labelAvgDuration.Click += new System.EventHandler(this.labelAvgDuration_Click);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(1016, 256);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 9;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(1016, 282);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 10;
            // 
            // buttonCalculateStatistics
            // 
            this.buttonCalculateStatistics.Location = new System.Drawing.Point(1270, 253);
            this.buttonCalculateStatistics.Name = "buttonCalculateStatistics";
            this.buttonCalculateStatistics.Size = new System.Drawing.Size(200, 30);
            this.buttonCalculateStatistics.TabIndex = 11;
            this.buttonCalculateStatistics.Text = "Посчитать статистику";
            this.buttonCalculateStatistics.UseVisualStyleBackColor = true;
            this.buttonCalculateStatistics.Click += new System.EventHandler(this.buttonCalculateStatistics_Click);
            // 
            // dataGridViewProjectStats
            // 
            this.dataGridViewProjectStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjectStats.Location = new System.Drawing.Point(1006, 30);
            this.dataGridViewProjectStats.Name = "dataGridViewProjectStats";
            this.dataGridViewProjectStats.Size = new System.Drawing.Size(210, 210);
            this.dataGridViewProjectStats.TabIndex = 12;
            // 
            // dataGridViewAssigneeStats
            // 
            this.dataGridViewAssigneeStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssigneeStats.Location = new System.Drawing.Point(1231, 30);
            this.dataGridViewAssigneeStats.Name = "dataGridViewAssigneeStats";
            this.dataGridViewAssigneeStats.Size = new System.Drawing.Size(239, 210);
            this.dataGridViewAssigneeStats.TabIndex = 13;
            // 
            // txtTaskNumber
            // 
            this.txtTaskNumber.Location = new System.Drawing.Point(150, 30);
            this.txtTaskNumber.Name = "txtTaskNumber";
            this.txtTaskNumber.Size = new System.Drawing.Size(200, 20);
            this.txtTaskNumber.TabIndex = 0;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(150, 70);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(200, 20);
            this.txtProjectName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 107);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 60);
            this.txtDescription.TabIndex = 2;
            // 
            // txtAssignee
            // 
            this.txtAssignee.Location = new System.Drawing.Point(150, 190);
            this.txtAssignee.Name = "txtAssignee";
            this.txtAssignee.Size = new System.Drawing.Size(200, 20);
            this.txtAssignee.TabIndex = 3;
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Низкий",
            "Средний",
            "Высокий"});
            this.cmbPriority.Location = new System.Drawing.Point(150, 230);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(200, 21);
            this.cmbPriority.TabIndex = 4;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "В ожидании",
            "В работе",
            "Выполнено"});
            this.cmbStatus.Location = new System.Drawing.Point(150, 270);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 5;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(150, 300);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(200, 30);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "Добавить задачу";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(150, 345);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(200, 30);
            this.btnDeleteTask.TabIndex = 7;
            this.btnDeleteTask.Text = "Удалить задачу";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Location = new System.Drawing.Point(150, 390);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(200, 30);
            this.btnUpdateTask.TabIndex = 8;
            this.btnUpdateTask.Text = "Редактировать задачу";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // lblTaskNumber
            // 
            this.lblTaskNumber.AutoSize = true;
            this.lblTaskNumber.Location = new System.Drawing.Point(50, 30);
            this.lblTaskNumber.Name = "lblTaskNumber";
            this.lblTaskNumber.Size = new System.Drawing.Size(79, 13);
            this.lblTaskNumber.TabIndex = 9;
            this.lblTaskNumber.Text = "Номер задачи";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(50, 70);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(101, 13);
            this.lblProjectName.TabIndex = 10;
            this.lblProjectName.Text = "Название проекта";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(50, 110);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(57, 13);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Описание";
            // 
            // lblAssignee
            // 
            this.lblAssignee.AutoSize = true;
            this.lblAssignee.Location = new System.Drawing.Point(50, 190);
            this.lblAssignee.Name = "lblAssignee";
            this.lblAssignee.Size = new System.Drawing.Size(74, 13);
            this.lblAssignee.TabIndex = 12;
            this.lblAssignee.Text = "Исполнитель";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(380, 400);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 17;
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.Location = new System.Drawing.Point(600, 400);
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(100, 30);
            this.btnSearchTask.TabIndex = 18;
            this.btnSearchTask.Text = "Поиск";
            this.btnSearchTask.UseVisualStyleBackColor = true;
            this.btnSearchTask.Click += new System.EventHandler(this.btnSearchTask_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(722, 303);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDueDate.TabIndex = 19;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(619, 309);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(97, 13);
            this.lblDueDate.TabIndex = 20;
            this.lblDueDate.Text = "Срок выполнения";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(50, 230);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(61, 13);
            this.lblPriority.TabIndex = 13;
            this.lblPriority.Text = "Приоритет";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(50, 270);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Статус";
            // 
            // btnLoadTasks
            // 
            this.btnLoadTasks.Location = new System.Drawing.Point(381, 300);
            this.btnLoadTasks.Name = "btnLoadTasks";
            this.btnLoadTasks.Size = new System.Drawing.Size(200, 30);
            this.btnLoadTasks.TabIndex = 16;
            this.btnLoadTasks.Text = "Загрузить задачи";
            this.btnLoadTasks.UseVisualStyleBackColor = true;
            this.btnLoadTasks.Click += new System.EventHandler(this.btnLoadTasks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1231, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 223);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGenerateQRCode
            // 
            this.btnGenerateQRCode.Location = new System.Drawing.Point(1006, 327);
            this.btnGenerateQRCode.Name = "btnGenerateQRCode";
            this.btnGenerateQRCode.Size = new System.Drawing.Size(200, 40);
            this.btnGenerateQRCode.TabIndex = 1;
            this.btnGenerateQRCode.Text = "Сгенерировать QR-код";
            this.btnGenerateQRCode.UseVisualStyleBackColor = true;
            this.btnGenerateQRCode.Click += new System.EventHandler(this.btnGenerateQRCode_Click);
            // 
            // Form1
            // 
            
            this.ClientSize = new System.Drawing.Size(1511, 555);
            this.Controls.Add(this.dataGridViewAssigneeStats);
            this.Controls.Add(this.dataGridViewProjectStats);
            this.Controls.Add(this.buttonCalculateStatistics);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelAvgDuration);
            this.Controls.Add(this.btnGenerateQRCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnSearchTask);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTaskNumber);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAssignee);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.lblTaskNumber);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAssignee);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dataGridViewTasks);
            this.Controls.Add(this.btnLoadTasks);
            this.Name = "Form1";
            this.Text = "Менеджер задач";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigneeStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenerateQRCode;

        private System.Windows.Forms.Label labelAvgDuration;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button buttonCalculateStatistics;
        private System.Windows.Forms.DataGridView dataGridViewProjectStats;
        private System.Windows.Forms.DataGridView dataGridViewAssigneeStats;


       

        private System.Windows.Forms.TextBox txtTaskNumber;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAssignee;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnUpdateTask;  // Кнопка редактирования
        private System.Windows.Forms.Label lblTaskNumber;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAssignee;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Button btnLoadTasks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchTask;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
    }
}
