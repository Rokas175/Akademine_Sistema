
namespace Akademine_Sistema
{
    partial class Deletions
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
            this.dataGridView_students = new System.Windows.Forms.DataGridView();
            this.btn_delete_student = new System.Windows.Forms.Button();
            this.btn_delete_lecturer = new System.Windows.Forms.Button();
            this.dataGridView_lecturers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete_group = new System.Windows.Forms.Button();
            this.dataGridView_groups = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_delete_subject = new System.Windows.Forms.Button();
            this.dataGridView_subjects = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lecturers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subjects)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Students";
            // 
            // dataGridView_students
            // 
            this.dataGridView_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_students.Location = new System.Drawing.Point(24, 29);
            this.dataGridView_students.Name = "dataGridView_students";
            this.dataGridView_students.ReadOnly = true;
            this.dataGridView_students.RowHeadersWidth = 51;
            this.dataGridView_students.RowTemplate.Height = 24;
            this.dataGridView_students.Size = new System.Drawing.Size(1012, 150);
            this.dataGridView_students.TabIndex = 7;
            // 
            // btn_delete_student
            // 
            this.btn_delete_student.Location = new System.Drawing.Point(24, 185);
            this.btn_delete_student.Name = "btn_delete_student";
            this.btn_delete_student.Size = new System.Drawing.Size(238, 23);
            this.btn_delete_student.TabIndex = 8;
            this.btn_delete_student.Text = "Delete Selected Student";
            this.btn_delete_student.UseVisualStyleBackColor = true;
            this.btn_delete_student.Click += new System.EventHandler(this.btn_delete_student_Click);
            // 
            // btn_delete_lecturer
            // 
            this.btn_delete_lecturer.Location = new System.Drawing.Point(24, 414);
            this.btn_delete_lecturer.Name = "btn_delete_lecturer";
            this.btn_delete_lecturer.Size = new System.Drawing.Size(238, 23);
            this.btn_delete_lecturer.TabIndex = 11;
            this.btn_delete_lecturer.Text = "Delete Selected Lecturer";
            this.btn_delete_lecturer.UseVisualStyleBackColor = true;
            this.btn_delete_lecturer.Click += new System.EventHandler(this.btn_delete_lecturer_Click);
            // 
            // dataGridView_lecturers
            // 
            this.dataGridView_lecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lecturers.Location = new System.Drawing.Point(24, 258);
            this.dataGridView_lecturers.Name = "dataGridView_lecturers";
            this.dataGridView_lecturers.RowHeadersWidth = 51;
            this.dataGridView_lecturers.RowTemplate.Height = 24;
            this.dataGridView_lecturers.Size = new System.Drawing.Size(1012, 150);
            this.dataGridView_lecturers.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lecturers";
            // 
            // btn_delete_group
            // 
            this.btn_delete_group.Location = new System.Drawing.Point(24, 640);
            this.btn_delete_group.Name = "btn_delete_group";
            this.btn_delete_group.Size = new System.Drawing.Size(238, 23);
            this.btn_delete_group.TabIndex = 14;
            this.btn_delete_group.Text = "Delete Selected Group";
            this.btn_delete_group.UseVisualStyleBackColor = true;
            this.btn_delete_group.Click += new System.EventHandler(this.btn_delete_group_Click);
            // 
            // dataGridView_groups
            // 
            this.dataGridView_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_groups.Location = new System.Drawing.Point(24, 484);
            this.dataGridView_groups.Name = "dataGridView_groups";
            this.dataGridView_groups.RowHeadersWidth = 51;
            this.dataGridView_groups.RowTemplate.Height = 24;
            this.dataGridView_groups.Size = new System.Drawing.Size(1012, 150);
            this.dataGridView_groups.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Groups";
            // 
            // btn_delete_subject
            // 
            this.btn_delete_subject.Location = new System.Drawing.Point(24, 857);
            this.btn_delete_subject.Name = "btn_delete_subject";
            this.btn_delete_subject.Size = new System.Drawing.Size(238, 23);
            this.btn_delete_subject.TabIndex = 17;
            this.btn_delete_subject.Text = "Delete Selected Subject";
            this.btn_delete_subject.UseVisualStyleBackColor = true;
            this.btn_delete_subject.Click += new System.EventHandler(this.btn_delete_subject_Click);
            // 
            // dataGridView_subjects
            // 
            this.dataGridView_subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_subjects.Location = new System.Drawing.Point(24, 701);
            this.dataGridView_subjects.Name = "dataGridView_subjects";
            this.dataGridView_subjects.RowHeadersWidth = 51;
            this.dataGridView_subjects.RowTemplate.Height = 24;
            this.dataGridView_subjects.Size = new System.Drawing.Size(1012, 150);
            this.dataGridView_subjects.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 681);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Subjects";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(908, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(908, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 664);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(908, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------------";
            // 
            // Deletions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 1110);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_delete_subject);
            this.Controls.Add(this.dataGridView_subjects);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_delete_group);
            this.Controls.Add(this.dataGridView_groups);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_delete_lecturer);
            this.Controls.Add(this.dataGridView_lecturers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete_student);
            this.Controls.Add(this.dataGridView_students);
            this.Controls.Add(this.label1);
            this.Name = "Deletions";
            this.Text = "Deletions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lecturers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_students;
        private System.Windows.Forms.Button btn_delete_student;
        private System.Windows.Forms.Button btn_delete_lecturer;
        private System.Windows.Forms.DataGridView dataGridView_lecturers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete_group;
        private System.Windows.Forms.DataGridView dataGridView_groups;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_delete_subject;
        private System.Windows.Forms.DataGridView dataGridView_subjects;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}