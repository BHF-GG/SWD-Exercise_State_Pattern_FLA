using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_FlashLight_GoFState
{
    internal interface IStateFlashLight
    {
        void SetState(FlashLightState newState);
        void LightOn();
        void LightOff();
        void SolidLeds();
        void FlashLeds();
    }

    internal interface IFlashLight
    {
        void Power();
        void Mode();
    }

    class FlashLight : IStateFlashLight, IFlashLight
    {

        private FlashLightState _currentState;

        public FlashLight()
        {
            SetState(new OffState());
        }

        public void SetState(FlashLightState newState)
        {
            // ==================================
            // FOR DEBUG ONLY!!!
            Console.WriteLine("State: {0} --> {1}", _currentState != null ? _currentState.GetType().Name : "", newState.GetType().Name);
            // ==================================


            _currentState = newState;
            _currentState.OnEnter(this);
        }

        // From IFlashLight
        public void Mode()
        {
            _currentState.HandleMode(this);
        }

        public void Power()
        {
            _currentState.HandlePower(this);
        }

        //From IStateFlashLight

        public void LightOn()
        {}

        public void LightOff()
        {}


        public void SolidLeds()
        {}

        public void FlashLeds()
        {}



    }

}
