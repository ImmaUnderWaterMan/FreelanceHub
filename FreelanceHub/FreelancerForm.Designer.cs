namespace FreelanceHub
{
    partial class FreelancerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            buttonTimer = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            listBoxTasks = new ListBox();
            buttonAddTask = new Button();
            buttonUpdateTask = new Button();
            buttonDeleteTask = new Button();
            button5 = new Button();
            listBoxProjects = new ListBox();
            buttonAddProject = new Button();
            buttonUpdateProject = new Button();
            buttonDeleteProject = new Button();
            labelTimerText = new Label();
            labelProjects = new Label();
            labelTasks = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 109);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "Задача пока не выбрана";
            // 
            // buttonTimer
            // 
            buttonTimer.Location = new Point(341, 182);
            buttonTimer.Name = "buttonTimer";
            buttonTimer.Size = new Size(109, 23);
            buttonTimer.TabIndex = 1;
            buttonTimer.Text = "Запустить таймер";
            buttonTimer.UseVisualStyleBackColor = true;
            buttonTimer.Click += buttonTimer_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += Timer1_Tick;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(506, 42);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(282, 289);
            listBoxTasks.TabIndex = 2;
            listBoxTasks.Visible = false;
            listBoxTasks.SelectedIndexChanged += listBoxTasks_SelectedIndexChanged;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(506, 362);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(75, 26);
            buttonAddTask.TabIndex = 3;
            buttonAddTask.Text = "Добавить";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Visible = false;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // buttonUpdateTask
            // 
            buttonUpdateTask.Location = new Point(587, 362);
            buttonUpdateTask.Name = "buttonUpdateTask";
            buttonUpdateTask.Size = new Size(95, 26);
            buttonUpdateTask.TabIndex = 4;
            buttonUpdateTask.Text = "Редактировать";
            buttonUpdateTask.UseVisualStyleBackColor = true;
            buttonUpdateTask.Visible = false;
            buttonUpdateTask.Click += buttonUpdateTasks_Click;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.Location = new Point(688, 362);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(75, 26);
            buttonDeleteTask.TabIndex = 5;
            buttonDeleteTask.Text = "Удалить";
            buttonDeleteTask.UseVisualStyleBackColor = true;
            buttonDeleteTask.Visible = false;
            buttonDeleteTask.Click += buttonDeleteTask_Click;
            // 
            // button5
            // 
            button5.Location = new Point(351, 415);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "Сохранить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonSaveToPDF_Click;
            // 
            // listBoxProjects
            // 
            listBoxProjects.FormattingEnabled = true;
            listBoxProjects.ItemHeight = 15;
            listBoxProjects.Location = new Point(12, 42);
            listBoxProjects.Name = "listBoxProjects";
            listBoxProjects.Size = new Size(248, 289);
            listBoxProjects.TabIndex = 7;
            listBoxProjects.SelectedIndexChanged += listBoxProjects_SelectedIndexChanged;
            // 
            // buttonAddProject
            // 
            buttonAddProject.Location = new Point(12, 362);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Size = new Size(75, 26);
            buttonAddProject.TabIndex = 8;
            buttonAddProject.Text = "Добавить";
            buttonAddProject.UseVisualStyleBackColor = true;
            buttonAddProject.Click += buttonAddProject_Click;
            // 
            // buttonUpdateProject
            // 
            buttonUpdateProject.Location = new Point(93, 362);
            buttonUpdateProject.Name = "buttonUpdateProject";
            buttonUpdateProject.Size = new Size(96, 26);
            buttonUpdateProject.TabIndex = 9;
            buttonUpdateProject.Text = "Редактировать";
            buttonUpdateProject.UseVisualStyleBackColor = true;
            buttonUpdateProject.Click += buttonUpdateProject_Click;
            // 
            // buttonDeleteProject
            // 
            buttonDeleteProject.Location = new Point(195, 362);
            buttonDeleteProject.Name = "buttonDeleteProject";
            buttonDeleteProject.Size = new Size(75, 26);
            buttonDeleteProject.TabIndex = 10;
            buttonDeleteProject.Text = "Удалить";
            buttonDeleteProject.UseVisualStyleBackColor = true;
            buttonDeleteProject.Click += buttonDeleteProject_Click;
            // 
            // labelTimerText
            // 
            labelTimerText.AutoSize = true;
            labelTimerText.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimerText.Location = new Point(341, 46);
            labelTimerText.Name = "labelTimerText";
            labelTimerText.Size = new Size(109, 30);
            labelTimerText.TabIndex = 11;
            labelTimerText.Text = "Таймер";
            // 
            // labelProjects
            // 
            labelProjects.AutoSize = true;
            labelProjects.Location = new Point(93, 9);
            labelProjects.Name = "labelProjects";
            labelProjects.Size = new Size(102, 15);
            labelProjects.TabIndex = 12;
            labelProjects.Text = "Список проектов";
            // 
            // labelTasks
            // 
            labelTasks.AutoSize = true;
            labelTasks.Location = new Point(644, 9);
            labelTasks.Name = "labelTasks";
            labelTasks.Size = new Size(81, 15);
            labelTasks.TabIndex = 13;
            labelTasks.Text = "Список задач";
            labelTasks.Visible = false;
            // 
            // FreelancerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTasks);
            Controls.Add(labelProjects);
            Controls.Add(labelTimerText);
            Controls.Add(buttonDeleteProject);
            Controls.Add(buttonUpdateProject);
            Controls.Add(buttonAddProject);
            Controls.Add(listBoxProjects);
            Controls.Add(button5);
            Controls.Add(buttonDeleteTask);
            Controls.Add(buttonUpdateTask);
            Controls.Add(buttonAddTask);
            Controls.Add(listBoxTasks);
            Controls.Add(buttonTimer);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FreelancerForm";
            Text = "FreelancerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonTimer;
        private System.Windows.Forms.Timer timer1;
        private ListBox listBoxTasks;
        private Button buttonAddTask;
        private Button buttonUpdateTask;
        private Button buttonDeleteTask;
        private Button button5;
        private ListBox listBoxProjects;
        private Button buttonAddProject;
        private Button buttonUpdateProject;
        private Button buttonDeleteProject;
        private Label labelTimerText;
        private Label labelProjects;
        private Label labelTasks;
    }
}