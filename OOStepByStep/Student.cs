﻿namespace OOStepByStep
{
    using System;
    public class Student : Person
    {

        public Student(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            return base.Introduce() + " I am a student.";
        }
    }
}
