using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deezn
{
    internal class Animal
    {
        public string Name { get; set; }
        public AnimalSize Size { get; set; }
        public AnimalDiet Diet { get; set; }

        public Animal(string name, AnimalSize size, AnimalDiet diet)
        {
            Name = name;
            Size = size;
            Diet = diet;
        }
    }

    public enum AnimalSize
    {
        Small = 1,
        Medium = 3,
        Large = 5
    }
    public enum AnimalDiet
    {
        Carnivore = 1,
        Herbivore = 2,
    }
}
