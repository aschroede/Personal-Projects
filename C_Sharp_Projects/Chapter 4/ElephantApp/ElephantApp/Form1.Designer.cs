namespace ElephantApp
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
            this.Lloyd = new System.Windows.Forms.Button();
            this.Lucinda = new System.Windows.Forms.Button();
            this.Swap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lloyd
            // 
            this.Lloyd.Location = new System.Drawing.Point(62, 23);
            this.Lloyd.Name = "Lloyd";
            this.Lloyd.Size = new System.Drawing.Size(75, 23);
            this.Lloyd.TabIndex = 0;
            this.Lloyd.Text = "Lloyd";
            this.Lloyd.UseVisualStyleBackColor = true;
            this.Lloyd.Click += new System.EventHandler(this.Lloyd_Click);
            // 
            // Lucinda
            // 
            this.Lucinda.Location = new System.Drawing.Point(62, 55);
            this.Lucinda.Name = "Lucinda";
            this.Lucinda.Size = new System.Drawing.Size(75, 23);
            this.Lucinda.TabIndex = 1;
            this.Lucinda.Text = "Lucinda";
            this.Lucinda.UseVisualStyleBackColor = true;
            this.Lucinda.Click += new System.EventHandler(this.Lucinda_Click);
            // 
            // Swap
            // 
            this.Swap.Location = new System.Drawing.Point(62, 87);
            this.Swap.Name = "Swap";
            this.Swap.Size = new System.Drawing.Size(75, 23);
            this.Swap.TabIndex = 2;
            this.Swap.Text = "Swap!";
            this.Swap.UseVisualStyleBackColor = true;
            this.Swap.Click += new System.EventHandler(this.Swap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Swap);
            this.Controls.Add(this.Lucinda);
            this.Controls.Add(this.Lloyd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lloyd;
        private System.Windows.Forms.Button Lucinda;
        private System.Windows.Forms.Button Swap;
        private System.Windows.Forms.Button button1;
    }
}

