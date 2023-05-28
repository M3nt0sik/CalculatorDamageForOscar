using CalculatorDamageForOscar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsloleAppTOCalculationsDamageForOscar
{
    internal class ArrowDamage: WeaponDamage
    {
        private const decimal BaseMultiplier = 0.35M;
        private const decimal FlameDamage = 1.25M;
        private const decimal MagicMultiplier = 2.5M;
        
        /// <summary>
        /// Wczytuje do zmiennej roll wartosc rzutu kostką
        /// </summary>
        /// <param name="Roll">Liczba wyrzuconych oczek np 16</param>
        public ArrowDamage(int Roll):base(Roll){     }

        //public decimal MagicMultipler = 1M;
        //public int FlamingDamage = 0;
        //public int Damage;

        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BaseMultiplier;
            if (Magic) baseDamage *= MagicMultiplier;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FlameDamage);
            else Damage = (int)Math.Ceiling(baseDamage);
            
        }
       
    }

}
