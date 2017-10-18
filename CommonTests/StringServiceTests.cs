using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTests
{
    [TestClass]
    public class StringServiceTests
    {
        [TestMethod]
        public void When_IsPalindromeCallledWithInputRotator_ThenShouldReturn_True()
        {
            // Arrange
            var input = "rotator";

            // Act
            var isPalindome = input.IsPalindome();
            //Assert
            Assert.IsTrue(isPalindome);
        }

        [TestMethod]
        public void When_IsPalindromeCallledWithInputRotator1_ThenShouldReturn_False()
        {
            // Arrange
            var input = "rotator1";

            // Act
            var isPalindome = input.IsPalindome();

            //Assert
            Assert.IsFalse(isPalindome);
        }

        [TestMethod]
        public void When_ConcatenatingRotatorWithCapac_ThenShould_ReturnRotatorCapac()
        {
            var values = new string[] {"rotator", "capac"};

            var result = StringService.Concatenate(values);

            Assert.IsTrue(result =="rotatorcapac");
        }
    }
}
