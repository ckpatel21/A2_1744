using A2_Final1744;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CircleTestCase
{

    [TestFixture]
    public class CircleTest
    {
        //Test Cases for Get Circumference method
        [Test]
        public void validateGetCircumferenceWithDefaultValue()
        {
            //Arrange
            Circle circle = new Circle();
            circle.GetRadius();
            //Act
            double actual = circle.GetCircumference();
            //Assert
            Assert.AreEqual(6.28, actual); 
        }

        [Test]
        public void validateGetCircumferenceWithRadius5()
        {
            Circle circle = new Circle();
            
            circle.SetRadius(5);

            double actual = circle.GetCircumference();

            Assert.AreEqual(31.400000000000002d, actual);
        }

        [Test]
        public void validateGetCircumferenceWithRadius6()
        {
            //This test case should fail
            Circle circle = new Circle();
            
            circle.SetRadius(6);

            double actual = circle.GetCircumference();

            Assert.AreEqual(31.40, actual);
        }

        //Test Cases for Get Area method
        [Test]
        public void validateGetAreaWithDefaultRadius()
        {
            Circle circle = new Circle();
            double actual = circle.GetArea();
            Assert.AreEqual(3.14,actual);
        }

        [Test]
        public void validateGetAreaWithRadius5()
        {
            Circle circle = new Circle();
            circle.SetRadius(5);
            double actual = circle.GetArea();
            Assert.AreEqual(78.5, actual);
        }

        [Test]
        public void validateGetAreaWithRadius6()
        {
            //This test case should fail
            Circle circle = new Circle();
            circle.SetRadius(6);
            double actual = circle.GetArea();
            Assert.AreEqual(78.5, actual);
        }


        //Test Cases for Get Area method
        [Test]
        public void validateGetRadiusWithDefaultRadius()
        {
            Circle circle = new Circle();
            int actual = circle.GetRadius();
            Assert.AreEqual(1,actual);
        }

        [Test]
        public void validateGetRadiusWithRadius5()
        {
            Circle circle = new Circle();
            circle.SetRadius(5);
            int actual = circle.GetRadius();
            Assert.AreEqual(5, actual);
        }
        
        [Test]
        public void validateGetRadiusWithRadius6()
        {
            //This test case should fail
            Circle circle = new Circle();
            circle.SetRadius(6);
            int actual = circle.GetRadius();
            Assert.AreEqual(5, actual);
        }


        //Test Cases for Set Radius method
        [Test]
        public void validateSetRadiusWithDefaultRadius()
        {
            Circle circle = new Circle();
            int actual = circle.GetRadius();
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void validateSetRadiusWith()
        {
            Circle circle = new Circle();
            circle.SetRadius(5);
            int actual = circle.GetRadius();
            Assert.AreEqual(5, actual);
        }

        [Test]
        public void validateSetRadiusWithNegativeRadius()
        {
            Circle circle = new Circle();
            circle.SetRadius(-5);
            int actual = circle.GetRadius();
            Assert.AreEqual(1, actual);
        }

    }
}
