namespace UnicodeExcercise
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
            this.eureka = new System.Windows.Forms.Button();
            this.hexEureka = new System.Windows.Forms.Button();
            this.hebrew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eureka
            // 
            this.eureka.Location = new System.Drawing.Point(357, 227);
            this.eureka.Name = "eureka";
            this.eureka.Size = new System.Drawing.Size(75, 23);
            this.eureka.TabIndex = 0;
            this.eureka.Text = "Eureka!";
            this.eureka.UseVisualStyleBackColor = true;
            this.eureka.Click += new System.EventHandler(this.eureka_Click);
            // 
            // hexEureka
            // 
            this.hexEureka.Location = new System.Drawing.Point(438, 227);
            this.hexEureka.Name = "hexEureka";
            this.hexEureka.Size = new System.Drawing.Size(106, 23);
            this.hexEureka.TabIndex = 1;
            this.hexEureka.Text = "Eureka! (Hex)";
            this.hexEureka.UseVisualStyleBackColor = true;
            this.hexEureka.Click += new System.EventHandler(this.hexEureka_Click);
            // 
            // hebrew
            // 
            this.hebrew.Location = new System.Drawing.Point(357, 267);
            this.hebrew.Name = "hebrew";
            this.hebrew.Size = new System.Drawing.Size(106, 23);
            this.hebrew.TabIndex = 2;
            this.hebrew.Text = "Hebrew";
            this.hebrew.UseVisualStyleBackColor = true;
            this.hebrew.Click += new System.EventHandler(this.hebrew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hebrew);
            this.Controls.Add(this.hexEureka);
            this.Controls.Add(this.eureka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eureka;
        private System.Windows.Forms.Button hexEureka;
        private System.Windows.Forms.Button hebrew;
    }
}

