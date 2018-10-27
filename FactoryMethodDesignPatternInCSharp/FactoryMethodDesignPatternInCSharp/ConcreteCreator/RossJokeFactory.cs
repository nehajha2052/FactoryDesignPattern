using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPatternInCSharp.ConcreteCreator
{
    class RossJokeFactory : Creator.JokeFactory
    {
        private string _joke;


        //create constructor to initialize class members
        public RossJokeFactory(string jk)
        {
            _joke = jk;
        }

        //overriding the class members from which inherited for providing an alternate implementation
        public override Joke CreateJoke()
        {
            return new JoeyJoke(_joke);
        }
    }
}
