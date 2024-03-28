using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_DealersPerspective.Models
{
    public class Participant
    {
        public EventHandler<ParticipantActionEventArgs>? Hit;
        public EventHandler<ParticipantActionEventArgs>? Stand;

        public void PerformHit(Hand hand)
        {
            OnHit(hand);
        }

        public void PerformStand(Hand hand)
        {
            OnStand(hand);
        }

        protected virtual void OnHit(Hand hand)
        {
            Hit?.Invoke(this, new ParticipantActionEventArgs(hand));
        }

        protected virtual void OnStand(Hand hand)
        {
            Stand?.Invoke(this, new ParticipantActionEventArgs(hand));
        }
    }
}
