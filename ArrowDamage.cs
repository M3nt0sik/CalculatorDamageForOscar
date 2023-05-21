using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsloleAppTOCalculationsDamageForOscar
{
    internal class ArrowDamage
    {
        private const decimal BaseMultiplier = 0.35M;
        private const decimal FlameDamage = 1.25M;
        private const decimal MagicMultiplier = 2.5M;
        private int roll;
        private bool flaming;
        private bool magic;
        /// <summary>
        /// Wczytuje do zmiennej roll wartosc rzutu kostką
        /// </summary>
        /// <param name="Roll">Liczba wyrzuconych oczek np 16</param>
        public ArrowDamage(int Roll)
        {
            roll = Roll;
            magic = false;
            flaming = false;
        }

        //public decimal MagicMultipler = 1M;
        //public int FlamingDamage = 0;
        //public int Damage;

        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BaseMultiplier;
            if (magic) baseDamage *= MagicMultiplier;
            if (flaming) Damage = (int)Math.Ceiling(baseDamage + FlameDamage);
            else Damage = (int)Math.Ceiling(baseDamage);
            
        }
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
        public int Damage { get; private set; }
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
