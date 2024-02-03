using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{//start of namespace
    public class MagicWand : Tool//inherits Tool class
    {//start of class
        public MagicWand(string description) : base(description) {}//constructor for a MagicWand with a description

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");//action of writing in the output terminal 
        }
    }//end of class
}//end of namespace
