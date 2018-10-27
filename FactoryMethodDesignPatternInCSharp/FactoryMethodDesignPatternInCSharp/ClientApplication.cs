using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPatternInCSharp
{
    class ClientApplication
    {
        static void Main()
        {
            /*A reference variable sometimes does and sometimes does not refer to an object
             and can refer to different objects at different times. 
             You need a way to say that a variable does not now refer to an object. 
             You do this by assigning null to the variable.*/

            Creator.JokeFactory factory = null;
            Console.Write("Enter the character whose joke you want to know:");
            string character = Console.ReadLine();

            switch(character.ToLower())
            {
                case "joey":
                    factory = new ConcreteCreator.JoeyJokeFactory("How you doin??");
                    break;
                case "chandler":
                    factory = new ConcreteCreator.ChandlerJokeFactory("My dad is in Vegas with his boyfriends!");
                    break;
                case "ross":
                    factory = new ConcreteCreator.RossJokeFactory("WE WERE ON A BREAK!!");
                    break;
                default:
                    break;
            }

            Joke joke1 = factory.CreateJoke();
            Console.WriteLine("\nThe joke for the chosen character is below: : \n");
            Console.WriteLine("Joke: {0}\n",joke1.Joke1);
            Console.ReadKey();
        }
    }
}
