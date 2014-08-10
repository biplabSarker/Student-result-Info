namespace Controller
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDiscipline = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            // 
            // courseRegistrationToolStripMenuItem
            // 
            this.courseRegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem});
            this.courseRegistrationToolStripMenuItem.Name = "courseRegistrationToolStripMenuItem";
            this.courseRegistrationToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.courseRegistrationToolStripMenuItem.Text = "Course Registration";
            // 
            // marksEntryToolStripMenuItem
            // 
            this.marksEntryToolStripMenuItem.Name = "marksEntryToolStripMenuItem";
            this.marksEntryToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.marksEntryToolStripMenuItem.Text = "Marks Entry";
            // 
            // btnDiscipline
            // 
            this.btnDiscipline.Location = new System.Drawing.Point(344, 186);
            this.btnDiscipline.Name = "btnDiscipline";
            this.btnDiscipline.Size = new System.Drawing.Size(111, 23);
            this.btnDiscipline.TabIndex = 8;
            this.btnDiscipline.Text = "Create Discipline";
            this.btnDiscipline.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // printResultToolStripMenuItem
            // 
            this.printResultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentWiseToolStripMenuItem,
            this.courseWiseToolStripMenuItem});
            this.printResultToolStripMenuItem.Name = "printResultToolStripMenuItem";
            this.printResultToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.printResultToolStripMenuItem.Text = "Print Result";
            // 
            // studentWiseToolStripMenuItem
            // 
            this.studentWiseToolStripMenuItem.Name = "studentWiseToolStripMenuItem";
            this.studentWiseToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.studentWiseToolStripMenuItem.Text = "Student Wise";
            // 
            // courseWiseToolStripMenuItem
            // 
            this.courseWiseToolStripMenuItem.Name = "courseWiseToolStripMenuItem";
            this.courseWiseToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.courseWiseToolStripMenuItem.Text = "Course Wise";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createStudentToolStripMenuItem,
            this.courseRegistrationToolStripMenuItem,
            this.marksEntryToolStripMenuItem,
            this.printResultToolStripMenuItem,
            this.databaseManagementToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createStudentToolStripMenuItem
            // 
            this.createStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBatchToolStripMenuItem,
            this.addStudentToolStripMenuItem});
            this.createStudentToolStripMenuItem.Name = "createStudentToolStripMenuItem";
            this.createStudentToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.createStudentToolStripMenuItem.Text = "Create Student";
            // 
            // addBatchToolStripMenuItem
            // 
            this.addBatchToolStripMenuItem.Name = "addBatchToolStripMenuItem";
            this.addBatchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addBatchToolStripMenuItem.Text = "Add Batch";
            this.addBatchToolStripMenuItem.Click += new System.EventHandler(this.addBatchToolStripMenuItem_Click);
            // 
            // databaseManagementToolStripMenuItem
            // 
            this.databaseManagementToolStripMenuItem.Name = "databaseManagementToolStripMenuItem";
            this.databaseManagementToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.databaseManagementToolStripMenuItem.Text = "Database Management";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(244, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Khulna University";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 424);
            this.Controls.Add(this.btnDiscipline);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "StudentsResultInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marksEntryToolStripMenuItem;
        private System.Windows.Forms.Button btnDiscipline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseWiseToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

