using System;
using System.IO;

namespace Learning___176
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {

                    Calc();
                    Console.WriteLine("Jesli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk:");
                    string end = Console.ReadLine();
                    if (end == "Tak" || end == "tak" || end == "tAk" || end == "tAk")
                    {
                        break;
                    }
                    Console.Clear();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
          
            }

        }

        private static void Calc()
        {
            Console.WriteLine("Wprowadź ilość wydatków w tym miesiącu: ");
            int number = int.Parse(Console.ReadLine());
            decimal[] wydatki = new decimal[number];
            decimal sum = 0;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Wprwoadź wydatek nr {i + 1}: ");
                wydatki[i] = decimal.Parse(Console.ReadLine());

                sum += wydatki[i];
            }

            Console.WriteLine($"Suma twoich wydatków to {sum.ToString("c")}.");
            StreamWriter inpudDate = File.CreateText("Numbers.text");
            inpudDate.WriteLine($"Suma twoich wydatków to {sum.ToString("c")}.");
            inpudDate.Close();

            decimal max = wydatki[0];
            decimal min = wydatki[0];
            foreach (var item in wydatki)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"Twoje najwięszky wydatek to {max.ToString("c")}.");
            Console.WriteLine($"Twoje najmniejszy wydatek to {min.ToString("c")}.");
        }
    }
}
