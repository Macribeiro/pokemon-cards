using PokeApiNet;
using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PokemonCards
{
    public partial class PokeImages : Form
    {
        public int pokeIndex = 1;
        PokeApiClient pokeClient = new PokeApiClient();
        public PokeImages()
        {
            InitializeComponent();
            pokemonCards.Location = new Point((ClientSize.Width - pokemonCards.Width) / 2, (ClientSize.Height - pokemonCards.Height) / 2);
            GetPokemon();
        }

        public async void GetPokemon()
        {
            Pokemon pokemon = await pokeClient.GetResourceAsync<Pokemon>(pokeIndex);
            PokemonSpecies species = await pokeClient.GetResourceAsync(pokemon.Species);
            Characteristic characteristic = await pokeClient.GetResourceAsync<Characteristic>(pokeIndex);
            using (WebClient webClient = new WebClient())
            {
                byte[] imageData = webClient.DownloadData(pokemon.Sprites.Other.Home.FrontDefault);

                using (MemoryStream stream = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(stream);
                    pokemonCards.Image = image;
                }
            }

            pokeName.Text = pokemon.Name.ToUpper();
            pokeType.Text = "Type: " + pokemon.Types[0].Type.Name.ToString();
            pokeId.Text = "ID: # " + pokemon.Id.ToString();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            pokeIndex--;
            if (pokeIndex < 0) pokeIndex = 1;
            GetPokemon();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            pokeIndex++;
            if (pokeIndex > 1025) pokeIndex = 1;
            GetPokemon();
        }
    }
}
