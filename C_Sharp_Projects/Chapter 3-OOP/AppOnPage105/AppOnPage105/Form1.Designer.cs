namespace AppOnPage105
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
            this.ThingToSay = new System.Windows.Forms.TextBox();
            this.SayThis = new System.Windows.Forms.Label();
            this.NumberOfTimes = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Speak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ThingToSay
            // 
            this.ThingToSay.Location = new System.Drawing.Point(120, 26);
            this.ThingToSay.Name = "ThingToSay";
            this.ThingToSay.Size = new System.Drawing.Size(200, 20);
            this.ThingToSay.TabIndex = 0;
            this.ThingToSay.Text = "Hello!";
            // 
            // SayThis
            // 
            this.SayThis.AutoSize = true;
            this.SayThis.Location = new System.Drawing.Point(36, 29);
            this.SayThis.Name = "SayThis";
            this.SayThis.Size = new System.Drawing.Size(47, 13);
            this.SayThis.TabIndex = 1;
            this.SayThis.Text = "Say this:";
            // 
            // NumberOfTimes
            // 
            this.NumberOfTimes.AutoSize = true;
            this.NumberOfTimes.Location = new System.Drawing.Point(39, 62);
            this.NumberOfTimes.Name = "NumberOfTimes";
            this.NumberOfTimes.Size = new System.Drawing.Size(56, 13);
            this.NumberOfTimes.TabIndex = 2;
            this.NumberOfTimes.Text = "# of times:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 62);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Speak
            // 
            this.Speak.Location = new System.Drawing.Point(136, 101);
            this.Speak.Name = "Speak";
            this.Speak.Size = new System.Drawing.Size(110, 23);
            this.Speak.TabIndex = 4;
            this.Speak.Text = "Speak to me!";
            this.Speak.UseVisualStyleBackColor = true;
            this.Speak.Click += new System.EventHandler(this.Speak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 146);
            this.Controls.Add(this.Speak);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.NumberOfTimes);
            this.Controls.Add(this.SayThis);
            this.Controls.Add(this.ThingToSay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ThingToSay;
        private System.Windows.Forms.Label SayThis;
        private System.Windows.Forms.Label NumberOfTimes;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Speak;
    }
}

