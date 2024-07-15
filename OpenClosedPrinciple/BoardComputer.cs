using OpenClosedPrinciple.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class BoardComputer
    {
        /// <summary>
        /// запускаем посадку
        /// загружаем профиль в виде аргумента
        /// </summary>
        public void PerformLanding(ILandingProfile landingProfile)
        {
            landingProfile.Execute();
        }
    }
}
