﻿namespace OOStepByStep
{
    using System;
    public class Teacher : Person
    {

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            return base.Introduce() + " I am a teacher.";
        }
    }
}
