using System;

namespace Lab4
{
    class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Car car &&
                   Name == car.Name &&
                   Year == car.Year &&
                   Color == car.Color;
        }

        public override string ToString()
        {
            return $"{Color} {Name} of {Year}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(HashCode.Combine(Name, Color), Year);
        }
    }
}
