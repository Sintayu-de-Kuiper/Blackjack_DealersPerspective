using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_DealersPerspective.Models
{
    public class Hand
    {
        public List<Card> Cards { get; private set; }

        public int Value => Cards.Sum(card => (int)card.Rank);

        public Hand()
        {
            Cards = [];
        }

        public List<Card>? Split()
        {
            // code here
            return null;
        }
    }
}
