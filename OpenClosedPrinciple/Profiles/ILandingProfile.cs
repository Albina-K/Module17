using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Profiles
{
    /// <summary>
    /// общий интерфейс для профилей посадки
    /// </summary>
    interface ILandingProfile
    {
        void Execute();
    }
}
