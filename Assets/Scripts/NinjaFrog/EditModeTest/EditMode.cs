using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class NinjaFrog
{
    private NinjaFrogStats stats;
    [SetUp]
    public void SetUp()
    {
        stats = new NinjaFrogStats(); 
    }

    [Test] 
    public void DefaultLives_ShouldBeThree()
    {
        Assert.AreEqual(3, stats.maxLives, "The default lives should be " + 3 + " but was " + stats.maxLives);
    }

    // Case Test for power and range
    [TestCase(true, 1, 1)]
    [TestCase(true, 2, 1)]
    [TestCase(false, 0, 1)]
    [TestCase(false, 1, 0)]
    [TestCase(true, 1, 0)]
    public void AttackPower_Cases(bool expected, int attackPower, int attackRange)
    {
        bool actual = stats.CanAttack(attackPower, attackRange);
        Assert.AreEqual(expected, actual, "The expected value should be " + expected + " but was " + actual);
    }
    
    // Battle test
    [TestCase(true, 1, 0)]
    [TestCase(true, 2, 1)]
    [TestCase(false, 1, 1)]
    [TestCase(false, 0, 0)]
    [TestCase(false, 0, 1)]
    public void BattleTest_Cases(bool expected, int powerAttacker, int powerDefender)
    {
        bool actual = stats.Battle(powerAttacker, powerDefender);
        Assert.AreEqual(expected, actual, "The expected value should be " + expected + " but was " + actual);
    }

    [TestCase(true, 1)]
    [TestCase(true, 2)]
    [TestCase(false, 0)]
    public void IsAlive_Cases(bool expected, int attackPower)
    {
        bool actual = stats.isAlive(attackPower);
        Assert.AreEqual(expected, actual, "The expected value should be " + expected + " but was " + actual);
    }
    
}
