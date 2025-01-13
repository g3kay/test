using Xunit;
using MyApp;
using Newtonsoft.Json;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSerialization()
        {
            // Arrange
            var person = new Person { Name = "John", Age = 30 };
            var expectedJson = "{\"Name\":\"John\",\"Age\":30}";

            // Act
            var json = JsonConvert.SerializeObject(person);

            // Assert
            Assert.Equal(expectedJson, json);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}