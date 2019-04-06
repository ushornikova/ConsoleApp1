using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cat
    {
        //??? 7. Параметр для зчитування для всіх(public) та запису(private) Energy типу double. - Цього не зробила
        public string name { get; } //параметр тільки для зчитування Name типу string.
        private double enegry { get; set; } //Приватне поле _energy типу double. Параметр Energy має записувати і зчитувати значення з цього поля.
        public static readonly double maxEnergy = 20; //Публічне статичне readonly поле MaxEnergy типу double зі значенням 20.
        public static readonly double minEnergy = 0; //Публічне статичне readonly поле MinEnergy типу double зі значенням 0.
        public static readonly double sleepEnergyGain = 10; //Публічне статичне readonly поле SleepEnergyGain типу double зі значенням 10.
        public static readonly double jumpEnergyDrain = 0.5; //Публічне статичне readonly поле JumpEnergyDrain типу double зі значенням 0.5.

        public Cat(string catName)
        {
            string name = catName; //Конструктор, який приймає  аргумент name  
            enegry = maxEnergy; // Також конструктор повинен записати в параметр Energy значення MaxEnergy.
        }

        public double Jump()
        {
            enegry = enegry - jumpEnergyDrain; //Метод Jump() без параметрів типу void, який зменшує Energy на JumpEnergyDrain.
            return enegry;
        }

        public double Sleep ()
        {
            enegry = enegry + sleepEnergyGain; //Метод Sleep() без параметрів типу void, який збільшує Energy на SleepEnergyGain.
            return enegry;
        }
    }
}
