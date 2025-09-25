namespace Learning_C_
{
    partial class frmToDoListApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tbNewTask = new System.Windows.Forms.TextBox();
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.btnShowSelectedTasks = new System.Windows.Forms.Button();
            this.btnRemoveAllTasks = new System.Windows.Forms.Button();
            this.btnUncheckAllTasks = new System.Windows.Forms.Button();
            this.btnCheckAllTasks = new System.Windows.Forms.Button();
            this.btnRemoveSelectedTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(396, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Azure;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(360, 130);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(461, 254);
            this.checkedListBox1.TabIndex = 1;
            // 
            // tbNewTask
            // 
            this.tbNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewTask.Location = new System.Drawing.Point(360, 408);
            this.tbNewTask.Name = "tbNewTask";
            this.tbNewTask.Size = new System.Drawing.Size(461, 30);
            this.tbNewTask.TabIndex = 2;
            this.tbNewTask.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNewTask_KeyDown);
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTask.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewTask.Location = new System.Drawing.Point(485, 495);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(190, 70);
            this.btnAddNewTask.TabIndex = 3;
            this.btnAddNewTask.Text = "Add New Task";
            this.btnAddNewTask.UseVisualStyleBackColor = false;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // btnShowSelectedTasks
            // 
            this.btnShowSelectedTasks.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowSelectedTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSelectedTasks.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSelectedTasks.Location = new System.Drawing.Point(61, 460);
            this.btnShowSelectedTasks.Name = "btnShowSelectedTasks";
            this.btnShowSelectedTasks.Size = new System.Drawing.Size(349, 70);
            this.btnShowSelectedTasks.TabIndex = 4;
            this.btnShowSelectedTasks.Text = "Show Checked Tasks";
            this.btnShowSelectedTasks.UseVisualStyleBackColor = false;
            this.btnShowSelectedTasks.Click += new System.EventHandler(this.btnShowSelectedTasks_Click);
            // 
            // btnRemoveAllTasks
            // 
            this.btnRemoveAllTasks.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRemoveAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAllTasks.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllTasks.Location = new System.Drawing.Point(61, 616);
            this.btnRemoveAllTasks.Name = "btnRemoveAllTasks";
            this.btnRemoveAllTasks.Size = new System.Drawing.Size(349, 70);
            this.btnRemoveAllTasks.TabIndex = 9;
            this.btnRemoveAllTasks.Text = "Remove All Tasks";
            this.btnRemoveAllTasks.UseVisualStyleBackColor = false;
            this.btnRemoveAllTasks.Click += new System.EventHandler(this.btnRemoveAllTasks_Click);
            // 
            // btnUncheckAllTasks
            // 
            this.btnUncheckAllTasks.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUncheckAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUncheckAllTasks.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUncheckAllTasks.Location = new System.Drawing.Point(778, 616);
            this.btnUncheckAllTasks.Name = "btnUncheckAllTasks";
            this.btnUncheckAllTasks.Size = new System.Drawing.Size(355, 70);
            this.btnUncheckAllTasks.TabIndex = 8;
            this.btnUncheckAllTasks.Text = "UnCheck All Tasks";
            this.btnUncheckAllTasks.UseVisualStyleBackColor = false;
            this.btnUncheckAllTasks.Click += new System.EventHandler(this.btnUncheckAllTasks_Click);
            // 
            // btnCheckAllTasks
            // 
            this.btnCheckAllTasks.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCheckAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAllTasks.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAllTasks.Location = new System.Drawing.Point(778, 460);
            this.btnCheckAllTasks.Name = "btnCheckAllTasks";
            this.btnCheckAllTasks.Size = new System.Drawing.Size(355, 70);
            this.btnCheckAllTasks.TabIndex = 7;
            this.btnCheckAllTasks.Text = "Check All Tasks";
            this.btnCheckAllTasks.UseVisualStyleBackColor = false;
            this.btnCheckAllTasks.Click += new System.EventHandler(this.btnCheckAllTasks_Click);
            // 
            // btnRemoveSelectedTask
            // 
            this.btnRemoveSelectedTask.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRemoveSelectedTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedTask.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelectedTask.Location = new System.Drawing.Point(485, 581);
            this.btnRemoveSelectedTask.Name = "btnRemoveSelectedTask";
            this.btnRemoveSelectedTask.Size = new System.Drawing.Size(190, 70);
            this.btnRemoveSelectedTask.TabIndex = 10;
            this.btnRemoveSelectedTask.Text = "Remove Task";
            this.btnRemoveSelectedTask.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedTask.Click += new System.EventHandler(this.btnRemoveSelectedTask_Click);
            // 
            // frmCheckListBoxExercice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1199, 735);
            this.Controls.Add(this.btnRemoveSelectedTask);
            this.Controls.Add(this.btnRemoveAllTasks);
            this.Controls.Add(this.btnUncheckAllTasks);
            this.Controls.Add(this.btnCheckAllTasks);
            this.Controls.Add(this.btnShowSelectedTasks);
            this.Controls.Add(this.btnAddNewTask);
            this.Controls.Add(this.tbNewTask);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmCheckListBoxExercice";
            this.Text = "frmCheckListBoxExercice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox tbNewTask;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.Button btnShowSelectedTasks;
        private System.Windows.Forms.Button btnRemoveAllTasks;
        private System.Windows.Forms.Button btnUncheckAllTasks;
        private System.Windows.Forms.Button btnCheckAllTasks;
        private System.Windows.Forms.Button btnRemoveSelectedTask;
    }
}