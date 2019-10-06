using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashlight_SwitchCase
{
    class FlashLight
    {
        public enum FlashLightEvent { PowerBtnPressed }
        enum FlashLightState { On, Off }
        private FlashLightState _currentState;
        public FlashLight()
        {
            _currentState = FlashLightState.Off;
        }
        public void HandleEvent(FlashLightEvent evt)
        {
            switch (_currentState)
            {
                case FlashLightState.On:
                    _currentState = FlashLightState.Off;
                    Console.WriteLine("Flaslight off");
                    break;
                case FlashLightState.Off:
                    _currentState = FlashLightState.On;
                    Console.WriteLine("Flaslight on");
                    break;

            }
        }
    }
}
