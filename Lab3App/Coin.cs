using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{//start of the namespace
    public class Coin : Treasure//inherits Treasure
    {//start of class

        //property to store the value of the coin
        public int Value { get; set; }

        //constructor for creating a Coin object with a description, score, and value
        public Coin(string description, int score, int value) : base(description, score)
        {
            //setting value property of Coin
            Value = value;
        }

        //method to update the total value on the collection board when a coin is collected
        public void UpdateTotalValue(CollectionBoard board)
        {
            //update the total value on the board by adding the coin's value
            board.TotalValue += Value;
            //display a message about the value
            Console.WriteLine("Total Value is updated to: "+board.TotalValue);
        }

        //override the AddMe method from the base class
        public override void AddMe(List<Collectable> collectables)
        {
            //call the base class AddMe method to add the coin to the list of collectables
            base.AddMe(collectables);
            //check if the coin is in the collection board
            if (Board != null)
            {
                UpdateTotalValue(Board);
            }
        }

        
        public override void Display()
        {//override Display method to print the following message in the output terminal
            Console.WriteLine("Coin "+Description+" is displayed");
        }

    } //end of class
}//end of namespace
