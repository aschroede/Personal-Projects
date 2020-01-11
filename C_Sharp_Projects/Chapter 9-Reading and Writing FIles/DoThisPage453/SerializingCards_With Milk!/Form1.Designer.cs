namespace SerializingCards_With_Milk_
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
            this.saveDeck = new System.Windows.Forms.Button();
            this.loadDeck = new System.Windows.Forms.Button();
            this.saveDecks = new System.Windows.Forms.Button();
            this.loadDecks = new System.Windows.Forms.Button();
            this.serializeThreeOfClubs = new System.Windows.Forms.Button();
            this.serializeSixOfHearts = new System.Windows.Forms.Button();
            this.compare = new System.Windows.Forms.Button();
            this.hexDump = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveDeck
            // 
            this.saveDeck.Location = new System.Drawing.Point(133, 200);
            this.saveDeck.Name = "saveDeck";
            this.saveDeck.Size = new System.Drawing.Size(75, 23);
            this.saveDeck.TabIndex = 0;
            this.saveDeck.Text = "Save Deck";
            this.saveDeck.UseVisualStyleBackColor = true;
            this.saveDeck.Click += new System.EventHandler(this.saveDeck_Click);
            // 
            // loadDeck
            // 
            this.loadDeck.Location = new System.Drawing.Point(240, 200);
            this.loadDeck.Name = "loadDeck";
            this.loadDeck.Size = new System.Drawing.Size(75, 23);
            this.loadDeck.TabIndex = 1;
            this.loadDeck.Text = "Load Deck";
            this.loadDeck.UseVisualStyleBackColor = true;
            this.loadDeck.Click += new System.EventHandler(this.loadDeck_Click);
            // 
            // saveDecks
            // 
            this.saveDecks.Location = new System.Drawing.Point(133, 159);
            this.saveDecks.Name = "saveDecks";
            this.saveDecks.Size = new System.Drawing.Size(75, 23);
            this.saveDecks.TabIndex = 2;
            this.saveDecks.Text = "Save Decks";
            this.saveDecks.UseVisualStyleBackColor = true;
            this.saveDecks.Click += new System.EventHandler(this.saveDecks_Click);
            // 
            // loadDecks
            // 
            this.loadDecks.Location = new System.Drawing.Point(240, 159);
            this.loadDecks.Name = "loadDecks";
            this.loadDecks.Size = new System.Drawing.Size(75, 23);
            this.loadDecks.TabIndex = 3;
            this.loadDecks.Text = "Load Decks";
            this.loadDecks.UseVisualStyleBackColor = true;
            this.loadDecks.Click += new System.EventHandler(this.loadDecks_Click);
            // 
            // serializeThreeOfClubs
            // 
            this.serializeThreeOfClubs.Location = new System.Drawing.Point(39, 117);
            this.serializeThreeOfClubs.Name = "serializeThreeOfClubs";
            this.serializeThreeOfClubs.Size = new System.Drawing.Size(169, 23);
            this.serializeThreeOfClubs.TabIndex = 4;
            this.serializeThreeOfClubs.Text = "Serialize Three of Clubs";
            this.serializeThreeOfClubs.UseVisualStyleBackColor = true;
            this.serializeThreeOfClubs.Click += new System.EventHandler(this.serializeThreeOfClubs_Click);
            // 
            // serializeSixOfHearts
            // 
            this.serializeSixOfHearts.Location = new System.Drawing.Point(240, 117);
            this.serializeSixOfHearts.Name = "serializeSixOfHearts";
            this.serializeSixOfHearts.Size = new System.Drawing.Size(205, 23);
            this.serializeSixOfHearts.TabIndex = 5;
            this.serializeSixOfHearts.Text = "Serialize Six of Hearts";
            this.serializeSixOfHearts.UseVisualStyleBackColor = true;
            this.serializeSixOfHearts.Click += new System.EventHandler(this.serializeSixOfHearts_Click);
            // 
            // compare
            // 
            this.compare.Location = new System.Drawing.Point(39, 84);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(406, 23);
            this.compare.TabIndex = 6;
            this.compare.Text = "Compare";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.compare_Click);
            // 
            // hexDump
            // 
            this.hexDump.Location = new System.Drawing.Point(39, 50);
            this.hexDump.Name = "hexDump";
            this.hexDump.Size = new System.Drawing.Size(406, 23);
            this.hexDump.TabIndex = 7;
            this.hexDump.Text = "Hex Dump";
            this.hexDump.UseVisualStyleBackColor = true;
            this.hexDump.Click += new System.EventHandler(this.hexDump_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 297);
            this.Controls.Add(this.hexDump);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.serializeSixOfHearts);
            this.Controls.Add(this.serializeThreeOfClubs);
            this.Controls.Add(this.loadDecks);
            this.Controls.Add(this.saveDecks);
            this.Controls.Add(this.loadDeck);
            this.Controls.Add(this.saveDeck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveDeck;
        private System.Windows.Forms.Button loadDeck;
        private System.Windows.Forms.Button saveDecks;
        private System.Windows.Forms.Button loadDecks;
        private System.Windows.Forms.Button serializeThreeOfClubs;
        private System.Windows.Forms.Button serializeSixOfHearts;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.Button hexDump;
    }
}

