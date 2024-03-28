using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_DealersPerspective.Models
{
    public class Chip(Chip.VALUE value)
    {
        public enum VALUE
        {
            ONE = 1,
            FIVE = 5,
            TWENTYFIVE = 25,
            HUNDRED = 100,
            FIVEHUNDRED = 500,
            THOUSAND = 1_000
        }

        public VALUE Value { get; private set; } = value;
    }
}
