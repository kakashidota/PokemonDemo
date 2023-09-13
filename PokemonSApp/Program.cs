namespace PokemonSApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon("Pikachu", PokemonType.Electric, 100);

            Pokemon pokemon2 = new Pokemon("Squirtle", PokemonType.Water, 100);

   
            Trainer trainer1 = new Trainer("Ash");

            Trainer trainer2 = new Trainer("Misty");

            //Skapa två metodanrop som tillåter oss attt fånga en pokemon
            //ASH
            trainer1.CatchPokemon(pokemon1);

            //MISTY
            trainer2.CatchPokemon(pokemon2);


            Console.WriteLine($"{trainer1.GetTrainerName()} has {trainer1.GetTeam()[0].GetName()} with {trainer1.GetTeam()[0].GetHealth()} hp");
            Console.WriteLine($"{trainer2.GetTrainerName()} has {trainer2.GetTeam()[0].GetName()} with {trainer2.GetTeam()[0].GetHealth()} hp");

            Console.WriteLine("Battle begins!!!!!!!!");

            //Ash commands pokemon to attack!
            Console.WriteLine($"{trainer1.GetTrainerName()} commands {trainer1.GetTeam()[0].GetName()} to attack!");
            trainer1.GetTeam()[0].Attack(pokemon2);
            Console.WriteLine($"{trainer2.GetTrainerName()}s {trainer2.GetTeam()[0].GetName()} now has {trainer2.GetTeam()[0].GetHealth()} hp");


            //Misty commands pokemon to attack!
            Console.WriteLine($"{trainer2.GetTrainerName()} commands {trainer2.GetTeam()[0].GetName()} to attack!");
            trainer2.GetTeam()[0].Attack(pokemon1);
            Console.WriteLine($"{trainer1.GetTrainerName()}s {trainer1.GetTeam()[0].GetName()} now has {trainer1.GetTeam()[0].GetHealth()} hp");


            //END BATTLE
        }


    }
}
















//Encapsulation Pelare 1:
//Encapsulation refers to the bundling of data and methoods that operate on the data into a single unit called class.
//Moreever, it restricts direct acess to some of the objects components
//which prevents uninteded interefences and missuse of data


//Scope {DETTA ÄR ETT SCOPE}. The code between { }

//AcessModifiers
//1.Public: A public variable/method/class can be acessed from anyother code in the same assembly
//2.Private: The variable/method/class is only accesible within its own class
//3.Protected: The variable/method/class is accesible within its own class and derived classes
//4.Internal: The variable/method/class can be accesed any code in the same assembly but not from another assembly
//5.Protected Internal: The variable/method/class can be accsed by any code in the assembly in which its DECLARED
//  or from within a derived class in another assembly