using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_FlashLight_GoFState
{
    class FlashLightState
    {
        public virtual void OnEnter(IStateFlashLight context) { }
        public virtual void HandlePower(IStateFlashLight context) { }
        public virtual void HandleMode(IStateFlashLight context) { }

    }

    class OffState : FlashLightState
    {
        public override void HandlePower(IStateFlashLight context)
        {
            context.LightOn();
            context.SetState(new SolidState());
        }
    }

    class OnState : FlashLightState
    {
        public override void OnEnter(IStateFlashLight context)
        {
            context.SetState(new SolidState());
        }

        public override void HandlePower(IStateFlashLight context)
        {
            context.LightOff();
            context.SetState(new OffState());
        }
    }

    class SolidState : OnState
    {
        public override void OnEnter(IStateFlashLight context) { }

        public override void HandleMode(IStateFlashLight context)
        {
            context.FlashLeds();
            context.SetState(new FlashingState());
        }
    }

    class FlashingState : OnState
    {
        public override void OnEnter(IStateFlashLight context) { }

        public override void HandleMode(IStateFlashLight context)
        {
            context.SolidLeds();
            context.SetState(new SolidState());
        }
    }
}
