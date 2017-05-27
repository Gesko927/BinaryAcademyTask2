﻿namespace BSA17_CSharp_Task2.AnimalFactory.Animals
{
    public class Fox:Animal
    {
        public Fox(string name, int maxHealth) : base(name, maxHealth)
        {
        }

        public override string ToString()
        {
            return GetType().Name + base.ToString();
        }
    }
}