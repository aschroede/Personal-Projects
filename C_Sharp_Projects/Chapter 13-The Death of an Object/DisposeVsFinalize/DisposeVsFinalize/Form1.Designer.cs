namespace DisposeVsFinalize
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
            this.clone1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clone1
            // 
            this.clone1.Location = new System.Drawing.Point(57, 35);
            this.clone1.Name = "clone1";
            this.clone1.Size = new System.Drawing.Size(75, 23);
            this.clone1.TabIndex = 0;
            this.clone1.Text = "Clone#1";
            this.clone1.UseVisualStyleBackColor = true;
            this.clone1.Click += new System.EventHandler(this.clone1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clone#2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gc
            // 
            this.gc.Location = new System.Drawing.Point(57, 93);
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(75, 23);
            this.gc.TabIndex = 2;
            this.gc.Text = "GC";
            this.gc.UseVisualStyleBackColor = true;
            this.gc.Click += new System.EventHandler(this.gc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 163);
            this.Controls.Add(this.gc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clone1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clone1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button gc;
    }
}

