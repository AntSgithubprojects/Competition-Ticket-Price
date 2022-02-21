using System;

namespace QueenslandCompetitionApp_
{
    class Program
    {
        static void Main(string[] args)
        {
            //s1
            string border = "*******************************";
            string motto = "The stars shine in Queensland";

            Console.WriteLine(border);
            Console.WriteLine("*" + motto + "*");
            Console.WriteLine(border);

            Console.WriteLine();
            // s2 

            double Adult = 20;
            double Child = Adult * 0.50;
            double Senior = Adult * 0.70;
            int AdultTicket;
            int ChildTicket;
            int SeniorTicket;



            Console.WriteLine("Please Input Adult Sales");

            AdultTicket = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("Value of Adult tickets sold = $" + (AdultTicket * Adult));


            Console.WriteLine("Please Input Child Sales");

            ChildTicket = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("Value of Child tickets sold = $" + (ChildTicket * Child));


            Console.WriteLine("Please Input Senior Sales");

            SeniorTicket = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("Value of Senior tickets sold = $" + (SeniorTicket * Senior));

            Console.WriteLine();
            Console.WriteLine("Total Revenue = $" + ((Adult * AdultTicket) + (Child * ChildTicket) + (Senior * SeniorTicket)));
            Console.WriteLine();
            // s3

            Console.WriteLine("Adult tickets sold = " + (AdultTicket));
            Console.WriteLine("Child tickets sold = " + (ChildTicket));
            Console.WriteLine("Senior tickets sold = " + (SeniorTicket));
            Console.WriteLine();
            {
                if (AdultTicket <= ChildTicket + SeniorTicket)


                    Console.WriteLine("The competition is becoming a festival for everyone!");



                else if (ChildTicket >= SeniorTicket)
                    Console.WriteLine("The competition is attracting more and more young people!");


                else

                    Console.WriteLine("The competition should have more space for kids!");
            }
            Console.ReadLine();
        }

    }
}
