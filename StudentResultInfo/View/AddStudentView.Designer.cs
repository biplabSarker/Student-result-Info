namespace View
{
    partial class AddStudentView
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtAddStudentSession = new System.Windows.Forms.TextBox();
            this.txtAddStudentRoll = new System.Windows.Forms.TextBox();
            this.txtAddStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(142, 175);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 27;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtAddStudentSession
            // 
            this.txtAddStudentSession.Location = new System.Drawing.Point(130, 133);
            this.txtAddStudentSession.Name = "txtAddStudentSession";
            this.txtAddStudentSession.Size = new System.Drawing.Size(100, 20);
            this.txtAddStudentSession.TabIndex = 28;
            // 
            // txtAddStudentRoll
            // 
            this.txtAddStudentRoll.Location = new System.Drawing.Point(130, 104);
            this.txtAddStudentRoll.Name = "txtAddStudentRoll";
            this.txtAddStudentRoll.Size = new System.Drawing.Size(100, 20);
            this.txtAddStudentRoll.TabIndex = 26;
            // 
            // txtAddStudentName
            // 
            this.txtAddStudentName.Location = new System.Drawing.Point(130, 65);
            this.txtAddStudentName.Name = "txtAddStudentName";
            this.txtAddStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtAddStudentName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Session :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Roll :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name :";
            // 
            // AddStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtAddStudentSession);
            this.Controls.Add(this.txtAddStudentRoll);
            this.Controls.Add(this.txtAddStudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentView";
            this.Text = "AddStudentView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtAddStudentSession;
        private System.Windows.Forms.TextBox txtAddStudentRoll;
        private System.Windows.Forms.TextBox txtAddStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}