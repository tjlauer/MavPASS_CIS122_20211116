// Jeremy + MAVPASS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211116
{
	public class Minion : Card
	{
		private int attack = int.MinValue;
		private int health = -1;
		private string race = "N/A";

		//props

		public int Attack
		{
			get { return this.attack; }
			set {  this.attack = value; }
		}
		public int Health
		{
			get { return this.health; }
			set { this.health = value; }
		}
		public string Race { get { return this.race; } set { this.race = value; } }

		// Cont

		public Minion():this("n/a", "N/a", "NA", "n/a", "n/a", int.MaxValue, int.MinValue, -1)
		{

		}
		public Minion(string aName, string aText, string aRace, string aSpecialty, string aSkill, int aCost, int anAttack, int aHealth) : base(aName, aText, aSpecialty, aSkill, aCost)
		{
			this.Attack = anAttack;
			this.Health = aHealth;
			this.Race = aRace;
		}

		public override string ToString()
		{
			string msg = base.ToString();
			msg += $"Attack: {Attack}\n";
			msg += $"Health: {Health}\n";
			msg += $"Race: {Race}\n";

			return msg;

		}
	}
}
