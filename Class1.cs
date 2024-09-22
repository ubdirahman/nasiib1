using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasiib1
{
    internal class Class1
    {
        public String side;
        Class1()
        {
            side = "cadaan";
        }

        //method void don't have return type

        public void ex()
        {
            //generte whit rondom number white 2 number 0 or 1
            Random random = new Random();
            // if 0;cadaan or 1;madow i am somali

            if (random.Next(2) == 0)
            {

                side = "cadaan";//this head is mean cadaan

            }
            else
            {
                side = "madow"; //this toil is mean madow
            }
        }
        //method return type white only return varible side
        public String getex()
        {
            return side;
        }
    }
}
