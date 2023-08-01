using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeDZ3
{
    internal class BattleController
    {
        public int points = 0;

        Random rand = new Random();

        public bool Attack(Card attacker, Card target)
        {
            float strength = attacker.Strength;

            if (attacker.Element == target.Element)
            {
                strength *= 0.7f;
            }

            if(target.Health <= strength)
                return true;
            else
                return false;
        }

        public bool TryDeal(Card Dealer, Card target)
        {
            float diff = Math.Abs(Dealer.WorldviewEquivalent - target.WorldviewEquivalent);
            float maxDiff = 9;
            float chance = 1 - diff/maxDiff;
            double randomDouble = rand.NextDouble();

            if(randomDouble < chance)
                return true;
            else
                return false;
        }

        public Card NextEnemy(List<Card> cards)
        {
            int index = rand.Next(0, cards.Count());

            return cards[index];
        }

        public List<Card> CreateHand(List<Card> cards)
        {
            List<Card> hand = new List<Card>();
            while(hand.Count < 5)
            {
                int index = rand.Next(0, cards.Count());
                if(!hand.Contains(cards[index]))
                    hand.Add(cards[index]);
            }
            return hand;
        }

        public void ChangeCard(ref List<Card> hand, int index, List<Card> cards)
        {
            hand.RemoveAt(index);
            while (true)
            {
                int cardIndex = rand.Next(0, cards.Count());
                if (!hand.Contains(cards[cardIndex]))
                {
                    hand.Insert(index, cards[cardIndex]);
                    break;
                }
            }
        }
    }
}
