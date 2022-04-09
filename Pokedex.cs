using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }

        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            // Instanciar a lista
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Bulbasauro", "Sua descrição", 100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Sandshrew", "Sua descrição", 90);
            this.pokemons.Add(p);
            // inserir 10 pokemons na lista
            p = new PokemonPlus("Squirtle", "Sua descrição", 70);
            this.pokemons.Add(p);
            p = new PokemonPlus("Caterpie", "Sua descrição", 160);
            this.pokemons.Add(p);
            p = new PokemonPlus("Weedle", "Sua descrição", 69);
            this.pokemons.Add(p);
            p = new PokemonPlus("Pidgey", "Sua descrição", 50);
            this.pokemons.Add(p);
            p = new PokemonPlus("Rattata", "Sua descrição", 120);
            this.pokemons.Add(p);
            p = new PokemonPlus("Spearow", "Sua descrição", 140);
            this.pokemons.Add(p);
            p = new PokemonPlus("Ekans", "Sua descrição", 110);
            this.pokemons.Add(p);
            p = new PokemonPlus("Pikachu", "Sua descrição", 120);
            this.pokemons.Add(p);
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("Código do Pokémon: " + i);
                this.pokemons[i].ExibirDadosPokemon();
                //Pokemon p = this.Pokemons[i];
                //p.ExibirDadosPokemon();
            }
        }

    }
}
