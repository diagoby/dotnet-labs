using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4.lib;

namespace Lab4Tests
{
    [TestClass]
    public class LinkedSetTest
    {
        [TestMethod]
        public void LinkedSet_ShouldInitializeSetWithProvidedValues()
        {
            // Using contructor
            LinkedSet<int> set1 = new LinkedSet<int>(new int[] { 1, 2, 2, 3 });

            // Using static method
            LinkedSet<int> set2 = LinkedSet<int>.Of(new int[] { 1, 2, 3, 3 });

            LinkedSet<int> set3 = new LinkedSet<int>();

            set3.Add(1);
            set3.Add(2);
            set3.Add(3);

            Assert.AreEqual(set1, set3);
            Assert.AreEqual(set2, set3);
        }

        [TestMethod]
        public void LinkedSet_ShouldAddAnItem_IgnoringDuplicatesAndNulls()
        {
            LinkedSet<string> set = new LinkedSet<string>();

            Assert.IsTrue(set.Add("Test"));
            Assert.IsFalse(set.Add("Test"));
            Assert.IsFalse(set.Add(null));
            Assert.AreEqual(set, new LinkedSet<string>(new string[] { "Test" }));
        }

        [TestMethod]
        public void LinkedSet_ShouldAddMultipleItems_IgnoringDuplicatesAndNulls()
        {
            LinkedSet<string> set = new LinkedSet<string>(
                new string[] { "Test1", "Test2" }
            );

            Assert.IsFalse(set.AddAll(new string[] { "Test1", "Test2", null }));
            Assert.IsTrue(set.AddAll(new string[] { "Test1", "Test2", "Test3" }));

            Assert.AreEqual(set, new LinkedSet<string>(
                new string[] { "Test1", "Test2", "Test3" })
            );
        }

        [TestMethod]
        public void LinkedSet_ShouldRemoveAnItemOnce_IgnoringNulls()
        {
            LinkedSet<string> set = new LinkedSet<string>();

            set.Add("Test1");
            set.Add("Test2");

            Assert.IsTrue(set.Remove("Test1"));
            Assert.IsFalse(set.Remove("Test1"));
            Assert.IsFalse(set.Remove(null));
            Assert.AreEqual(set, new LinkedSet<string>(new string[] { "Test2" }));
        }

        [TestMethod]
        public void LinkedSet_ShouldUpdateCountWhenModifying()
        {
            LinkedSet<string> set = new LinkedSet<string>();

            // Initial count
            Assert.AreEqual(set.Count, 0);

            set.Add("Test1");
            Assert.AreEqual(set.Count, 1);

            // Add one duplicate
            set.AddAll(new string[] { "Test1", "Test2" });
            Assert.AreEqual(set.Count, 2);

            // Remove non existing
            set.Remove("Test3");
            Assert.AreEqual(set.Count, 2);

            set.Remove("Test2");
            Assert.AreEqual(set.Count, 1);

            set.Clear();
            Assert.AreEqual(set.Count, 0);
        }

        [TestMethod]
        public void LinkedSet_ShouldUpdateIsSingletonSetWhenModifying()
        {
            LinkedSet<string> set = new LinkedSet<string>();

            // Initial empty state
            Assert.IsFalse(set.IsSingleTonSet);

            set.Add("Test1");
            Assert.IsTrue(set.IsSingleTonSet);

            set.Add("Test2");
            Assert.IsFalse(set.IsSingleTonSet);

            set.Remove("Test2");
            Assert.IsTrue(set.IsSingleTonSet);

            set.Clear();
            Assert.IsFalse(set.IsSingleTonSet);
        }

        [TestMethod]
        public void LinkedSet_ShouldContainDesiredValue_IgnoringNulls()
        {
            LinkedSet<string> set = new LinkedSet<string>(
                new string[] { "Test1", "Test2" }
            );

            Assert.IsTrue(set.Contains("Test1"));
            Assert.IsFalse(set.Contains("TEST3"));
            Assert.IsFalse(set.Contains(null));
        }

