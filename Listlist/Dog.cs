using System;
using System.Collections.Generic;
using System.Text;

namespace ListList
{
    internal class Pug : Tvarina
    {
        public string Breed { get; set; }

        public Pug() : base()
        {
            Breed = string.Empty;
        }

        public Pug(string name, ushort age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        public override string ToString()
        {
            return $"Собака: {base.ToString()}, Порода: {Breed}";
        }
    }
}
