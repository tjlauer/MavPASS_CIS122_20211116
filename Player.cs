// Jeremy + MAVPASS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211116
{
	public class Player
	{
		private List<Card> hand = new List<Card>();

		public List<Card> Hand { 
			get { return this.hand; } 
			set { this.hand = value; } 
		}

		public void AddCard(Card aCard)
		{
			
			if(Hand.Count < 5)
			{
				Hand.Add(aCard);
			}
		}

		public override string ToString()
		{
			string msg = "";

			foreach(Card card in Hand)
			{
				msg += card.ToString();
			}

			return msg;
		}


	}
}
