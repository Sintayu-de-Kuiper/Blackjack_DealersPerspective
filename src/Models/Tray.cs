using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_DealersPerspective.Models
{
    public class Tray
    {
        private readonly List<Card> _cards;

        public Tray()
        {
            _cards = [];
        }

        // Public accessor property for _cards
        public ReadOnlyCollection<Card> Cards => _cards.AsReadOnly();

        // Number of cards in '_cards'
        public int NumberOfCards => _cards.Count;

        // Add one card to '_cards'
        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        // Add a list of cards to '_cards'
        public void AddCards(List<Card> cards)
        {
            _cards.AddRange(cards);
        }

        // Returns the whole tray of cards and removes them locally
        public List<Card> GetAllCards()
        {
            List<Card> cardsToReturn = new(_cards);
            _cards.Clear();
            return cardsToReturn;
        }
    }
}
