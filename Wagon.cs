using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deezn
{
    internal class Wagon
    {
        public int MaxWagonWeight { get; }
        public int CurrentWagonWeight { get; set; }

        public List<Animal> AnimalsInWagon = new List<Animal>();



        public Wagon(List<Animal>animalsInWagon)
        {
            MaxWagonWeight = 10;

            AnimalsInWagon = animalsInWagon;

        }

        public int CalculateWagonWeight()
        {
            int weight = 0;

            foreach (var item in AnimalsInWagon)
            {
                weight = item.Size;


            }

            return CurrentWagonWeight;
        }

    }
}
