using System;
using System.Collections.Generic;

namespace RicksApp
{
    public class FindGuitarTester
    {
        public static void Run()
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErikLikes = new GuitarSpec(Builder.Fender, "Stratocasto", Type.Acoustic, Wood.Alder,
                Wood.Alder,12);
            List<Guitar> guitars = inventory.Search((whatErikLikes));
            if(guitars.Count != 0)
            foreach (var guitar in guitars)
            {
                if (guitar != null)




                    Console.WriteLine("Erin, you might like this " +
                                      guitar.Spec.Builder + " " + guitar.Spec.Model + " " + guitar.Spec.Type + " guitar:\n" +
                                      guitar.Spec.BackWood + " back and sides, \n" + guitar.Spec.TopWood +
                                      " top \n you can have it for only: "
                                      + guitar.Price + "!" + "\n" + "\n----------\n");



            }
            else
            {
                Console.WriteLine(" Sorry, erin we have noting for you.");
            }
        }


        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("V123456", 1499.95, Builder.Fender, "Stratocasto", Type.Acoustic, Wood.Alder,
                Wood.Alder, 12);
            inventory.AddGuitar("test2", 0, Builder.Collings, "stratocastor", Type.Electric, Wood.BrazilianRosewood,
                Wood.IndianRosewood,10);
            inventory.AddGuitar("V12345", 1549.49, Builder.Fender, "Stratocasto", Type.Acoustic, Wood.Alder,
                Wood.Alder,12);
        }
    }
}