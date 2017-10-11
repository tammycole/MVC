using System.Collections.Generic;

namespace MVC
{

    class Mammal : Animal
    {
        List<string> mammalNames = new List<string>();

        public void Animal()
        {
            mammalNames.Add("Elephant");
            mammalNames.Add("Horse");
            mammalNames.Add("Zebra");
            mammalNames.Add("Tiger");
            mammalNames.Add("Leopard");
        }

        public List<string> GetAllAnimals()
        {
            return mammalNames;
        }

        public string GetAnimal(int index)
        {
            return mammalNames[index];
        }
    }
}
