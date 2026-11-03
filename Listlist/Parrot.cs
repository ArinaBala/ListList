using System;
using System.Collections.Generic;
using System.Text;

namespace ListList
{
    internal class Parrot : Tvarina
    {
        public bool CanTalk { get; set; }

        public Parrot() : base()
        {
            CanTalk = false;
        }

        public Parrot(string name, ushort age, bool canTalk) : base(name, age)
        {
            CanTalk = canTalk;
        }

        public override string ToString()
        {
            string talkStatus = CanTalk ? "Розмовляє" : "Німий";
            return $"Папуга: {base.ToString()}, Сказала: {talkStatus}";
        }
    }
}
