using AbstractFactoryRealExample.Factories;
using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample
{
    /// <summary>
    /// класс монстар
    /// </summary>
    class Monster
    {
        private IWeapon _weapon;
        private IMovement _movement;

        ///<summary>
        ///метод-конструктор, где создаются объекты при помощи фабрики
        /// </summary>
        public Monster(IMonsterFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
        }
        public void Move()
        {
            _movement.Start();
        }
        public void Hit()
        {
            _weapon.Attack();
        }
    }
}
