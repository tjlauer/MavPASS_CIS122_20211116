// Jeremy + MAVPASS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211116
{
	public class Spell : Card
	{
		// Constructor

		public Spell() : this("n/a", "n/a", "n/a", "n/a", int.MaxValue)
		{

		}
		public Spell(string aName, string aText, string aSpecialty, string aSkill, int aCost) : base(aName, aText, aSpecialty, aSkill, aCost)
		{

		}
	}
}
