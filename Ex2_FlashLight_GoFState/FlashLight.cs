using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_FlashLight_GoFState
{
    public class FlashLight
    {
        private FlashLightState On = new OnState();
        private FlashLightState Off = new OffState();

        private FlashLightState _currentState = new OffState();

        public void Power()
        {
            _currentState.HandlePower(this);
        }

        public void LightOn()
        {
            Console.WriteLine("Light on");
        }

        public void LightOff()
        {
            Console.WriteLine("Light off");
        }

        public void SetState(FlashLightState s)
        {
            _currentState = s;
        }

        
    }

}
