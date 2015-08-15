using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class HelloWorldApi
    {
        public string Greet(string name)
        {
            return $@"Hello {name}";
        }

        public string Leave(string name)
        {
            return $@"Goodbye {name}";
        }
    }
}
