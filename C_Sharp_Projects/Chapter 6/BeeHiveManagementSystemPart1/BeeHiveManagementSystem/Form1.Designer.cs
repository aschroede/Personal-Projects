namespace BeeHiveManagementSystem
{
    partial class Form1
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
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assignJobsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.workNextShiftButton = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintenance",
            "Honey manufacturing",
            "Nectar collector",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(19, 50);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(177, 21);
            this.workerBeeJob.TabIndex = 0;
            this.workerBeeJob.SelectedIndexChanged += new System.EventHandler(this.WorkerBeeJob_SelectedIndexChanged);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(220, 50);
            this.shifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(88, 20);
            this.shifts.TabIndex = 1;
            this.shifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifts.ValueChanged += new System.EventHandler(this.Shifts_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shifts";
            // 
            // assignJobsButton
            // 
            this.assignJobsButton.Location = new System.Drawing.Point(19, 92);
            this.assignJobsButton.Name = "assignJobsButton";
            this.assignJobsButton.Size = new System.Drawing.Size(289, 23);
            this.assignJobsButton.TabIndex = 4;
            this.assignJobsButton.Text = "Assign this job to a bee";
            this.assignJobsButton.UseVisualStyleBackColor = true;
            this.assignJobsButton.Click += new System.EventHandler(this.AssignJobsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignJobsButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // workNextShiftButton
            // 
            this.workNextShiftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workNextShiftButton.Location = new System.Drawing.Point(383, 28);
            this.workNextShiftButton.Name = "workNextShiftButton";
            this.workNextShiftButton.Size = new System.Drawing.Size(157, 115);
            this.workNextShiftButton.TabIndex = 6;
            this.workNextShiftButton.Text = "Work the next shift";
            this.workNextShiftButton.UseVisualStyleBackColor = true;
            this.workNextShiftButton.Click += new System.EventHandler(this.WorkNextShiftButton_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(26, 180);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(514, 258);
            this.report.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.report);
            this.Controls.Add(this.workNextShiftButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button assignJobsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button workNextShiftButton;
        private System.Windows.Forms.TextBox report;
    }
}

