using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_DealersPerspective.Models
{
    public class ParticipantActionEventArgs(Hand hand) : EventArgs
    {
        public Hand Hand { get; } = hand;
    }
}
