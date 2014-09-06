namespace View
{
    partial class ViewAddEnrolment
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
            this.cmbStudentId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCourseTitle = new System.Windows.Forms.ComboBox();
            this.btnEnrolStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Id :";
            // 
            // cmbStudentId
            // 
            this.cmbStudentId.FormattingEnabled = true;
            this.cmbStudentId.Location = new System.Drawing.Point(192, 75);
            this.cmbStudentId.Name = "cmbStudentId";
            this.cmbStudentId.Size = new System.Drawing.Size(219, 21);
            this.cmbStudentId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Title :";
            // 
            // cmbCourseTitle
            // 
            this.cmbCourseTitle.FormattingEnabled = true;
            this.cmbCourseTitle.Location = new System.Drawing.Point(192, 126);
            this.cmbCourseTitle.Name = "cmbCourseTitle";
            this.cmbCourseTitle.Size = new System.Drawing.Size(219, 21);
            this.cmbCourseTitle.TabIndex = 3;
            // 
            // btnEnrolStudent
            // 
            this.btnEnrolStudent.Location = new System.Drawing.Point(192, 191);
            this.btnEnrolStudent.Name = "btnEnrolStudent";
            this.btnEnrolStudent.Size = new System.Drawing.Size(168, 23);
            this.btnEnrolStudent.TabIndex = 4;
            this.btnEnrolStudent.Text = "Enrol Student On Course";
            this.btnEnrolStudent.UseVisualStyleBackColor = true;
            this.btnEnrolStudent.Click += new System.EventHandler(this.btnEnrolStudent_Click);
            // 
            // ViewAddEnrolment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 287);
            this.Controls.Add(this.btnEnrolStudent);
            this.Controls.Add(this.cmbCourseTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStudentId);
            this.Controls.Add(this.label1);
            this.Name = "ViewAddEnrolment";
            this.Text = "ViewAddEnrolment";
            this.Load += new System.EventHandler(this.ViewAddEnrolment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCourseTitle;
        private System.Windows.Forms.Button btnEnrolStudent;
    }
}