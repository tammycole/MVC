using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    interface View
    {
        void PrintAnimal(string s);

        void DisplayAnimals(List<string> animals);
    }
}
