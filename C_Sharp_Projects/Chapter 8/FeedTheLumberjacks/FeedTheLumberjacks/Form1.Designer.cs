namespace FeedTheLumberjacks
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.AddLumberjack = new System.Windows.Forms.Button();
            this.FeedALumberjack = new System.Windows.Forms.GroupBox();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.AddFlapjacks = new System.Windows.Forms.Button();
            this.lumberJackSummary = new System.Windows.Forms.TextBox();
            this.NextLumberjack = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FeedALumberjack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(111, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(201, 20);
            this.name.TabIndex = 1;
            // 
            // AddLumberjack
            // 
            this.AddLumberjack.Location = new System.Drawing.Point(16, 45);
            this.AddLumberjack.Name = "AddLumberjack";
            this.AddLumberjack.Size = new System.Drawing.Size(296, 23);
            this.AddLumberjack.TabIndex = 2;
            this.AddLumberjack.Text = "Add Lumberjack";
            this.AddLumberjack.UseVisualStyleBackColor = true;
            this.AddLumberjack.Click += new System.EventHandler(this.AddLumberjack_Click);
            // 
            // FeedALumberjack
            // 
            this.FeedALumberjack.Controls.Add(this.NextLumberjack);
            this.FeedALumberjack.Controls.Add(this.lumberJackSummary);
            this.FeedALumberjack.Controls.Add(this.AddFlapjacks);
            this.FeedALumberjack.Controls.Add(this.banana);
            this.FeedALumberjack.Controls.Add(this.browned);
            this.FeedALumberjack.Controls.Add(this.soggy);
            this.FeedALumberjack.Controls.Add(this.crispy);
            this.FeedALumberjack.Controls.Add(this.howMany);
            this.FeedALumberjack.Location = new System.Drawing.Point(144, 74);
            this.FeedALumberjack.Name = "FeedALumberjack";
            this.FeedALumberjack.Size = new System.Drawing.Size(168, 308);
            this.FeedALumberjack.TabIndex = 3;
            this.FeedALumberjack.TabStop = false;
            this.FeedALumberjack.Text = "Feed a Lumberjack";
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(7, 20);
            this.howMany.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(89, 20);
            this.howMany.TabIndex = 0;
            this.howMany.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(7, 47);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(53, 17);
            this.crispy.TabIndex = 1;
            this.crispy.TabStop = true;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(7, 70);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(55, 17);
            this.soggy.TabIndex = 2;
            this.soggy.TabStop = true;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(7, 93);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(67, 17);
            this.browned.TabIndex = 3;
            this.browned.TabStop = true;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(7, 116);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(62, 17);
            this.banana.TabIndex = 4;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // AddFlapjacks
            // 
            this.AddFlapjacks.Location = new System.Drawing.Point(7, 140);
            this.AddFlapjacks.Name = "AddFlapjacks";
            this.AddFlapjacks.Size = new System.Drawing.Size(147, 23);
            this.AddFlapjacks.TabIndex = 5;
            this.AddFlapjacks.Text = "Add flapjacks";
            this.AddFlapjacks.UseVisualStyleBackColor = true;
            this.AddFlapjacks.Click += new System.EventHandler(this.AddFlapjacks_Click);
            // 
            // lumberJackSummary
            // 
            this.lumberJackSummary.Location = new System.Drawing.Point(7, 169);
            this.lumberJackSummary.Multiline = true;
            this.lumberJackSummary.Name = "lumberJackSummary";
            this.lumberJackSummary.ReadOnly = true;
            this.lumberJackSummary.Size = new System.Drawing.Size(147, 99);
            this.lumberJackSummary.TabIndex = 6;
            // 
            // NextLumberjack
            // 
            this.NextLumberjack.Location = new System.Drawing.Point(7, 274);
            this.NextLumberjack.Name = "NextLumberjack";
            this.NextLumberjack.Size = new System.Drawing.Size(147, 23);
            this.NextLumberjack.TabIndex = 7;
            this.NextLumberjack.Text = "Next Lumberjack";
            this.NextLumberjack.UseVisualStyleBackColor = true;
            this.NextLumberjack.Click += new System.EventHandler(this.NextLumberjack_Click);
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(16, 105);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(120, 277);
            this.line.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Breakfast line";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.line);
            this.Controls.Add(this.FeedALumberjack);
            this.Controls.Add(this.AddLumberjack);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Breakfast for Lumberjacks";
            this.FeedALumberjack.ResumeLayout(false);
            this.FeedALumberjack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button AddLumberjack;
        private System.Windows.Forms.GroupBox FeedALumberjack;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.Button NextLumberjack;
        private System.Windows.Forms.TextBox lumberJackSummary;
        private System.Windows.Forms.Button AddFlapjacks;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.Label label2;
    }
}

