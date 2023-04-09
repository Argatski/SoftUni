using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.ComponentModel;

namespace PlanetWars.Tests
{
    public class Tests
    {
        [TestFixture]
        public class PlanetWarsTests
        {
            Planet planet = new Planet("Test", 100);
            Weapon weapon = new Weapon("Bam", 100, 150);

            [Test]
            public void Constructor_Should_SetCorectrly()
            {

                var expected = "Test";

                Assert.AreEqual(expected, planet.Name);
            }
            [Test]
            public void Constructor_ThrowsException_InvalidPLanetName()
            {
                Assert.Throws<ArgumentException>(() => new Planet(null, 150), $"Invalid planet name.");
            }
            [Test]
            public void Constructo_ThrowsException_InvalidBudget()
            {
                Assert.Throws<ArgumentException>(() => new Planet("Test", -1), "Budget cannot drop below ZerO!");
            }

            [Test]
            public void Constructor_Correctly_CreatesCollectionOfWepons()
            {
                Assert.That(planet.Weapons.Count, Is.EqualTo(0));
            }

            [Test]
            public void Construct_Correctly_CreatesNewWepons()
            {
                Assert.That(weapon.DestructionLevel, Is.EqualTo(150));
                Assert.That(weapon.Name, Is.EqualTo("Bam"));
                Assert.That(weapon.Price, Is.EqualTo(100));
            }

            [Test]
            public void AddWepon_WeponIsAddedToPlanetCollectionOfWepons()
            {
                Planet newPlanet = new Planet("Test2", 150);
                newPlanet.AddWeapon(weapon);

                Assert.That(newPlanet.Weapons.Count, Is.EqualTo(1));
            }

            [Test]
            public void AddWepon_AlreadyAddedWepon()
            {
                Planet newPlanet = new Planet("Test2", 150);
                newPlanet.AddWeapon(weapon);


                Assert.Throws<InvalidOperationException>(() => newPlanet.AddWeapon(weapon), $"There is already a {weapon.Name} weapon.");
            }

            [Test]
            public void DestructionLevel_DestructionLevelIsReturne()
            {
                Planet newPlanet = new Planet("Test2", 150);
                newPlanet.AddWeapon(weapon); //wepon destructionlevel is 150;

                Weapon weaponTwo = new Weapon("Nuc2", 9, 10);
                newPlanet.AddWeapon(weaponTwo);

                Assert.AreEqual(newPlanet.MilitaryPowerRatio, 160);
            }

            [Test]
            public void Profitl_BudgetIncreasesWithGivenAmount()
            {
                Planet newPlanet = new Planet("Test2", 150);
                newPlanet.Profit(33);

                Assert.That(newPlanet.Budget, Is.EqualTo(183));
                Assert.AreEqual(newPlanet.Budget, 183);
            }

            [Test]
            public void SpendFunds_BudgetDecreasesWithGivenAmount()
            {
                Planet newPlanet = new Planet("Test2", 150);
                newPlanet.SpendFunds(50);

                Assert.That(newPlanet.Budget, Is.EqualTo(100));
                Assert.AreEqual(newPlanet.Budget, 100);
            }
            [Test]
            public void SpendFunds_BudgetCannotDropBelowZero()
            {
                Planet newPlanet = new Planet("Test2", 150);

                Assert.Throws<InvalidOperationException>(() => newPlanet.SpendFunds(160), $"Not enough funds to finalize the deal.");
            }

            [Test]
            public void Weapon_IncreaseDestructionLevel_WorksProperly()
            {
                var weapon2 = new Weapon("Test-bum", 10, 10);
                weapon2.IncreaseDestructionLevel();

                Assert.That(weapon2.DestructionLevel, Is.EqualTo(11));
            }

            [Test]
            public void Weapon_IsNuclear_WorksProperly()
            {
                var weaponNuclear = new Weapon("Nuclear", 1500, 11);
                var weaponGun = new Weapon("Gun", 20, 2);

                Assert.That(weaponNuclear.IsNuclear, Is.EqualTo(true));
                Assert.That(weaponGun.IsNuclear, Is.EqualTo(false));
            }

            [Test]
            public void SellWeapon_WorksProperly()
            {
                Planet newPlanet = new Planet("Test2", 150);
                var weaponGun = new Weapon("Gun", 20, 2);

                newPlanet.AddWeapon(weaponGun);
                newPlanet.UpgradeWeapon("Gun");

                Assert.That(newPlanet.MilitaryPowerRatio, Is.EqualTo(3));
            }

            [Test]
            public void UpgradeWeapon_WeaponDoesNotExist()
            {
                Planet newPlanet = new Planet("Test2", 150);

                Assert.Throws<InvalidOperationException>(() => newPlanet.UpgradeWeapon("NotAddWepon"), $"NotAddWepon does not exist in the weapon repository of {planet.Name}");
            }

            [Test]
            public void DestructOpponent_Throws_IfOpponentIsTooStrong()
            {
                var planetOne = new Planet("PlanetOne", 1500);
                var planetTwo = new Planet("PlanetTwo", 2000);

                var weaponOne = new Weapon("WeaponOne", 20, 2);
                var weaponTwo = new Weapon("WeaponTwo", 30, 5);
                var weaponThree = new Weapon("WeaponThree", 20, 2);

                planetOne.AddWeapon(weaponOne);
                planetOne.AddWeapon(weaponThree);
                planetTwo.AddWeapon(weaponTwo);

                Assert.Throws<InvalidOperationException>(() => planetOne.DestructOpponent(planetTwo), $"{planetTwo.Name} is too strong to declare war to!");
            }

            [Test]
            public void DestructOpponent_WorksProperly()
            {
                var planetOne = new Planet("PlanetOne", 1500);
                var planetTwo = new Planet("PlanetTwo", 2000);

                var weaponOne = new Weapon("WeaponOne", 20, 2);
                var weaponTwo = new Weapon("WeaponTwo", 30, 5);
                var weaponThree = new Weapon("WeaponThree", 20, 4);

                planetOne.AddWeapon(weaponOne);
                planetOne.AddWeapon(weaponThree);
                planetTwo.AddWeapon(weaponTwo);

                var expectedResult = $"{planetTwo.Name} is destructed!";

                Assert.That(planetOne.DestructOpponent(planetTwo), Is.EqualTo(expectedResult));
            }

            [Test]
            public void Weapon_PriceCannotBeNagative()
            {
                Assert.Throws<ArgumentException>(() => new Weapon("Weapon", -5, 8), "Price can not be negative.");
            }

            [Test]
            public void Weapon_RemoveWorkCorrectly()
            {
                var planetOne = new Planet("PlanetOne", 1500);
                var weaponOne = new Weapon("WeaponOne", 20, 2);
                var weaponThree = new Weapon("WeaponThree", 20, 4);

                planetOne.AddWeapon(weaponOne);
                planetOne.AddWeapon(weaponThree);

                planetOne.RemoveWeapon("WeaponOne");

                Assert.AreEqual(planetOne.Weapons.Count, 1);
            }

        }
    }
}
