namespace Party_Planner_3._0
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DinnerPartyTab = new System.Windows.Forms.TabPage();
            this.BirthdayPartyTab = new System.Windows.Forms.TabPage();
            this.costLabel1 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DinnerPartyTab.SuspendLayout();
            this.BirthdayPartyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DinnerPartyTab);
            this.tabControl1.Controls.Add(this.BirthdayPartyTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(196, 220);
            this.tabControl1.TabIndex = 0;
            // 
            // DinnerPartyTab
            // 
            this.DinnerPartyTab.Controls.Add(this.costLabel1);
            this.DinnerPartyTab.Controls.Add(this.costLabel);
            this.DinnerPartyTab.Controls.Add(this.healthyBox);
            this.DinnerPartyTab.Controls.Add(this.fancyBox);
            this.DinnerPartyTab.Controls.Add(this.numericUpDown1);
            this.DinnerPartyTab.Controls.Add(this.label1);
            this.DinnerPartyTab.Location = new System.Drawing.Point(4, 22);
            this.DinnerPartyTab.Name = "DinnerPartyTab";
            this.DinnerPartyTab.Padding = new System.Windows.Forms.Padding(3);
            this.DinnerPartyTab.Size = new System.Drawing.Size(188, 194);
            this.DinnerPartyTab.TabIndex = 0;
            this.DinnerPartyTab.Text = "Dinner Party";
            this.DinnerPartyTab.UseVisualStyleBackColor = true;
            // 
            // BirthdayPartyTab
            // 
            this.BirthdayPartyTab.Controls.Add(this.tooLongLabel);
            this.BirthdayPartyTab.Controls.Add(this.label2);
            this.BirthdayPartyTab.Controls.Add(this.cakeWriting);
            this.BirthdayPartyTab.Controls.Add(this.birthdayCost);
            this.BirthdayPartyTab.Controls.Add(this.label3);
            this.BirthdayPartyTab.Controls.Add(this.fancyBirthday);
            this.BirthdayPartyTab.Controls.Add(this.numberBirthday);
            this.BirthdayPartyTab.Controls.Add(this.label);
            this.BirthdayPartyTab.Location = new System.Drawing.Point(4, 22);
            this.BirthdayPartyTab.Name = "BirthdayPartyTab";
            this.BirthdayPartyTab.Padding = new System.Windows.Forms.Padding(3);
            this.BirthdayPartyTab.Size = new System.Drawing.Size(188, 194);
            this.BirthdayPartyTab.TabIndex = 1;
            this.BirthdayPartyTab.Text = "BirthdayParty";
            this.BirthdayPartyTab.UseVisualStyleBackColor = true;
            // 
            // costLabel1
            // 
            this.costLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel1.Location = new System.Drawing.Point(60, 125);
            this.costLabel1.Name = "costLabel1";
            this.costLabel1.Size = new System.Drawing.Size(95, 27);
            this.costLabel1.TabIndex = 11;
            this.costLabel1.Text = "$";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(20, 126);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(32, 13);
            this.costLabel.TabIndex = 10;
            this.costLabel.Text = "Cost";
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(20, 97);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(96, 17);
            this.healthyBox.TabIndex = 9;
            this.healthyBox.Text = "Healthy Option";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.HealthyBox_CheckedChanged);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(20, 68);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(115, 17);
            this.fancyBox.TabIndex = 8;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.FancyBox_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(20, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of People:";
            // 
            // birthdayCost
            // 
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayCost.Location = new System.Drawing.Point(57, 146);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(95, 24);
            this.birthdayCost.TabIndex = 17;
            this.birthdayCost.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cost";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Checked = true;
            this.fancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBirthday.Location = new System.Drawing.Point(15, 67);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.fancyBirthday.TabIndex = 14;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.FancyBirthday_CheckedChanged);
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(15, 37);
            this.numberBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 20);
            this.numberBirthday.TabIndex = 13;
            this.numberBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBirthday.ValueChanged += new System.EventHandler(this.NumberBirthday_ValueChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 13);
            this.label.TabIndex = 12;
            this.label.Text = "Number of People:";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(15, 117);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(137, 20);
            this.cakeWriting.TabIndex = 18;
            this.cakeWriting.Text = "Happy Birthday!";
            this.cakeWriting.TextChanged += new System.EventHandler(this.CakeWriting_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cake Writing";
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(89, 95);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(63, 13);
            this.tooLongLabel.TabIndex = 20;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 220);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.DinnerPartyTab.ResumeLayout(false);
            this.DinnerPartyTab.PerformLayout();
            this.BirthdayPartyTab.ResumeLayout(false);
            this.BirthdayPartyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DinnerPartyTab;
        private System.Windows.Forms.TabPage BirthdayPartyTab;
        private System.Windows.Forms.Label costLabel1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tooLongLabel;
    }
}

