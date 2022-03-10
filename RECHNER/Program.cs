using System;

namespace Rechner

{

    class Program

    {

        static void Main(string[] args)

        {
            Console.WriteLine("Geben sie das Kapital ein");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie den Prozentsatz ein");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie die Anzahl der Jahre ein");
            double n = Convert.ToDouble(Console.ReadLine());
          
           
            Console.WriteLine($"{"Jahr",4}  {"Guthaben",11}  {"Zinsen",9}  {"K.Zinsen",9}  {"Billanz",9}");
            Console.WriteLine("--------------------------------------------------");

            double nextcapital = 0.00;
            double ZinsAkt = 0.00;
            double Zinssumme = 0.00;
            double Kapitaljahr = 0.00;
            nextcapital = k;


                


            for (int i = 1; i<=n;i++)
            {
                

                ZinsAkt = nextcapital * (p/100);
                Zinssumme = Zinssumme + ZinsAkt;
                Kapitaljahr = nextcapital+Zinssumme;
                nextcapital = nextcapital + ZinsAkt;

                if (i == n)
                {
                    Console.WriteLine("--------------------------------------------------");
                }



                Console.WriteLine($"{i,4}|{nextcapital,11:F2}E|{ZinsAkt,9:F2}E|{Zinssumme,9:F2}E|{Kapitaljahr,9:F2}E");
              
            }
            Console.ReadKey();
        }
    }
}