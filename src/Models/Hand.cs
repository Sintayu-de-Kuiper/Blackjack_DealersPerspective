using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_DealersPerspective.Models
{
    public class Hand
    {
        private readonly List<Card> _cards;

        private static int GetCardValue(Card card)
        {
            return card.Rank switch
            {
                Card.RANK.TWO => 2,
                Card.RANK.THREE => 3,
                Card.RANK.FOUR => 4,
                Card.RANK.FIVE => 5,
                Card.RANK.SIX => 6,
                Card.RANK.SEVEN => 7,
                Card.RANK.EIGHT => 8,
                Card.RANK.NINE => 9,
                Card.RANK.TEN => 10,
                Card.RANK.JACK => 10,
                Card.RANK.QUEEN => 10,
                Card.RANK.KING => 10,
                Card.RANK.ACE => 11,
                _ => 0
            };
        }

        public Hand()
        {
            _cards = [];
        }

        // Public accessor property for _cards
        public List<Card> Cards => _cards;

        // public property that returns the combined value of all cards in '_cards', according to Blackjack rules.
        public int Value
        {
            get
            {
                int value = 0;
                int numberOfAces = 0;

                // Loop that adds the value of each card to the 'value' variable
                foreach (var card in _cards)
                {
                    // Increment 'numberOfAces' if an ace is detected
                    if(card.Rank == Card.RANK.ACE)
                    {
                        numberOfAces++;
                    }

                    value += GetCardValue(card);
                }

                // Convert ace value's to 1 if value exceeds 21
                for (; value > 21 && numberOfAces > 0;)
                {
                    value -= 10;
                    numberOfAces--;
                }

                return value;
            }
        }

        // Indicates if the hand is soft (has an Ace counted as 11)
        public bool IsSoft
        {
            get
            {
                int value = 0;
                int numberOfAces = 0;

                foreach (var card in _cards)
                {
                    if (card.Rank == Card.RANK.ACE)
                    {
                        numberOfAces++;
                    }
                    value += GetCardValue(card);
                }

                return numberOfAces > 0 && value <= 21;
            }
        }

        // Add one card to hand
        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        // Split hand
        public (Card, Card)? SplitSelf()
        {
            if (_cards.Count == 2 && _cards[0].Rank == _cards[1].Rank)
            {
                var splitCards = (_cards[0], _cards[1]);
                _cards.Clear(); // Clear the hand after splitting
                return splitCards;
            }

            return null;
        }
    }
}
