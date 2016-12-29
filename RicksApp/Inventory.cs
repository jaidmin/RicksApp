using System.Collections.Generic;

namespace RicksApp
{
    public class Inventory
    {
        private readonly List<Guitar> _guitars;

        public Inventory()
        {
            _guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price,
            Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings)
        {
            Guitar guitar = new Guitar(serialNumber, price, new GuitarSpec(builder, model, type, backWood, topWood, numStrings));
            _guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in _guitars)
            {
                if (guitar.SerialNumber == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (var guitar in _guitars)
            {
                if (guitar.Spec.Matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }
            }
            return matchingGuitars;
        }
    }
}