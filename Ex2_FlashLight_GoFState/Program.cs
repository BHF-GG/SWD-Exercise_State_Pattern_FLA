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
            IFlashLight flash = new FlashLight();
            var choice = 'B';


            while (char.ToUpper(choice) != 'Q')
            {
                Console.WriteLine("Press <P> for Power");
                Console.WriteLine("Press <M> for Mode");

                choice = Console.ReadKey().KeyChar;

                switch (char.ToUpper(choice))
                {
                    case 'P':
                        flash.Power();
                        break;

                    case 'M':
                        flash.Mode();
                        break;
                }
            }
        }
    }
}
