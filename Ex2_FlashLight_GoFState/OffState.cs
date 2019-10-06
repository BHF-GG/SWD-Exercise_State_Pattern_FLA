using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_FlashLight_GoFState
{
    public class OffState : FlashLightState
    {
        public override void HandlePower(FlashLight context)
        {
            context.LightOn();
            context.SetState(new OnState());
        }
    }
}
