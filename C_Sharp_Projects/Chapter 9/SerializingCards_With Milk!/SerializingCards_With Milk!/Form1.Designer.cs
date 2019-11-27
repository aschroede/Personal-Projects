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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 297);
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
    }
}

