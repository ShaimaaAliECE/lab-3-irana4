using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{//start of namespace
    public class Diamond : Treasure//inherits from the Treasure class
    {//start of class

        public Diamond(string description, int score) : base(description, score){ }//constructor for a Diamond with a description 

        public override void Display()
        {//overriding display method so the Diamond description can be seen 
            Console.WriteLine("Diamond "+Description+" is displayed");
        }
    }//end of class
}//end of namespace