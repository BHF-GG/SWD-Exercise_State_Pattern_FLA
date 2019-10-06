using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_FlashLight_GoFState
{
    public abstract class FlashLightState
    {
       public abstract void HandlePower(FlashLight context);
    }
}
