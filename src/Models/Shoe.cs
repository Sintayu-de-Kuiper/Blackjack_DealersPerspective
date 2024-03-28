using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_DealersPerspective.Models
{
    public class Shoe
    {
        private readonly List<Card> _cards;
        private readonly Random _random;

        public Shoe()
        {
            _cards = [];
            _random = new Random();
        }

        // Public accessor property for _cards
        public List<Card> Cards => _cards;

        // Adds all cards from a Deck to the Shoe
        public void AddDeck(Deck deck)
        {
            _cards.AddRange(deck.Cards);
        }

        // Shuffle the Shoe
        public void Shuffle()
        {
            // Fisher Yate shuffling algorithm
            for (int currentIndex = 0; currentIndex < _cards.Count; currentIndex++)
            {
                int swapIndex = currentIndex + _random.Next(_cards.Count - currentIndex);
                (_cards[swapIndex], _cards[currentIndex]) = (_cards[currentIndex], _cards[swapIndex]);
            }
        }

        // Draw a Card from the Shoe
        public Card DrawCard()
        {
            if (_cards.Count > 0)
            {
                Card cardToDraw = _cards[0];
                _cards.RemoveAt(0);
                return cardToDraw;
            }
            throw new InvalidOperationException("DrawCard: Shoe is empty.");
        }
    }
}
