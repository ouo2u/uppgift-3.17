using System;
namespace Uppgift_3._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett hel tal");
            float heltal = float.Parse(Console.ReadLine());
            Console.WriteLine("skriv ett annat hel tal");
            float andratal = float.Parse(Console.ReadLine());
            Console.WriteLine("välj vad som ska hända med de");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. subtratktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            String kategori= Console.ReadLine();
            string rättSvar = "";

            switch (kategori)

            {
                case "1":
                    Console.WriteLine("summan blir " + (heltal + andratal));
                    break;
            
                case "2":
                    Console.WriteLine("sutraktionen blir " + (heltal - andratal));
                break;
                case "3":
                    Console.WriteLine("sutraktionen blir " + (heltal * andratal));
                    break;
                case "4":
                    Console.WriteLine("sutraktionen blir " + (heltal / andratal));
                    break;
            }
        }
    }
}
