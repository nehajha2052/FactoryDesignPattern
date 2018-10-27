using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPatternInCSharp
{
    abstract class Joke
    {

/*Properties enable a class to expose a public way of getting and setting values,
while hiding implementation or verification code. 
A get property accessor is used to return the property value, and a set property accessor is used to assign a new value.*/

        public abstract string Joke1 { get; set; }
       
    }
}
