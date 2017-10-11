using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class ViewMammals : View
    {
        public void DisplayAnimals(List<string> mammalNames)
        {
            foreach(string mammal in mammalNames)
            {
                Console.WriteLine("Hello " + mammal);
            }
        }

        public void PrintAnimal(string s)
        {
            Console.WriteLine("Hello " + s);
        }
    }
}
