using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDamageForOscar
{
    internal abstract class WeaponDamage
    {
        private const int BaseDamage = 3;
        private const int FlameDamage = 2;
        private int roll;
        private bool flaming;
        private bool magic;

        public WeaponDamage(int Roll)
        {
            roll = Roll;
            magic = false;
            flaming = false;
        }

        //public decimal MagicMultipler = 1M;
        //public int FlamingDamage = 0;
        //public int Damage;

        protected abstract void CalculateDamage();
        /// <summary>
        /// Propertis to magic damage
        /// </summary>
        /// <remarks>
        /// Getter returns bool value is magic
        /// 
        /// Setter assigns new bool value to magic and calculate damage 
        /// </remarks>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();

            }
        }
        /// <summary>
        /// Propertis for flaming damage
        /// </summary>
        /// <remarks>
        /// Getter returns bool value is flaming
        /// 
        /// Setter assign new bool value to fire and calclate damage
        /// </remarks>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        /// <summary>
        /// Propertis returns damage
        /// </summary>
        /// <remarks>
        /// Getter renturns value fire damage 
        /// </remarks>
        public int Damage { get; protected set; }
        /// <summary>
        /// Propertis for sets new value of roll
        /// </summary>
        /// <remarks>
        /// Getter renturns value roll
        /// 
        /// Setter assign new value to roll and calclate damage
        /// </remarks>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
    }
}
