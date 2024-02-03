using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{//start of namespace
    public abstract class Collectable : Displayable//inherits displayable
    {//start of class
        //properties to be used and inherited
        public string Description { get; set; }
        public CollectionBoard Board { get; set; }

        public abstract void AddMe(List<Collectable> collectables);//empty abstract method to be extended in other classes

        public virtual void Display()//basic display method to be used in the program for all objects  
        {
            Console.WriteLine(Description + " is displayed");
        }
    }//end of class

}//end of namespace
