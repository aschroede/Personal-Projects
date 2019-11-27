namespace ADayAtTheRaces
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
            this.components = new System.ComponentModel.Container();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.Racetrack = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.BettingParlorMenu = new System.Windows.Forms.GroupBox();
            this.NumericUpDownDogNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BetsButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BetsLabel = new System.Windows.Forms.Label();
            this.BettingParlor = new System.Windows.Forms.Label();
            this.MinimumBetLabel = new System.Windows.Forms.Label();
            this.AlLabel = new System.Windows.Forms.Label();
            this.BobLabel = new System.Windows.Forms.Label();
            this.JoeLabel = new System.Windows.Forms.Label();
            this.AlRadioButton = new System.Windows.Forms.RadioButton();
            this.BobRadioButton = new System.Windows.Forms.RadioButton();
            this.JoeRadioButton = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.BettingParlorMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dog1
            // 
            this.dog1.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog1.Location = new System.Drawing.Point(12, 12);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(75, 20);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // Racetrack
            // 
            this.Racetrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Racetrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.Racetrack.Image = global::ADayAtTheRaces.Properties.Resources.racetrack;
            this.Racetrack.Location = new System.Drawing.Point(0, 0);
            this.Racetrack.Name = "Racetrack";
            this.Racetrack.Size = new System.Drawing.Size(600, 204);
            this.Racetrack.TabIndex = 0;
            this.Racetrack.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog2.Location = new System.Drawing.Point(12, 63);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(75, 20);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog2.TabIndex = 2;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog3.Location = new System.Drawing.Point(12, 114);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(75, 20);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog3.TabIndex = 3;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog4.Location = new System.Drawing.Point(12, 165);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(75, 20);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog4.TabIndex = 4;
            this.dog4.TabStop = false;
            // 
            // BettingParlorMenu
            // 
            this.BettingParlorMenu.Controls.Add(this.NumericUpDownDogNumber);
            this.BettingParlorMenu.Controls.Add(this.label1);
            this.BettingParlorMenu.Controls.Add(this.numericUpDown1);
            this.BettingParlorMenu.Controls.Add(this.BetsButton);
            this.BettingParlorMenu.Controls.Add(this.NameLabel);
            this.BettingParlorMenu.Controls.Add(this.BetsLabel);
            this.BettingParlorMenu.Controls.Add(this.BettingParlor);
            this.BettingParlorMenu.Controls.Add(this.MinimumBetLabel);
            this.BettingParlorMenu.Controls.Add(this.AlLabel);
            this.BettingParlorMenu.Controls.Add(this.BobLabel);
            this.BettingParlorMenu.Controls.Add(this.JoeLabel);
            this.BettingParlorMenu.Controls.Add(this.AlRadioButton);
            this.BettingParlorMenu.Controls.Add(this.BobRadioButton);
            this.BettingParlorMenu.Controls.Add(this.JoeRadioButton);
            this.BettingParlorMenu.Controls.Add(this.start);
            this.BettingParlorMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BettingParlorMenu.Location = new System.Drawing.Point(0, 210);
            this.BettingParlorMenu.Name = "BettingParlorMenu";
            this.BettingParlorMenu.Size = new System.Drawing.Size(600, 176);
            this.BettingParlorMenu.TabIndex = 5;
            this.BettingParlorMenu.TabStop = false;
            // 
            // NumericUpDownDogNumber
            // 
            this.NumericUpDownDogNumber.Location = new System.Drawing.Point(310, 133);
            this.NumericUpDownDogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumericUpDownDogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownDogNumber.Name = "NumericUpDownDogNumber";
            this.NumericUpDownDogNumber.Size = new System.Drawing.Size(49, 20);
            this.NumericUpDownDogNumber.TabIndex = 14;
            this.NumericUpDownDogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "bucks on dog number";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(133, 133);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BetsButton
            // 
            this.BetsButton.Location = new System.Drawing.Point(70, 131);
            this.BetsButton.Name = "BetsButton";
            this.BetsButton.Size = new System.Drawing.Size(57, 23);
            this.BetsButton.TabIndex = 11;
            this.BetsButton.Text = "Bets";
            this.BetsButton.UseVisualStyleBackColor = true;
            this.BetsButton.Click += new System.EventHandler(this.BetsButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(29, 136);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "label1";
            // 
            // BetsLabel
            // 
            this.BetsLabel.AutoSize = true;
            this.BetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetsLabel.Location = new System.Drawing.Point(300, 31);
            this.BetsLabel.Name = "BetsLabel";
            this.BetsLabel.Size = new System.Drawing.Size(39, 16);
            this.BetsLabel.TabIndex = 9;
            this.BetsLabel.Text = "Bets";
            // 
            // BettingParlor
            // 
            this.BettingParlor.AutoSize = true;
            this.BettingParlor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BettingParlor.Location = new System.Drawing.Point(30, 4);
            this.BettingParlor.Name = "BettingParlor";
            this.BettingParlor.Size = new System.Drawing.Size(97, 18);
            this.BettingParlor.TabIndex = 8;
            this.BettingParlor.Text = "Betting Parlor";
            // 
            // MinimumBetLabel
            // 
            this.MinimumBetLabel.AutoSize = true;
            this.MinimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumBetLabel.Location = new System.Drawing.Point(27, 31);
            this.MinimumBetLabel.Name = "MinimumBetLabel";
            this.MinimumBetLabel.Size = new System.Drawing.Size(107, 16);
            this.MinimumBetLabel.TabIndex = 7;
            this.MinimumBetLabel.Text = "Minimum Bet:  ";
            // 
            // AlLabel
            // 
            this.AlLabel.AutoSize = true;
            this.AlLabel.Location = new System.Drawing.Point(300, 103);
            this.AlLabel.Name = "AlLabel";
            this.AlLabel.Size = new System.Drawing.Size(109, 13);
            this.AlLabel.TabIndex = 6;
            this.AlLabel.Text = "Al hasn\'t placed a bet";
            // 
            // BobLabel
            // 
            this.BobLabel.AutoSize = true;
            this.BobLabel.Location = new System.Drawing.Point(300, 79);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(119, 13);
            this.BobLabel.TabIndex = 5;
            this.BobLabel.Text = "Bob hasn\'t placed a bet";
            // 
            // JoeLabel
            // 
            this.JoeLabel.AutoSize = true;
            this.JoeLabel.Location = new System.Drawing.Point(300, 55);
            this.JoeLabel.Name = "JoeLabel";
            this.JoeLabel.Size = new System.Drawing.Size(117, 13);
            this.JoeLabel.TabIndex = 4;
            this.JoeLabel.Text = "Joe hasn\'t placed a bet";
            // 
            // AlRadioButton
            // 
            this.AlRadioButton.AutoSize = true;
            this.AlRadioButton.Location = new System.Drawing.Point(29, 103);
            this.AlRadioButton.Name = "AlRadioButton";
            this.AlRadioButton.Size = new System.Drawing.Size(85, 17);
            this.AlRadioButton.TabIndex = 3;
            this.AlRadioButton.TabStop = true;
            this.AlRadioButton.Text = "radioButton3";
            this.AlRadioButton.UseVisualStyleBackColor = true;
            this.AlRadioButton.CheckedChanged += new System.EventHandler(this.AlRadioButton_CheckedChanged);
            // 
            // BobRadioButton
            // 
            this.BobRadioButton.AutoSize = true;
            this.BobRadioButton.Location = new System.Drawing.Point(29, 79);
            this.BobRadioButton.Name = "BobRadioButton";
            this.BobRadioButton.Size = new System.Drawing.Size(85, 17);
            this.BobRadioButton.TabIndex = 2;
            this.BobRadioButton.TabStop = true;
            this.BobRadioButton.Text = "radioButton2";
            this.BobRadioButton.UseVisualStyleBackColor = true;
            this.BobRadioButton.CheckedChanged += new System.EventHandler(this.BobRadioButton_CheckedChanged);
            // 
            // JoeRadioButton
            // 
            this.JoeRadioButton.AutoSize = true;
            this.JoeRadioButton.Location = new System.Drawing.Point(29, 55);
            this.JoeRadioButton.Name = "JoeRadioButton";
            this.JoeRadioButton.Size = new System.Drawing.Size(85, 17);
            this.JoeRadioButton.TabIndex = 1;
            this.JoeRadioButton.TabStop = true;
            this.JoeRadioButton.Text = "radioButton1";
            this.JoeRadioButton.UseVisualStyleBackColor = true;
            this.JoeRadioButton.CheckedChanged += new System.EventHandler(this.JoeRadioButton_CheckedChanged);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(447, 38);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(128, 94);
            this.start.TabIndex = 0;
            this.start.Text = "Race!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 8;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 386);
            this.Controls.Add(this.BettingParlorMenu);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.Racetrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.BettingParlorMenu.ResumeLayout(false);
            this.BettingParlorMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Racetrack;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.GroupBox BettingParlorMenu;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label BetsLabel;
        private System.Windows.Forms.Label BettingParlor;
        private System.Windows.Forms.Label MinimumBetLabel;
        private System.Windows.Forms.Label AlLabel;
        private System.Windows.Forms.Label BobLabel;
        private System.Windows.Forms.Label JoeLabel;
        private System.Windows.Forms.RadioButton AlRadioButton;
        private System.Windows.Forms.RadioButton BobRadioButton;
        private System.Windows.Forms.RadioButton JoeRadioButton;
        private System.Windows.Forms.NumericUpDown NumericUpDownDogNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button BetsButton;
        private System.Windows.Forms.Label NameLabel;
    }
}

