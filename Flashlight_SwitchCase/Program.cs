using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashlight_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            FlashLight flash = new FlashLight();
            
            flash.HandleEvent(FlashLight.FlashLightEvent.PowerBtnPressed);
            flash.HandleEvent(FlashLight.FlashLightEvent.PowerBtnPressed);
            flash.HandleEvent(FlashLight.FlashLightEvent.PowerBtnPressed);
            flash.HandleEvent(FlashLight.FlashLightEvent.PowerBtnPressed);
            flash.HandleEvent(FlashLight.FlashLightEvent.PowerBtnPressed);
        }
    }
}
