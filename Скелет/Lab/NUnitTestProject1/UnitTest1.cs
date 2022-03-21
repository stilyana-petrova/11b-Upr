using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        //AxeTests
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }
        [Test]
        public void BrokenAxeCantAttack()
        {
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);

            //Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }

        //DummyTests
        [Test]
        public void DummyLosesHealthIfItsAttacked()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(0, dummy.Health, "Dummy is dead.");
        }
        [Test]
        public void DeadDummyThrowsExceptionIfItsAttacked()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 1);

            axe.Attack(dummy);

            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }
        [Test]
        public void DeadDummyCanGiveXP()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 1);

            axe.Attack(dummy);

            dummy.GiveExperience();
        }
        [Test]
        public void AliveDummyCantGiveXP()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(20, 20);

            axe.Attack(dummy);

            dummy.TakeAttack(10);
        }
    }
}