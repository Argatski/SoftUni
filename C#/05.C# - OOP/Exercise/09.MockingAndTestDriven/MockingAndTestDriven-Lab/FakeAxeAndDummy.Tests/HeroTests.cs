using FakeAxeAndDummy.Contracts;
using FakeAxeAndDummy.Tests.FakeTesters;
using Moq;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    private const string HeroName = "Pesho";
    [Test]
    public void GivenHero_WhenAttackedTargetDies_ThenHeroReceivesExperience()
    {
        //Arrage
        ITarget target = new FakeTarget();
        IWeapon weapon = new FakeWeapon();

        //Action
        Hero hero = new Hero(HeroName, weapon);
        hero.Attack(target);

        //Assert
        Assert.AreEqual(20, hero.Experience);
    }
    //Withe automatic Fake Object
    [Test]
    public void GivenHero_WhenAttackedTargetDies_ThenHeroReceivesExperienceWithMoq()
    {
        //Arrage
        Mock<ITarget> fakeTarget = new Mock<ITarget>();
        fakeTarget.Setup(f => f.GiveExperience()).Returns(20);
        fakeTarget.Setup(f => f.IsDead()).Returns(true);

        Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
        //Action
        Hero hero = new Hero(HeroName, fakeWeapon.Object);

        hero.Attack(fakeTarget.Object);

        //Assert
        Assert.AreEqual(hero.Experience, 20);

    }
}