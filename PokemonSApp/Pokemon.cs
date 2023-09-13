using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSApp
{
    public class Pokemon
    {
        private string Name;
        private PokemonType Type;
        private int Health;

        public Pokemon(string name, PokemonType type, int health)
        {
            Name = name;
            Type = type;
            Health = health;
        }


        public void Attack(Pokemon enemy)
        {
            //Here you can if you want to make a complicated battle
            //For simplicty, decrease value by 10 each attack
            Console.WriteLine("Attack succesful!");
            enemy.Health -= 10;
        }

        public void RestoreHealth()
        {
            Console.WriteLine("You healed your pokemon");
            Health = 100;
        }


        public string GetName()
        {
            return Name;
        } 

        public PokemonType GetType()
        {
            return Type;
        }

        public int GetHealth()
        {
            return Health;
        }



    }
}
