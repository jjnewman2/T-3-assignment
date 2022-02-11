using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T_3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //setting int variable
          int cad_value;
            while (true)
            {
                Console.WriteLine("Enter increment value between 5 and 25:");
                cad_value = Convert.ToInt32(Console.ReadLine());
                if (cad_value >= 5 && cad_value <= 25)
                {
                    break;
                }
                Console.WriteLine("increment value must be between 5 and 25, try again! ");
            }
            // variable for cad and usd
            double CAD = 0, USD;
            Console.WriteLine("CAD US$");
            Console.WriteLine("---------");
            // do while loop
            do
            {
                USD = CAD * .792367;
                //print
                Console.WriteLine(CAD + "    " + USD);
                // increment cad by cad_value
                CAD += cad_value;


            }            //while condition
            while (CAD <= 200);
            
            

        }
    }

}