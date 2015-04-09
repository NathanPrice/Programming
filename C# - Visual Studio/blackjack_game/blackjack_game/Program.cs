using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
  
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "yes";
            Random card = new Random();
            int hucard = card.Next(1, 10);
            int cpcard = card.Next(1, 10);
            int hucard2 = card.Next(1, 10);
            int cpcard2 = card.Next(1, 10);
            int thucard = hucard + hucard2;
            int tcpcard = cpcard + cpcard2;
            int suite1 = card.Next(0, 3);
            int suite2 = card.Next(0, 3);
            int suite3 = card.Next(0, 3);
            int suite4 = card.Next(0, 3);
            /*if (hucard == 11)
            {
                hucard = 10;
                string cardt1="Jack";

            }
            if (hucard2 == 11)
            {
                hucard2 = 10;
                string cardt2="Jack";

            }
            if (cpcard == 11)
            {
                cpcard = 10;
                string cardt3="Jack";

            }
            if (hucard == 11)
            {
                cpcard2 = 10;
                string cardt4 = "Jack";

            }
            else
            {
                string cardt1 = "Number Card";
                string cardt2 = "Number Card";
                string cardt3 = "Number Card";
                string cardt4 = "Number Card";
            }*/

            string[] suiteName =  {"Hearts", "Spades", "Diamonds", "Clubs"} ;
            string suiteName1 = suiteName[suite1];
            string suiteName2 = suiteName[suite2];
            string suiteName3 = suiteName[suite3];
            string suiteName4 = suiteName[suite4];


            
           
           do{
               Console.Clear();
                 Console.WriteLine("Opponent Card Showing:{1} of {2}", thucard, hucard, suiteName3); 
                   Console.WriteLine("Your Cards:{4} Cards: {0} of {1} and {2} of {3}", cpcard, suiteName1, cpcard2, suiteName2, tcpcard);
                Console.WriteLine("Do you want to hit? y/n");
                answer = Console.ReadLine();
                if (answer == "y"|| answer=="Y")
                {
                    int x = card.Next(1, 10);
                    tcpcard += x;
                }
               if (tcpcard > 21)
                {
                 answer = "n";
                 Console.Clear();
                 Console.WriteLine("You Lose!");
                    }
            }
            // answer=="no"|| answer =="No"|| answer =="NO"|| answer=="nO"
            while(tcpcard<=21|| answer=="y"|| answer=="Y"|| answer!="n");

           do
           {
               int x = card.Next(1, 10);
               thucard += x;
           }
           while (thucard > 17);
            Console.Clear();
            Console.WriteLine("Opponent Card Showing:{1} of {2}", thucard, hucard, suiteName3);
           Console.WriteLine("Your Cards:{4} Cards: {0} of {1} and {2} of {3}", cpcard, suiteName1, cpcard2, suiteName2, tcpcard);
           if (thucard > tcpcard && thucard<=21)
           {
               Console.WriteLine("You Lose");
           }
           if (tcpcard > thucard && tcpcard<=21)
           {
               Console.WriteLine("You Win");
           }
           
            
            Console.ReadKey();
        }
    }
}
