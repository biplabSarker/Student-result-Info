namespace View
{
    partial class DeleteStudentView
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
            this.btnDelStudent = new System.Windows.Forms.Button();
            this.txtDelStudentSession = new System.Windows.Forms.TextBox();
            this.txtDelStudentRoll = new System.Windows.Forms.TextBox();
            this.txtDelStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrdDelView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDelView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelStudent
            // 
            this.btnDelStudent.Location = new System.Drawing.Point(142, 170);
            this.btnDelStudent.Name = "btnDelStudent";
            this.btnDelStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDelStudent.TabIndex = 20;
            this.btnDelStudent.Text = "Delete";
            this.btnDelStudent.UseVisualStyleBackColor = true;
            this.btnDelStudent.Click += new System.EventHandler(this.btnDelStudent_Click);
            // 
            // txtDelStudentSession
            // 
            this.txtDelStudentSession.Location = new System.Drawing.Point(130, 128);
            this.txtDelStudentSession.Name = "txtDelStudentSession";
            this.txtDelStudentSession.Size = new System.Drawing.Size(100, 20);
            this.txtDelStudentSession.TabIndex = 21;
            // 
            // txtDelStudentRoll
            // 
            this.txtDelStudentRoll.Location = new System.Drawing.Point(130, 99);
            this.txtDelStudentRoll.Name = "txtDelStudentRoll";
            this.txtDelStudentRoll.Size = new System.Drawing.Size(100, 20);
            this.txtDelStudentRoll.TabIndex = 19;
            // 
            // txtDelStudentName
            // 
            this.txtDelStudentName.Location = new System.Drawing.Point(130, 60);
            this.txtDelStudentName.Name = "txtDelStudentName";
            this.txtDelStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtDelStudentName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Session :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Roll :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name :";
            // 
            // GrdDelView
            // 
            this.GrdDelView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDelView.Location = new System.Drawing.Point(257, 12);
            this.GrdDelView.Name = "GrdDelView";
            this.GrdDelView.Size = new System.Drawing.Size(363, 331);
            this.GrdDelView.TabIndex = 22;
            this.GrdDelView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDelView_CellClick);
            // 
            // DeleteStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 355);
            this.Controls.Add(this.GrdDelView);
            this.Controls.Add(this.btnDelStudent);
            this.Controls.Add(this.txtDelStudentSession);
            this.Controls.Add(this.txtDelStudentRoll);
            this.Controls.Add(this.txtDelStudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteStudentView";
            this.Text = "DeleteStudentView";
            this.Load += new System.EventHandler(this.DeleteStudentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDelView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelStudent;
        private System.Windows.Forms.TextBox txtDelStudentSession;
        private System.Windows.Forms.TextBox txtDelStudentRoll;
        private System.Windows.Forms.TextBox txtDelStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrdDelView;
    }
}