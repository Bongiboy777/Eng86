using NUnit.Framework;
using SafariPark;

namespace SafariParkTests
{
    public class PersonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("King", "Bong", "King Bong")]
        public void PersonConstructorTest(string fName, string lName, string fullNameExpected)
        {
            Person person = new Person(fName, lName, 20);

            Assert.AreEqual(person.GetFullName(), fullNameExpected);
        }

        [Test]
        public void AgeTest()
        {
            Person person = new Person("A", "L", 20);

            Assert.AreEqual(20, person.Age);
        }
    }

    public class VehicleTests
    {
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20,v.Position);
            Assert.AreEqual("Moving along 2 times.", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5,40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along.", result);
        }

        [TestCase(5,50)]
        [TestCase(3, 30)]
        [TestCase(2, 20)]
        [TestCase(50, 500)]
        [TestCase(543, 5430)]
        public void DefaultVehiclePositionMovesCorrectly(int times, int expextedPosition)
        {
            Vehicle v = new Vehicle();
            var result = v.Move(times);
            Assert.AreEqual(v.Position, expextedPosition);
            Assert.AreEqual($"Moving along {times} times.", result);
        }

        [TestCase(2,5,2)]
        [TestCase(10,8,8)]
        [TestCase(4,-5, 0)]
        public void VehicleAdheresToCapacityLimit(int capacity,int passengers ,int expectedNumOfPassengers)
        {
            Vehicle v = new Vehicle(capacity) {NumPassengers = passengers };
       
            Assert.AreEqual(v.NumPassengers, expectedNumOfPassengers);
        }

    }
}
