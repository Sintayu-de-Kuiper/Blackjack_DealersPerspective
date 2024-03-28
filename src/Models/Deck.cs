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
        private List<Card> _cards;
        private readonly Random random;

        public Deck()
        {
            _cards = [];
            random = new();

            // Initalising the deck by creating all 52 cards
            foreach(Card.SUIT suit in Enum.GetValues(typeof(Card.SUIT)))
            {
                foreach (Card.RANK rank in Enum.GetValues(typeof(Card.RANK)))
                {
                    _cards.Add(new Card(suit, rank));
                }
            }
        }

        public List<Card> Cards => _cards;

        public void Shuffle()
        {
            // Fisher Yate shuffling algorithm
            int numOfCards = _cards.Count;
            for(int i = 0; i < numOfCards; i++)
            {
                int r = i + random.Next(numOfCards - i);
                Card tempCard = _cards[i];
                _cards[i] = _cards[r];
                _cards[r] = tempCard;
            }
        }

        public Card DrawCard()
        {
            Card cardToDraw = _cards[0];
            _cards.RemoveAt(0);
            return cardToDraw;
        }
    }
}
