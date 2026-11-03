using System;
using System.Collections.Generic;
using System.Text;

namespace ListList
{
    internal class Zoopark
    {
        public string Title { get; set; }
        public List<Tvarina> Animals = new List<Tvarina>();

        public Zoopark()
        {
            Title = string.Empty;
        }

        public Zoopark(string title, List<Tvarina> animals)
        {
            Title = title;
            Animals = animals;
        }

        public void AddAnimal(Tvarina animal)
        {
            Animals.Add(animal);
        }

        public void RemoveOlderThan(ushort ageLimit)
        {
            Animals.RemoveAll(animal => animal.Age > ageLimit);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Зоопарк: \"{Title}\".\nСписок тварин:\n");
            foreach (Tvarina animal in Animals)
            {
                sb.Append(animal + "\n");
            }
            return sb.ToString();
        }
    }
}
