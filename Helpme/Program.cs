using System;
namespace Helpme
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är din favorit bok");
            String Boknamn = Console.ReadLine();

            Console.WriteLine("Det här är din favorit bok" + " " + Boknamn);

            Console.ReadKey();
        }
    }
}

