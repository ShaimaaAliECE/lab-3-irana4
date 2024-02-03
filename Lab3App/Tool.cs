using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{//start of namespace
    public class Tool : Collectable//inherits Collectable class
    {//start of class
        public Tool(string description)
        {//Tool constructor for object
            this.Description = description;
        }

        public virtual void DoAction(){}//method without a body so it can be overrided better

        public override void AddMe(List<Collectable> collectables)
        {//overrided AddMe method from the Collectables class
            collectables.Add(this);
            Console.WriteLine(Description + " Collected, Congrats!!!!");
            DoAction();
        }

        
    }//end of class

}//end of namespace
