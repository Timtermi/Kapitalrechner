using System;

namespace Zinsrechner
{
    class Program
    {
        static void Main(string[] args)
        {

            int Jahr;

            double Anfangskapital;
            int Prozentsatz;




            Console.WriteLine("Geben Sie das Startkapital ein.");
            Anfangskapital = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie den Zinssatz ein.");
            Prozentsatz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie die Jahre ein.");
            Jahr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jahr Guthaben Zinsen K.Zinsen Bilanz");

            Console.WriteLine("Jahr    Guthaben    Zinsen   K.Zinsen    Bilanz");
            #region Jahre
            
            for (int i = 1; i <= Jahr; i++)
            {
                Console.WriteLine("{0,3}", i);
            }
            Console.ReadKey();
            #endregion
           
            
            #region Guthaben
            for (int  a= 1; a==Anfangskapital; a++)
            {
                Console.WriteLine("{0,4}", a);
            }
            Console.ReadKey();
            #endregion
        }
    }
}