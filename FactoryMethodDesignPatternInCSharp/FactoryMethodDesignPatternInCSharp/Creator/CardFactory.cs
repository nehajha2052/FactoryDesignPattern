using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPatternInCSharp.Creator
{
    //the 'Creator' abstract class
    abstract class JokeFactory
    {
        //abstract mehtod has no implementation
        public abstract Joke CreateJoke();
    }
}
