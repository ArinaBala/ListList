using System;
using System.Collections.Generic;
using System.Text;

namespace ListList
{
    internal class Tvarina
    {
        public string Name { get; set; }
        public ushort Age { get; set; }

        public Tvarina()
        {
            Name = string.Empty;
            Age = 0;
        }

        public Tvarina(string name, ushort age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}, Вік: {Age}";
        }
    }
}