using System;
using System.Collections.Generic;

namespace HomeDZ3
{
    internal class Factory
    {
        public List<Card> CreateCards()
        {
            var result = new List<Card>();

            result.Add(new Card("Мясо",Elements.Air, 1, 1, 
                new Dictionary<string, int>()
                {
                    {"Morality", 2},
                    {"Ethics", 3}
                }));
            result.Add(new Card("Jonny Silverhand",Elements.Earth, 10, 15, 
                new Dictionary<string, int>()
                {
                    {"Morality", 1},
                    {"Ethics", 3}
                }));
            result.Add(new Card("Орц", Elements.Fire, 2, 5,
                new Dictionary<string, int>()
                {
                    {"Morality", 3},
                    {"Ethics", 3}
                }));
            result.Add(new Card("Карта", Elements.Water, 15, 5,
                new Dictionary<string, int>()
                {
                    {"Morality", 1},
                    {"Ethics", 1}
                }));
            result.Add(new Card("Дуб", Elements.Earth, 2, 20,
                new Dictionary<string, int>()
                {
                    {"Morality", 3},
                    {"Ethics", 3}
                }));
            result.Add(new Card("Рембо", Elements.Fire, 19, 10,
                new Dictionary<string, int>()
                {
                    {"Morality", 1},
                    {"Ethics", 2}
                }));
            result.Add(new Card("Комар", Elements.Air, 20, 20,
                new Dictionary<string, int>()
                {
                    {"Morality", 3},
                    {"Ethics", 3}
                }));
            result.Add(new Card("Гитара", Elements.Water, 10, 3,
                new Dictionary<string, int>()
                {
                    {"Morality", 1},
                    {"Ethics", 2}
                }));
            result.Add(new Card("Синий кит", Elements.Water, 2, 6,
                new Dictionary<string, int>()
                {
                    {"Morality", 3},
                    {"Ethics", 1}
                }));
            result.Add(new Card("Люда", Elements.Earth, 8, 11,
                new Dictionary<string, int>()
                {
                    {"Morality", 1},
                    {"Ethics", 2}
                }));

            return result;
        }
    }
}
