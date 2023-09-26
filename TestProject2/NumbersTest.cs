using FluentAssertions;
using Net22_WebApp;

namespace TestProject2
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void VariblesTest_ReturnsSame_As_excpected()
        {
            //Arrange
            Numbers num = new Numbers();
            var actual = num.Add(10, 12);
            var expected = 22;
            //Act
            Assert.AreEqual(expected, actual);
            //Assert
        }
        [TestMethod]
        public void VariablesTestReturnsError()
        {
            //Arrange
            Numbers num = new Numbers();
            var actual = num.Add(11, 12);
            var expected = 23;
            //Act
            Assert.AreEqual(expected, actual);
            //Assert
        }

        [TestMethod]
        public void FluentAssertions_Test()
        {
            string name = "August";
           // name.Should().StartWith(expected: "A").And.EndWith(expected:"t");
            int number = 22;
            //number.Should().BeGreaterThanOrEqualTo(expected:21);
           // number.Should().BeLessThanOrEqualTo(expected:23);
            List<string> nameList = new List<string>() {"August", "Alessia", "Oskar", "Gong" };
            nameList.Should().HaveCount(expected: 4);
        }
    }
}