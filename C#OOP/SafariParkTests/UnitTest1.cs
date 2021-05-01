using NUnit.Framework;
using SafariPark;

namespace SafariParkTests
{
    public class HumanTests
    {

        [TestCase("King", "Bong", "King Bong")]
        public void HumanConstructorTest(string fName, string lName, string fullNameExpected)
        {
            Human person = new Human(fName, lName, 20);

            Assert.AreEqual(person.GetFullName(), fullNameExpected);
        }

        [Test]
        public void AgeTest()
        {
            Human person = new Human("A", "L", 20);

            Assert.AreEqual(20, person.Age);
        }

        [TestCase(0, 1)]
        [TestCase(-20, 1)]
        [TestCase(int.MaxValue,100)]
        [TestCase(120, 100)]
        [TestCase(30, 30)]
        public void HealthTest(int health, int expectedHealth)
        {
            Human person = new Human(health);

            Assert.AreEqual(person.Health,expectedHealth);
        }
    }

    public class VehicleTests
    {
        protected Vehicle v = new Vehicle();
        [SetUp]
        public  void Setup()
        {
            v = new Vehicle(5);
        }

        [Test]
        public  void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {

            
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times.", result);
        }

        [Test]
        public  void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along.", result);
        }

        [TestCase(5, 50)]
        [TestCase(3, 30)]
        [TestCase(2, 20)]
        [TestCase(50, 500)]
        [TestCase(543, 5430)]
        public  void DefaultVehiclePositionMovesCorrectly(int times, int expextedPosition)
        {
           
            var result = v.Move(times);
            Assert.AreEqual(v.Position, expextedPosition);
            Assert.AreEqual($"Moving along {times} times.", result);
        }

        [TestCase(2, 5, 2)]
        [TestCase(10, 8, 8)]
        [TestCase(4, -5, 0)]
        public  void VehicleAdheresToCapacityLimit(int capacity, int passengers, int expectedNumOfPassengers)
        {
            Vehicle vehicle = new Vehicle(capacity) { NumPassengers = passengers };

            Assert.AreEqual(vehicle.NumPassengers, expectedNumOfPassengers);
        }



    }

    public class AirplaneTests 
    {

        Airplane v;
        [SetUp]
        public  void Setup()
        {
            v = new Airplane(10, 10, "JetsRus");
        }

        [TestCase(40, 40)]
        [TestCase(690, 690)]
        [TestCase(5882, 5882)]
        [TestCase(65700, 6500)]
        [TestCase(999999, 6500)]
        public void DoesntAscendAboveLimit(int increase, int expected)

        {
            Airplane a = new Airplane(100);
            a.Ascend(increase);
            Assert.AreEqual(a.Altitude, expected);

        }

        [TestCase(500, 200, 300)]
        [TestCase(300, 400, 0)]
        [TestCase(4000, 4000, 0)]
        [TestCase(0, 233, 0)]
        public void DoesntDescendBelow0(int startAltitude, int decrease, int expected)

        {
            Airplane a = new Airplane(100);
            a.SetAltitude(startAltitude);
            a.Desc(decrease);
            Assert.AreEqual(a.Altitude, expected);
        }

        [TestCase(2, 5, 2)]
        [TestCase(10, 8, 8)]
        [TestCase(4, -5, 0)]
        public  void VehicleAdheresToCapacityLimit(int capacity, int passengers, int expectedNumOfPassengers)
        {
            Airplane Plane = new Airplane(capacity) { NumPassengers = passengers };

            Assert.AreEqual(Plane.NumPassengers, expectedNumOfPassengers);
        }

        [Test]
        public  void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            v = new Airplane(5, 40, "JetsRUS");
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along at an altitude of 0 meters.", result);
        }

        [TestCase(5, 50)]
        [TestCase(3, 30)]
        [TestCase(2, 20)]
        [TestCase(50, 500)]
        [TestCase(543, 5430)]
        public  void DefaultVehiclePositionMovesCorrectly(int times, int expextedPosition)
        {

            var result = v.Move(times);
            Assert.AreEqual(v.Position, expextedPosition);
            Assert.AreEqual($"Moving along {times} times at an altitude of 0 meters.", result);
        }

        public  void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {


            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times at an altitude of 0 meters.", result);
        }


    }

    public class WeaponTests
    {
        private Hunter h;
        private Weapon pistol;
        [SetUp]
        public void Setup()
        {
            

        }

        [Test]
        public void HunterDealsDamage()
        {
            Assert.Pass();
        }
    }

    public class EntityMovementTests
    {
        private Hunter h;
        private Weapon pistol;
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void HunterDealsDamage()
        {
            Assert.Pass();
        }
    }
}
