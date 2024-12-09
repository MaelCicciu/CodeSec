using GenericGet.Library;

namespace GenericGet.Tests
{
    [TestClass]
    public class GetTests
    {
        public string url = "https://dog.ceo/api/breeds/image/random";

        [TestMethod]
        public void GetDogAPIOK()
        {
            // Act
            var actual = Deserialization.Get<Dog>(url);

            // Assert
            Assert.IsNotNull(actual);
        }

        public void GetStatusMessageOK()
        {
            // Arrange
            var expected = "success";

            // Act
            var actual = Deserialization.Get<Dog>(url);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}