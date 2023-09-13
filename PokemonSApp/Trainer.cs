using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSApp
{
    internal class Trainer
    {
        private string TrainerName;
        private List<Pokemon> Team;

        public Trainer(string trainerName)
        {
            TrainerName = trainerName;
            Team = new List<Pokemon>();
        }

        //Create a method that allows us to catch a pokemon and add it to the List
        public void CatchPokemon(Pokemon pokemon)
        {
            Team.Add(pokemon);
        }

        public string GetTrainerName()
        {
            return TrainerName;
        }

        public List<Pokemon> GetTeam() 
        {
            return Team;
        }
    }
}
