﻿namespace DesignPatterns.StructuralPattern.Decorator.Object
{
    public class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Italian pizza")
        {
        }

        public override int GetCost()
        {
            return 10;
        }
    }
}