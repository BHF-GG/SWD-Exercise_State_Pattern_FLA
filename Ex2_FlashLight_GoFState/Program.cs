using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_FlashLight_GoFState
{
    class Program
    {
        static void Main(string[] args)
        {
            FlashLight flash = new FlashLight();

            Console.WriteLine("Press <B> for Button");

            while(true)
            {
                if(Console.ReadKey().Key == ConsoleKey.B)
                    Console.WriteLine();
                    flash.Power(); 
            }
        }
    }
}
