using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class PokemonPlus : Pokemon
    {
        public PokemonPlus() : base()
        {
            this.Power = 0;
        }

        public PokemonPlus(String nome, String descricao, int power) : base(nome, descricao)
        {
            this.Power = power;            
        }

        public int Power { get; set; }

        public void ExibirDadosPokemonPlus()
        {
            Console.WriteLine("Nome do Pokémon: " + this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
            Console.WriteLine("Poder do Pokémon: " + this.Power);
        }
    }
}
