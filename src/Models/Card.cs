using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_DealersPerspective.Models
{
    public class Card(Card.SUIT suit, Card.RANK rank)
    {
        public enum SUIT
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        public enum RANK
        {
            TWO = 2,
            THREE,
            FOUR,
            FIVE,
            SIX,
            SEVEN,
            EIGHT,
            NINE,
            TEN,
            JACK = 10,
            QUEEN = 10,
            KING = 10,
            ACE,
        }

        public SUIT Suit { get; } = suit;
        public RANK Rank { get; } = rank;

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
