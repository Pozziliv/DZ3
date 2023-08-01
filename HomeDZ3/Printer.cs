using System;
using System.Collections.Generic;

namespace HomeDZ3
{
    internal class Printer
    {
        public void PrintEnemy(Card enemy)
        {
            Console.WriteLine($"На вас напал {enemy.Name}\nСила врага: {enemy.Strength}\n" +
                $"Здоровье врага: {enemy.Health}\nСтихия врага: {enemy.Element}\n" +
                $"Мировоззрение врага: {enemy.WorldviewEquivalent}\n");
        }

        internal void PrintHand(List<Card> hand)
        {
            int index = 0;
            int offseX = 25;
            int offseY = 10;
            foreach(Card card in hand)
            {
                Console.SetCursorPosition(offseX * index, offseY);
                Console.WriteLine($"{card.Name}");
                Console.SetCursorPosition(offseX * index, offseY + 1);
                Console.WriteLine($"Сила: {card.Strength}");
                Console.SetCursorPosition(offseX * index, offseY + 2);
                Console.WriteLine($"Стихия: {card.Element}");
                Console.SetCursorPosition(offseX * index, offseY + 4);
                Console.WriteLine($"Мировоззрение: {card.WorldviewEquivalent}\n");

                index++;
            }
        }

        internal List<int> Choice()
        {
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("Что будете делать?");
            Console.WriteLine("1) Атака");
            Console.WriteLine("2) Перемирие");
            Console.WriteLine("3) Сброс карты");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите номер карты: ");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            return new List<int>() { choice1, choice2 };
        }
    }
}
