using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPatternInCSharp
{
    class JoeyJoke : Joke
    {        
        private string _joke;

//create constructor to initialize class members
        public JoeyJoke(string jk)
        {
            _joke = jk;
        }

//overriding the class members from which inherited for providing an alternate implementation
        public override string Joke1
        {
            get { return _joke; }
            set { _joke = value; }
        }       
    }
}
