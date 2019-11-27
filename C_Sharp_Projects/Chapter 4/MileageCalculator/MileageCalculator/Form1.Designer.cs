namespace MileageCalculator
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
            this.StartingMileage = new System.Windows.Forms.Label();
            this.EndingMileage = new System.Windows.Forms.Label();
            this.AmountOwed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InitialMileage = new System.Windows.Forms.NumericUpDown();
            this.FinalMileage = new System.Windows.Forms.NumericUpDown();
            this.Calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InitialMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // StartingMileage
            // 
            this.StartingMileage.AutoSize = true;
            this.StartingMileage.Location = new System.Drawing.Point(50, 26);
            this.StartingMileage.Name = "StartingMileage";
            this.StartingMileage.Size = new System.Drawing.Size(83, 13);
            this.StartingMileage.TabIndex = 0;
            this.StartingMileage.Text = "Starting Mileage";
            // 
            // EndingMileage
            // 
            this.EndingMileage.AutoSize = true;
            this.EndingMileage.Location = new System.Drawing.Point(50, 61);
            this.EndingMileage.Name = "EndingMileage";
            this.EndingMileage.Size = new System.Drawing.Size(80, 13);
            this.EndingMileage.TabIndex = 1;
            this.EndingMileage.Text = "Ending Mileage";
            // 
            // AmountOwed
            // 
            this.AmountOwed.AutoSize = true;
            this.AmountOwed.Location = new System.Drawing.Point(49, 98);
            this.AmountOwed.Name = "AmountOwed";
            this.AmountOwed.Size = new System.Drawing.Size(74, 13);
            this.AmountOwed.TabIndex = 2;
            this.AmountOwed.Text = "Amount Owed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(144, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // InitialMileage
            // 
            this.InitialMileage.Location = new System.Drawing.Point(148, 24);
            this.InitialMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.InitialMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InitialMileage.Name = "InitialMileage";
            this.InitialMileage.Size = new System.Drawing.Size(120, 20);
            this.InitialMileage.TabIndex = 4;
            this.InitialMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FinalMileage
            // 
            this.FinalMileage.Location = new System.Drawing.Point(148, 59);
            this.FinalMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.FinalMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FinalMileage.Name = "FinalMileage";
            this.FinalMileage.Size = new System.Drawing.Size(120, 20);
            this.FinalMileage.TabIndex = 5;
            this.FinalMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(133, 125);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(98, 32);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 172);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.FinalMileage);
            this.Controls.Add(this.InitialMileage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AmountOwed);
            this.Controls.Add(this.EndingMileage);
            this.Controls.Add(this.StartingMileage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InitialMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartingMileage;
        private System.Windows.Forms.Label EndingMileage;
        private System.Windows.Forms.Label AmountOwed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown InitialMileage;
        private System.Windows.Forms.NumericUpDown FinalMileage;
        private System.Windows.Forms.Button Calculate;
    }
}

