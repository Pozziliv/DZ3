using System;
using System.Collections.Generic;

namespace HomeDZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            List<Card> cards = factory.CreateCards();

            BattleController battleController = new BattleController();
            List<Card> hand = battleController.CreateHand(cards);

            Printer printer = new Printer();

            Console.Write("Введите кол-во врагов: ");
            int dungeonLenght = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < dungeonLenght; i++)
            {
                Card enemy = battleController.NextEnemy(cards);
                bool isWin = false;
                while (isWin != true)
                {
                    printer.PrintEnemy(enemy);

                    printer.PrintHand(hand);

                    List<int> choices = printer.Choice();

                    if (choices[0] == 1)
                    {
                        isWin = battleController.Attack(hand[choices[1] - 1], enemy);
                        if (isWin)
                            battleController.points++;
                    }
                    if (choices[0] == 2)
                    {
                        isWin = battleController.TryDeal(hand[choices[1] - 1], enemy);
                        if (isWin)
                            battleController.points++;
                    }
                    if (choices[0] == 3)
                    {
                        battleController.ChangeCard(ref hand, choices[1] - 1, cards);
                    }
                    Console.Clear();
                }
            }

            Console.WriteLine($"ПОБЕДА: {battleController.points} ПОИНТОВ");
        }
    }
}
