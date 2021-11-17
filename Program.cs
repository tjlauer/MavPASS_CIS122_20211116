using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211116
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Deck aDeck = new Deck();

			aDeck.AddDeck("Cards_TSV.txt");

			aDeck.Shuffle();

			foreach (Card card in aDeck.DeckOfCards)
			{
				Console.WriteLine(card);
			}


			Player Player1 = new Player();

			Player1.AddCard(aDeck.Draw());

			Console.WriteLine("HAND");
			Console.WriteLine(Player1.ToString());

			Console.ReadLine();
		}
	}
}
