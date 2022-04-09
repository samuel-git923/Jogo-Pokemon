using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                Console.Clear();
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                if (resp == 2)
                {
                    pokedex.ListarPokemons();
                    Console.Write("Digite o código do Pokémon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    // pegar o pokemon do player
                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];
                    // definir o pokemon do pc
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPC = pokedex.Pokemons[codigo];
                    // batalhar
                    Console.WriteLine("Dados dos pokémons que irão lutar");
                    Console.WriteLine("Dados do seu pokémon");
                    pPlayer.ExibirDadosPokemonPlus();
                    Console.WriteLine("Dados dos pokémons do PC");
                    pPC.ExibirDadosPokemonPlus();
                    if (pPlayer.Power >= pPC.Power)
                    {
                        Console.WriteLine("You win");
                    }
                    else
                    {
                        Console.WriteLine("You lose");
                    }
                    

                }
                Console.ReadKey();
                Console.Clear();
            }
           
        }

        static int Menu()
        {
            Console.WriteLine("Pokémon -- Jogo de Batalha");
            Console.WriteLine("0 - Sair da Pokédex");
            Console.WriteLine("1 - Listar todos os Pokémons da pokédex");
            Console.WriteLine("2 - Batalhar");
            Console.Write("O que deseja fazer: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
