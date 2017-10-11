using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Bird : Animal
    {
        List<string> birdNames = new List<string>();

        public void Animal()
        {
           
        }

        public List<string> GetAllAnimals()
        {
            return birdNames;
        }

        public string GetAnimal(int index)
        {
            return birdNames[index];
        }
    }
}
