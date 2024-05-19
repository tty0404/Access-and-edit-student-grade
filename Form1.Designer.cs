namespace Assigment_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_name = new TextBox();
            txt_course = new TextBox();
            txt_mark = new TextBox();
            btn_update = new Button();
            btn_save = new Button();
            btn_load = new Button();
            btn_exit = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            studentName = new DataGridViewTextBoxColumn();
            courseName = new DataGridViewTextBoxColumn();
            btn_dele = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 46);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = " Student name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 46);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Course";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 46);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Mark";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(67, 83);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(165, 23);
            txt_name.TabIndex = 0;
            txt_name.Enter += txt_name_Enter;
            // 
            // txt_course
            // 
            txt_course.Location = new Point(252, 84);
            txt_course.Name = "txt_course";
            txt_course.Size = new Size(165, 23);
            txt_course.TabIndex = 1;
            // 
            // txt_mark
            // 
            txt_mark.Location = new Point(437, 86);
            txt_mark.Name = "txt_mark";
            txt_mark.Size = new Size(100, 23);
            txt_mark.TabIndex = 2;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(287, 373);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 5;
            btn_update.Text = "&Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click_1;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(231, 145);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 3;
            btn_save.Text = "&Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(177, 373);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(75, 23);
            btn_load.TabIndex = 6;
            btn_load.Text = "&Load";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(331, 145);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 23);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "&Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, studentName, courseName });
            dataGridView1.Location = new Point(36, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(646, 150);
            dataGridView1.TabIndex = 7;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // studentName
            // 
            studentName.HeaderText = "student name";
            studentName.Name = "studentName";
            studentName.Width = 250;
            // 
            // courseName
            // 
            courseName.HeaderText = "course name";
            courseName.Name = "courseName";
            courseName.Width = 250;
            // 
            // btn_dele
            // 
            btn_dele.Location = new Point(396, 373);
            btn_dele.Name = "btn_dele";
            btn_dele.Size = new Size(75, 23);
            btn_dele.TabIndex = 7;
            btn_dele.Text = "&Delete file";
            btn_dele.UseVisualStyleBackColor = true;
            btn_dele.Click += btn_dele_Click;
            // 
            // Form1
            // 
            AcceptButton = btn_save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_exit;
            ClientSize = new Size(704, 478);
            Controls.Add(btn_dele);
            Controls.Add(dataGridView1);
            Controls.Add(btn_exit);
            Controls.Add(btn_load);
            Controls.Add(btn_save);
            Controls.Add(btn_update);
            Controls.Add(txt_mark);
            Controls.Add(txt_course);
            Controls.Add(txt_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_name;
        private TextBox txt_course;
        private TextBox txt_mark;
        private Button btn_update;
        private Button btn_save;
        private Button btn_load;
        private Button btn_exit;
        private DataGridView dataGridView1;
        private Button btn_dele;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn studentName;
        private DataGridViewTextBoxColumn courseName;
    }
}
