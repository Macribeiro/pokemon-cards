namespace PokemonCards
{
    partial class PokeImages
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pokemonCards = new PictureBox();
            nextBtn = new Button();
            previousBtn = new Button();
            pokeName = new Label();
            pokeType = new Label();
            pokeId = new Label();
            background = new Label();
            ((System.ComponentModel.ISupportInitialize)pokemonCards).BeginInit();
            SuspendLayout();
            // 
            // pokemonCards
            // 
            pokemonCards.BackColor = Color.Sienna;
            pokemonCards.Location = new Point(119, 113);
            pokemonCards.Name = "pokemonCards";
            pokemonCards.Size = new Size(271, 305);
            pokemonCards.SizeMode = PictureBoxSizeMode.StretchImage;
            pokemonCards.TabIndex = 0;
            pokemonCards.TabStop = false;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(990, 280);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(75, 61);
            nextBtn.TabIndex = 1;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // previousBtn
            // 
            previousBtn.Location = new Point(12, 280);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(75, 61);
            previousBtn.TabIndex = 2;
            previousBtn.Text = "Previous";
            previousBtn.UseVisualStyleBackColor = true;
            previousBtn.Click += previousBtn_Click;
            // 
            // pokeName
            // 
            pokeName.AutoSize = true;
            pokeName.BackColor = Color.Sienna;
            pokeName.FlatStyle = FlatStyle.Popup;
            pokeName.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pokeName.ForeColor = Color.White;
            pokeName.Location = new Point(396, 113);
            pokeName.Name = "pokeName";
            pokeName.Size = new Size(118, 47);
            pokeName.TabIndex = 7;
            pokeName.Text = "Name";
            pokeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pokeType
            // 
            pokeType.AutoSize = true;
            pokeType.BackColor = Color.Sienna;
            pokeType.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            pokeType.Location = new Point(279, 491);
            pokeType.Name = "pokeType";
            pokeType.Size = new Size(57, 25);
            pokeType.TabIndex = 8;
            pokeType.Text = "Type";
            // 
            // pokeId
            // 
            pokeId.AutoSize = true;
            pokeId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pokeId.Location = new Point(873, 68);
            pokeId.Name = "pokeId";
            pokeId.Size = new Size(27, 21);
            pokeId.TabIndex = 11;
            pokeId.Text = "ID";
            // 
            // background
            // 
            background.BackColor = Color.Sienna;
            background.Location = new Point(279, 22);
            background.Name = "background";
            background.Size = new Size(474, 510);
            background.TabIndex = 13;
            // 
            // PokeImages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(1077, 649);
            Controls.Add(pokeName);
            Controls.Add(pokeId);
            Controls.Add(pokeType);
            Controls.Add(previousBtn);
            Controls.Add(nextBtn);
            Controls.Add(pokemonCards);
            Controls.Add(background);
            ForeColor = SystemColors.ControlText;
            Name = "PokeImages";
            Text = "Pokémon Cards";
            ((System.ComponentModel.ISupportInitialize)pokemonCards).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pokemonCards;
        private Button nextBtn;
        private Button previousBtn;
        private Label pokeName;
        private Label pokeType;
        private Label pokeId;
        private Label background;
    }
}
