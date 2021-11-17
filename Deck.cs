// Jeremy + MAVPASS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211116
{
	public class Deck
	{
		private List<Card> deckOfCards = new List<Card>();

		public List<Card> DeckOfCards { get { return this.deckOfCards;} set { this.deckOfCards = value; } }

		public Deck() { }
		// methods
		public void AddCard(Card aCard)
		{
			this.DeckOfCards.Add(aCard);
		}
		public void AddDeck(string aPath)
		{
			FileGateway aGateway = new FileGateway();

			List<Card> aNewDeckOfCards = new List<Card>();

			aNewDeckOfCards = aGateway.GetCards(aPath);

			DeckOfCards = aNewDeckOfCards;

		}
		public void Shuffle()
		{
			List<Card> ShuffledDeck = new List<Card>();
			Random ran = new Random();
			int amountOfTimes = DeckOfCards.Count();

			for (int i = 0; i < amountOfTimes ; i++)
			{
				int aRandomIndex = ran.Next(0, DeckOfCards.Count() - 1);
				ShuffledDeck.Add(DeckOfCards[aRandomIndex]);
				DeckOfCards.RemoveAt(aRandomIndex);
			}

			DeckOfCards = ShuffledDeck;
		}

		public Card Draw()
		{
			Card aCard = DeckOfCards[0];
			DeckOfCards.RemoveAt(0);

			return aCard;
		}

	}
}
