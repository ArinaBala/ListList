using System;
using System.Collections.Generic;
using System.Text;

namespace ListList
{
    internal class Cat : Tvarina
    {
        public bool IsHomeCat { get; set; }

        public Cat() : base()
        {
            IsHomeCat = true;
        }

        public Cat(string name, ushort age, bool isHomeCat) : base(name, age)
        {
            IsHomeCat = isHomeCat;
        }

        public override string ToString()
        {
            string status = IsHomeCat ? "Домашній" : "Дикар";
            return $"Кіт: {base.ToString()}, Статус: {status}";
        }
    }
}
