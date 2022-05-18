using Lab4;
using System;
using System.Text;
using System.Threading.Tasks;


namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tМiкрохвильовка:");
            Microwave mw = new Microwave(2.5);
            mw.TurnOn();
            Console.WriteLine(mw.GetInfo());
            mw.ReplaceTo("Горище");
            mw.TurnOff();
            Console.WriteLine(mw.GetInfo() + "\n");

            Console.WriteLine("\tВилка:");
            Fork fr = new Fork(0.1);
            Console.WriteLine(fr.GetInfo());
            fr.Eat();
            fr.ReplaceTo("Вiтальня");
            Console.WriteLine(fr.GetInfo() + "\n");

            Console.WriteLine("\tТарiлка:");
            Plate pl = new Plate(0.3);
            Console.WriteLine(fr.GetInfo());
            fr.Eat();
            fr.ReplaceTo("Вiтальня");
            Console.WriteLine(fr.GetInfo() + "\n");

            Kitchen kitchen = new Kitchen();
            kitchen.add(new Microwave(2.5));
            kitchen.add(new Plate(0.3));
            kitchen.add(new Fork(0.1));

            Console.WriteLine("Загальна вага приладiв: " + kitchen.getTotalWeight() +" кг");

        }
    }
}