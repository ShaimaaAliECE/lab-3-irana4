using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{//start of namespace
    public class Axe : Tool//inherits Tool
    {//start of class
        public Axe(string description) : base(description){ }//constructor that uses makes sure the is an Axe description

        public override void DoAction()
        {//overrided DoAction method that displays in the output terminal a message
            Console.WriteLine("Axe is used");
        }
    }//end of class

}//end of namespace
