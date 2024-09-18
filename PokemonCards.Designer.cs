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
            pokeName = new TextBox();
            pokeType = new TextBox();
            pokeDescription = new TextBox();
            pokeId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pokemonCards).BeginInit();
            SuspendLayout();
            // 
            // pokemonCards
            // 
            pokemonCards.Location = new Point(250, 216);
            pokemonCards.Name = "pokemonCards";
            pokemonCards.Size = new Size(319, 296);
            pokemonCards.SizeMode = PictureBoxSizeMode.AutoSize;
            pokemonCards.TabIndex = 0;
            pokemonCards.TabStop = false;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(947, 12);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(75, 23);
            nextBtn.TabIndex = 1;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // previousBtn
            // 
            previousBtn.Location = new Point(12, 12);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(75, 23);
            previousBtn.TabIndex = 2;
            previousBtn.Text = "Previous";
            previousBtn.UseVisualStyleBackColor = true;
            previousBtn.Click += previousBtn_Click;
            // 
            // pokeName
            // 
            pokeName.BackColor = Color.DimGray;
            pokeName.BorderStyle = BorderStyle.None;
            pokeName.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pokeName.Location = new Point(367, 52);
            pokeName.Name = "pokeName";
            pokeName.Size = new Size(282, 33);
            pokeName.TabIndex = 3;
            pokeName.TextAlign = HorizontalAlignment.Center;
            // 
            // pokeType
            // 
            pokeType.BackColor = Color.DimGray;
            pokeType.BorderStyle = BorderStyle.None;
            pokeType.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pokeType.ForeColor = SystemColors.InfoText;
            pokeType.Location = new Point(376, 91);
            pokeType.Name = "pokeType";
            pokeType.Size = new Size(282, 33);
            pokeType.TabIndex = 4;
            pokeType.TextAlign = HorizontalAlignment.Center;
            // 
            // pokeDescription
            // 
            pokeDescription.BackColor = SystemColors.GrayText;
            pokeDescription.BorderStyle = BorderStyle.None;
            pokeDescription.Font = new Font("Verdana", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            pokeDescription.Location = new Point(367, 157);
            pokeDescription.Name = "pokeDescription";
            pokeDescription.Size = new Size(100, 30);
            pokeDescription.TabIndex = 5;
            // 
            // pokeId
            // 
            pokeId.Location = new Point(31, 123);
            pokeId.Name = "pokeId";
            pokeId.Size = new Size(56, 23);
            pokeId.TabIndex = 6;
            // 
            // PokeImages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1034, 626);
            Controls.Add(pokeId);
            Controls.Add(pokeDescription);
            Controls.Add(pokeType);
            Controls.Add(pokeName);
            Controls.Add(previousBtn);
            Controls.Add(nextBtn);
            Controls.Add(pokemonCards);
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
        private TextBox pokeName;
        private TextBox pokeType;
        private TextBox pokeDescription;
        private TextBox pokeId;
    }
}
