using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist_final
{
    class Program
    {
        static void Main(string[] args)
        {
            linkedlist lnklist = new linkedlist();
            
            lnklist.AddAtLast("Canada");
            lnklist.AddAtLast("Computer Sceince");
            lnklist.AddAtLast("C#");
            lnklist.AddAtLast("Language");


            lnklist.RemoveNode("Computer Sceince");


            lnklist.ReplaceNode(".Net", "Language");

            lnklist.Add_between("C#", "C_sharp");

            lnklist.AddFirst("Toronto");


            lnklist.PrintAllNodes();



            lnklist.ReverseLinkedlist();




            lnklist.Total_Elements();


            Console.ReadLine();


        }
    }
}
