using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_DealersPerspective.Models
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }
        private readonly Random random;

        public Deck()
        {
            Cards = [];
            random = new();

            // Initalising the deck by creating all 52 cards
            foreach(Card.SUIT suit in Enum.GetValues(typeof(Card.SUIT)))
            {
                foreach (Card.RANK rank in Enum.GetValues(typeof(Card.RANK)))
                {
                    Cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            // Fisher Yate shuffling algorithm
            int numOfCards = Cards.Count;
            for(int i = 0; i < numOfCards; i++)
            {
                int r = i + random.Next(numOfCards - i);
                Card tempCard = Cards[i];
                Cards[i] = Cards[r];
                Cards[r] = tempCard;
            }
        }

        public Card DealCard()
        {
            Card cardToDeal = Cards[0];
            Cards.RemoveAt(0);
            return cardToDeal;
        }
    }
}
