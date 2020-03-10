namespace EgnHelper.Tests
{    
    using NUnit.Framework;

    [TestFixture]
    public class EgnValidatorTests
    {
        [TestCase("6101057509")]
        [TestCase("7523169263")]
        [TestCase("7552010005")]
        public void isValidMethodShouldReturnTrueForValidEgnFor20thCentury(string egn)
        {
            // Arrange
            EgnValidator validate = new EgnValidator();

            // Act
            bool result = validate.IsValid(egn);

            // Assert
            Assert.AreEqual(true, result);
        }
        
        [Test]
        public void IsValidMethodShouldThrowAnException()
        {            
            EgnValidator validate = new EgnValidator();

            try
            {
                validate.IsValid(null);
                Assert.Fail();
            }
            catch
            {
            }
        }
        
        [TestCase("111111111111111")]
        [TestCase("")]
        [TestCase("00")]
        public void isValidMethodShouldReturnFalse(string egn)
        {
            // Arrange
            EgnValidator validate = new EgnValidator();

            // Act
            bool result = validate.IsValid(egn);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
