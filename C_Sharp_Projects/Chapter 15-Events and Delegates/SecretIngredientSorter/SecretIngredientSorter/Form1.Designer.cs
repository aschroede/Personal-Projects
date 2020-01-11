namespace SecretIngredientSorter
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
            this.getTheIngredient = new System.Windows.Forms.Button();
            this.getSuzannesDelegate = new System.Windows.Forms.Button();
            this.getAmysDelegate = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // getTheIngredient
            // 
            this.getTheIngredient.Location = new System.Drawing.Point(28, 25);
            this.getTheIngredient.Name = "getTheIngredient";
            this.getTheIngredient.Size = new System.Drawing.Size(145, 23);
            this.getTheIngredient.TabIndex = 0;
            this.getTheIngredient.Text = "Get the ingredient";
            this.getTheIngredient.UseVisualStyleBackColor = true;
            this.getTheIngredient.Click += new System.EventHandler(this.getTheIngredient_Click);
            // 
            // getSuzannesDelegate
            // 
            this.getSuzannesDelegate.Location = new System.Drawing.Point(28, 67);
            this.getSuzannesDelegate.Name = "getSuzannesDelegate";
            this.getSuzannesDelegate.Size = new System.Drawing.Size(236, 23);
            this.getSuzannesDelegate.TabIndex = 1;
            this.getSuzannesDelegate.Text = "Get Suzanne\'s delegate";
            this.getSuzannesDelegate.UseVisualStyleBackColor = true;
            this.getSuzannesDelegate.Click += new System.EventHandler(this.getSuzannesDelegate_Click);
            // 
            // getAmysDelegate
            // 
            this.getAmysDelegate.Location = new System.Drawing.Point(28, 106);
            this.getAmysDelegate.Name = "getAmysDelegate";
            this.getAmysDelegate.Size = new System.Drawing.Size(236, 23);
            this.getAmysDelegate.TabIndex = 2;
            this.getAmysDelegate.Text = "Get Amy\'s delegate";
            this.getAmysDelegate.UseVisualStyleBackColor = true;
            this.getAmysDelegate.Click += new System.EventHandler(this.getAmysDelegate_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(179, 28);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(86, 20);
            this.amount.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 187);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.getAmysDelegate);
            this.Controls.Add(this.getSuzannesDelegate);
            this.Controls.Add(this.getTheIngredient);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getTheIngredient;
        private System.Windows.Forms.Button getSuzannesDelegate;
        private System.Windows.Forms.Button getAmysDelegate;
        private System.Windows.Forms.NumericUpDown amount;
    }
}