        [TestMethod]
        public void LinkedSet_ShouldBeEmptyOnClear()
        {
            LinkedSet<int> set = new LinkedSet<int>(new int[] { 1, 2 });
            set.Clear();
            Assert.IsTrue(set.Count == 0);
        }

        [TestMethod]
        public void LinkedSet_ShouldCreateSetCopy()
        {
            LinkedSet<int> set = new LinkedSet<int>(new int[] { 1, 2 });

            object clone = set.Clone();
            LinkedSet<int> setClone = (LinkedSet<int>) clone;

            Assert.IsNotNull(clone);
            Assert.AreEqual(set, setClone);
        }

        [TestMethod]
        public void LinkedSet_ShouldBeEqual_IgnoringNulls()
        {
            LinkedSet<int> set1 = new LinkedSet<int>(new int[] { 1, 2 });
            LinkedSet<int> set2 = new LinkedSet<int>(new int[] { 1, 2, 2 });

            Assert.IsTrue(set1.Equals(set2));
            Assert.IsTrue(set2.Equals(set1));

            set2.Remove(2);
            Assert.IsFalse(set1.Equals(set2));

            set2.Clear();
            Assert.IsFalse(set1.Equals(set2));

            set2 = null;
            Assert.IsFalse(set1.Equals(set2));
        }

        [TestMethod]
        public void LinkedSet_ShouldFindAnItem_IgnoringNulls()
        {
            Car car = new Car() { Name = "Audi", Year = 2013, Color = "Grey" };

            LinkedSet<Car> cars = new LinkedSet<Car>(new Car[] { car });
            Car foundCar = cars.Find(car);

            Assert.IsNotNull(foundCar);
            Assert.AreEqual(car, foundCar);
        }

        [TestMethod]
        public void LinkedSet_ShouldMakeSetsUnion()
        {
            LinkedSet<int> set1 = new LinkedSet<int>(new int[] { 1, 2, 3 });
            LinkedSet<int> set2 = new LinkedSet<int>(new int[] { 2, 3, 4, 5 });
            LinkedSet<int> resultSet = new LinkedSet<int>(new int[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(resultSet, set1 + set2);
        }

        [TestMethod]
        public void LinkedSet_ShouldMakeSetsIntersection()
        {
            LinkedSet<int> set1 = new LinkedSet<int>(new int[] { 1, 2, 3 });
            LinkedSet<int> set2 = new LinkedSet<int>(new int[] { 2, 3, 4, 5 });
            LinkedSet<int> resultSet = new LinkedSet<int>(new int[] { 2, 3 });

            Assert.AreEqual(resultSet, set2 * set1);
        }

        [TestMethod]
        public void LinkedSet_ShouldMakeSetsDifference()
        {
            LinkedSet<int> set1 = new LinkedSet<int>(new int[] { 1, 2, 3 });
            LinkedSet<int> set2 = new LinkedSet<int>(new int[] { 2, 3, 4, 5 });
            LinkedSet<int> resultSet = new LinkedSet<int>(new int[] { 1 });

            Assert.AreEqual(resultSet, set1 - set2);
        }

        [TestMethod]
        public void LinkedSet_ShouldCopySetToAnArrayAtIndex()
        {
            Car car1 = new Car() { Name = "Audi", Year = 2013, Color = "Grey" };
            Car car2 = new Car() { Name = "Honda", Year = 2010, Color = "Red" };
            Car car3 = new Car() { Name = "Ford", Year = 2015, Color = "White" };

            Car[] carsArr = new Car[5];
            carsArr[0] = car1;

            LinkedSet<Car> carsSet = new LinkedSet<Car>(new Car[] { car2, car3 });
            carsSet.CopyTo(carsArr, 2);

            CollectionAssert.AreEqual(carsArr, new Car[5] { car1, null, car3, car2, null });
        }
    }
}
