using CalculatorDamageForOscar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsloleAppTOCalculationsDamageForOscar
{
    internal class SwordDamage : WeaponDamage
    {
        private const int BaseDamage = 3;
        private const int FlameDamage = 2;

        /// <summary>
        /// Wczytuje do zmiennej roll wartosc rzutu kostką
        /// </summary>
        /// <param name="Roll">Liczba wyrzuconych oczek np 16</param>
        public SwordDamage(int Roll) : base(Roll) { }


        //public decimal MagicMultipler = 1M;
        //public int FlamingDamage = 0;
        //public int Damage;

        protected override void CalculateDamage()
        {
            decimal magicMultipler = 1M;
            if (Magic) magicMultipler = 1.75M;
            Damage = (int)(this.Roll * magicMultipler) + BaseDamage;
            if (Flaming) Damage += FlameDamage;
        }
        
    
    }

}
