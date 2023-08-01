using System.Collections.Generic;

namespace HomeDZ3
{
    internal class Card
    {
        public string Name { get; private set; }
        public Elements Element { get; private set; }
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int WorldviewEquivalent { get; private set; }

        public Card(string name, Elements element, int strength, int health, Dictionary<string, int> worldview)
        {
            Name = name;
            Element = element;
            
            Health = Clamp(health, 0, 20);
            Strength = Clamp(strength, 0, 20);

            WorldviewEquivalent = CalculateEquivalent(worldview);
        }



        private int Clamp(int value, int minValue, int maxValue)
        {
            if (value < minValue)
                return minValue;
            if(value > maxValue)
                return maxValue;
            return value;
        }

        private int CalculateEquivalent(Dictionary<string, int> worldview)
        {
            int equivalent = 1;
            foreach (int vievPoints in worldview.Values)
                equivalent *= vievPoints;
            return equivalent;
        }
    }
}
