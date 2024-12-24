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
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.btnLoadTasks = new System.Windows.Forms.Button();
            this.btnStatCompletedTasks = new System.Windows.Forms.Button();
            this.btnAvgCompletionTime = new System.Windows.Forms.Button();
            this.btnProjectAssigneeStats = new System.Windows.Forms.Button();
            this.lblCompletedTasks = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lstProjectAssigneeStats = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
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
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(381, 30);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowTemplate.Height = 24;
            this.dataGridViewTasks.Size = new System.Drawing.Size(600, 250);
            this.dataGridViewTasks.TabIndex = 15;
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
            // btnStatCompletedTasks
            // 
            this.btnStatCompletedTasks.Location = new System.Drawing.Point(1006, 180);
            this.btnStatCompletedTasks.Name = "btnStatCompletedTasks";
            this.btnStatCompletedTasks.Size = new System.Drawing.Size(200, 23);
            this.btnStatCompletedTasks.TabIndex = 19;
            this.btnStatCompletedTasks.Text = "Статистика по выполненным задачам";
            this.btnStatCompletedTasks.UseVisualStyleBackColor = true;
            this.btnStatCompletedTasks.Click += new System.EventHandler(this.btnStatCompletedTasks_Click);
            // 
            // btnAvgCompletionTime
            // 
            this.btnAvgCompletionTime.Location = new System.Drawing.Point(1006, 220);
            this.btnAvgCompletionTime.Name = "btnAvgCompletionTime";
            this.btnAvgCompletionTime.Size = new System.Drawing.Size(200, 23);
            this.btnAvgCompletionTime.TabIndex = 20;
            this.btnAvgCompletionTime.Text = "Среднее время выполнения";
            this.btnAvgCompletionTime.UseVisualStyleBackColor = true;
            this.btnAvgCompletionTime.Click += new System.EventHandler(this.btnAvgCompletionTime_Click);
            // 
            // btnProjectAssigneeStats
            // 
            this.btnProjectAssigneeStats.Location = new System.Drawing.Point(1006, 260);
            this.btnProjectAssigneeStats.Name = "btnProjectAssigneeStats";
            this.btnProjectAssigneeStats.Size = new System.Drawing.Size(200, 47);
            this.btnProjectAssigneeStats.TabIndex = 21;
            this.btnProjectAssigneeStats.Text = "Статистика по проектам и исполнителям";
            this.btnProjectAssigneeStats.UseVisualStyleBackColor = true;
            this.btnProjectAssigneeStats.Click += new System.EventHandler(this.btnProjectAssigneeStats_Click);
            // 
            // lblCompletedTasks
            // 
            this.lblCompletedTasks.AutoSize = true;
            this.lblCompletedTasks.Location = new System.Drawing.Point(400, 12);
            this.lblCompletedTasks.Name = "lblCompletedTasks";
            this.lblCompletedTasks.Size = new System.Drawing.Size(108, 13);
            this.lblCompletedTasks.TabIndex = 14;
            this.lblCompletedTasks.Text = "Выполнено задач: 0";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(1006, 30);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 17;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(1006, 70);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 18;
            // 
            // lstProjectAssigneeStats
            // 
            this.lstProjectAssigneeStats.FormattingEnabled = true;
            this.lstProjectAssigneeStats.Location = new System.Drawing.Point(1006, 111);
            this.lstProjectAssigneeStats.Name = "lstProjectAssigneeStats";
            this.lstProjectAssigneeStats.Size = new System.Drawing.Size(200, 56);
            this.lstProjectAssigneeStats.TabIndex = 22;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1280, 459);
            this.Controls.Add(this.btnStatCompletedTasks);
            this.Controls.Add(this.btnAvgCompletionTime);
            this.Controls.Add(this.btnProjectAssigneeStats);
            this.Controls.Add(this.lblCompletedTasks);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lstProjectAssigneeStats);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStatCompletedTasks;
        private Button btnAvgCompletionTime;
        private Button btnProjectAssigneeStats;
        private Label lblCompletedTasks;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private ListBox lstProjectAssigneeStats;

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
