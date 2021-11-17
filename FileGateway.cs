using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211116
{
	public class FileGateway
	{
        private List<Card> listofCards = new List<Card>();
        private string[] allRows = null;
        private string[] allColumns = null;
        private Card aProduct = null;
        private int index = 1;

        //private string path = "Cards_TSV.txt";

        public List<Card> GetCards(string aPath)
        {
            allRows = File.ReadAllLines(aPath);


            while (index < allRows.Length)
            {
                // aProduct = new Card();

                allColumns = allRows[index].Split('\t');
                if (allColumns[8] == "Minion") 
                {
                    Minion aMinion = new Minion();

                    aMinion.Name = allColumns[0];
                    aMinion.Text = allColumns[1];
                    aMinion.Race = allColumns[2];
                    aMinion.Specialty = allColumns[3];
                    aMinion.Cost = Convert.ToInt32(allColumns[4]);
                    aMinion.Attack = Convert.ToInt32(allColumns[5]);
                    aMinion.Health = Convert.ToInt32(allColumns[6]);
                    aMinion.Skill = allColumns[7];

                    listofCards.Add(aMinion);
                    


                }
				else
				{
                    Spell aSpell = new Spell();

                    aSpell.Name = allColumns[0];
                    aSpell.Text = allColumns[1];

                    aSpell.Specialty = allColumns[3];
                    aSpell.Cost = Convert.ToInt32(allColumns[4]);

                    aSpell.Skill = allColumns[7];

                    listofCards.Add(aSpell);
                }

                index = index + 1;

            }

            return listofCards;

        }
    }
}
