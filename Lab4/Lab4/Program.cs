using System;
using Lab4.lib;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedSet<int> set1 = new LinkedSet<int>(new[] { 2, 3, 4 });
            LinkedSet<int> set2 = LinkedSet<int>.Of(new[] { 2, 3, 4 });

            Console.WriteLine(set1.Equals(set2));

            //LinkedSet<int> set1 = new LinkedSet<int>(new[] { 2, 3, 4 });
            //LinkedSet<int> clone = (LinkedSet<int>)set1.Clone();

            //Console.WriteLine(set1.Equals(clone));

            //LinkedSet<int> set1 = new LinkedSet<int>(new[] { 2, 3, 4 });
            //LinkedSet<int> set2 = LinkedSet<int>.Of(new[] { 2, 3 });
            //LinkedSet<int> set3 = new LinkedSet<int>(new[] { -1 });

            //bool modified = set3.AddAll(new[] { -1 });

            //int[] arr = new int[5];
            //set1.CopyTo(arr, -5);

            //Console.WriteLine(string.Join(", ", arr));

            //set2.Add(4);

            //Console.WriteLine($"{set1.GetHashCode()},\n{set2.GetHashCode()}");
            //Console.WriteLine(set1 - set2);

            //Cars();
        }

        static void Cars()
        {
            Car audi = new Car() { Name = "Audi", Year = 2013, Color = "Grey" };
            Car audi2 = new Car() { Name = "Audi", Year = 2013, Color = "Grey" };
            Car honda = new Car() { Name = "Honda", Year = 2010, Color = "Red" };

            LinkedSet<Car> cars = new LinkedSet<Car>(new Car[] { audi, honda, null });
            LinkedSet<Car> cars2 = new LinkedSet<Car>(new Car[] { audi2, honda });

            //LinkedSet<Car> cars = new LinkedSet<Car>(new Car[] { audi, honda });
            //LinkedSet<Car> clone = (LinkedSet<Car>) cars.Clone();
            //clone.Remove(audi);
            //clone.Add(audi);

            Console.WriteLine(cars + cars2);
            Console.WriteLine(cars.Equals(cars2));
        }
    }
}
