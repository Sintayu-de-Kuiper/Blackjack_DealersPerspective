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
        private readonly List<Card> _cards;
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

        // Public accessor property for _cards
        public List<Card> Cards => _cards;

        // Shuffle cards
        public void Shuffle()
        {
            // Fisher Yate shuffling algorithm
            for (int currentIndex = 0; currentIndex < _cards.Count; currentIndex++)
            {
                int swapIndex = currentIndex + random.Next(_cards.Count - currentIndex);
                (_cards[currentIndex], _cards[swapIndex]) = (_cards[swapIndex], _cards[currentIndex]);
            }
        }

        // Draw one card
        public Card DrawCard()
        {
            if (_cards.Count > 0)
            {
                Card cardToDraw = _cards[0];
                _cards.RemoveAt(0);
                return cardToDraw;
            }
            else
                throw new InvalidOperationException("DrawCard: Deck is empty");
        }
    }
}
