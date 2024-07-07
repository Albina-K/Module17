using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;

namespace AbstractFactoryRealExample.Factories
{
    /// <summary>
    /// у нас есть фабрика по производству драконов
    /// дейнерис нервно курит в сторонке
    /// </summary>
    class DragonFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new FlyMovement();
        }
        public IWeapon CreateWeapon()
        {
            return new FireBreath();
        }
    }    
}
