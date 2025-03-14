using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class ParameterizedConstructor
    {
        string x;
        public ParameterizedConstructor(string name)
        {
            x = name;
            Console.WriteLine("Parameterized Constructor is called " + name);
        }
        public void Display()
        {
            Console.WriteLine("Value of X is :" + x);
        }
        static void Main()
        {
            ParameterizedConstructor myParameterizedConstructor1 = new ParameterizedConstructor("Pavan");
            ParameterizedConstructor myParameterizedConstructor2 = new ParameterizedConstructor("Pamarthi");

        }
    }
}
