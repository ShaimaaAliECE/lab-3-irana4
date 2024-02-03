using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{//start of namespace

    public class Treasure : Collectable//inherits from Collectable class
    {//start of class
        public int Score { get; set; }//property storing the Score of the Treasure 

        public Treasure( string description, int score)
        {//constructor for the Treasure object
            this.Score = score;
            this.Description = description;
        }

        public void UpdateTotalScore()
        {//method to update the total score 
            if (Board != null)
            {
                this.Board.TotalScore += this.Score;
                Console.WriteLine("Total Score is updated to: "+Board.TotalScore);//displaying the total score 
            }
        }

        public override void AddMe(List<Collectable> collectables)
        {//overriding AddMe from Collectable 
            collectables.Add(this);//adding to list 
            Console.WriteLine(Description + " Collected, Congrats!!!!");//displaying message
            UpdateTotalScore();//always displaying the score message 
        }
    }//end of class
}//end of namespace
