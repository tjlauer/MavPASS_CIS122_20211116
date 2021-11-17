using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211116
{
	public class Card
	{
		//variables
		private string name = "N/A";
		private string text = "N/A";
		
		private string specialty = "N/A";
		private int cost = int.MaxValue;
		private string skill = "N/A";
		//private string type = "N/A"; because we will make sep classes

		//properties

		public string Name { get { return this.name; } set { this.name = value; } }
		public string Text { get { return this.text; } set { this.text = value; } }
		
		public string Specialty { get { return this.specialty; } set { this.specialty = value; } }
		public string Skill { get { return this.skill; } set { this.skill = value; } }
		public int Cost { get { return this.cost; } set { this.cost = value; } }

		//const

		public Card(): this("n/a", "n/a", "n/a", "n/a", int.MaxValue)
		{

		}

		public Card(string aName, string aText, string aSpecialty, string aSkill, int aCost)
		{
			this.Name = aName;
			this.Text = aText;
			this.Specialty = aSpecialty;
			this.Skill = aSkill;
			this.Cost = aCost;

		}

		public override string ToString()
		{
			string msg = "";
			msg += $"Name: {Name}\n";
			msg += $"Text: {Text}\n";
			msg += $"Specialty: {Specialty}\n";
			msg += $"Skill: {Skill}\n";
			msg += $"Cost: {Cost}\n";

			return msg;
		}




	}
}
