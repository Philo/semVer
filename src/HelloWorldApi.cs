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
            return string.Format("Hello {0}", name);
        }

        public string Leave(string name)
        {
            return string.Format("Goobye {0}!", name);
        }
    }
}
