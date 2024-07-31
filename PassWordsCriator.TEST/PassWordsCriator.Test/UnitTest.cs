using PassWordsCriator.API.Services;

namespace PassWordsCriator.Test
{
    public class UnitTest
    {
        private readonly PasswordService _service;


        public UnitTest()
        {
            _service = new PasswordService();
        }

        [Fact]
        public void TestListIsCompleted()
        {
            // Arrange
            short listMediumSize = 20;

            // Act
            int result = _service.GetMediumList().Count();

            // Assert
            Assert.Equal(result, listMediumSize);
        }
    }
}