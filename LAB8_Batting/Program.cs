using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_Batting
{
    public class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to Average calculator");
            string reply = "";
            do
            {
                Console.WriteLine("Enter number of times at bat...");
                string batnumRead = Console.ReadLine();
                int batnum = int.Parse(batnumRead);
                Console.WriteLine("0=out,1=single,2=double,3=triple,4=home run");

                int[] Batting = new int[batnum];



                int x = 0;
                do
                {
                    Console.WriteLine($"Result for at bat{x}:");
                    string ans = Console.ReadLine();
                    int answer = int.Parse(ans);
                    Batting[x] = answer;
                    x++;
                } while (x < batnum);



                double playerbattingaverage = CalculateBattingAverage(Batting);
                Console.WriteLine("Batting Average:.." + playerbattingaverage);
                double playerslugginggaverage = CalculateSluggingPercentage(Batting);
                Console.WriteLine("Slugging percentage.." + playerslugginggaverage);

                Console.WriteLine("Another Battle? y/n?");
                 reply = Console.ReadLine();
            }
            while (reply == "y");

            Console.WriteLine("Thank you for playing"); 



                
        }
        public static double CalculateBattingAverage(int[] battingSheet)
        {
            int totalNumberOfBats = battingSheet.Length;
            int valueBat = 0;
            for (int i = 0; i < totalNumberOfBats; i++)
            {
                if (battingSheet[i] == 0)
                {
                    valueBat = valueBat + 0;
                }
                else
                {
                    valueBat = valueBat + 1;
                }
            }
            double average = ((double)valueBat) / totalNumberOfBats;
            return average;
        }

        public static double CalculateSluggingPercentage(int[] battingSheet)
        {
            int totalNumberOfatBats = battingSheet.Length;
            int totalNumOfBassesEarned = 0;
            for (int i = 0; i < totalNumberOfatBats; i++)
            {

                totalNumOfBassesEarned = totalNumOfBassesEarned + battingSheet[i];

            }

            double average = ((double)totalNumOfBassesEarned) / totalNumberOfatBats;
            return average;

        }

    }
}




