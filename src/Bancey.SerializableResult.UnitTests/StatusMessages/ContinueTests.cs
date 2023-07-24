using Bancey.SerializableResult.StatusMessages;

namespace Bancey.SerializableResult.UnitTests.StatusMessages
{
    public class ContinueTests
    {
        [Fact]
        public void Create_ReturnsContinueWithDefaultMessage()
        {
            var response = Continue.Create();

            response.Should().NotBeNull();
            response.Code.Should().Be(StatusCode.Continue.Code);
            response.Status.Should().Be(StatusCode.Continue.Name);
            response.StatusCode.Should().BeEquivalentTo(StatusCode.Continue);
            response.Message.Should().Be("The client should continue or disregard this response if the request has already completed.");
        }

        [Fact]
        public void Create_ReturnsContinueWithCustomMessage()
        {
            const string expectedMessage = "This is a custom message.";
            var response = Continue.Create(expectedMessage);

            response.Should().NotBeNull();
            response.Code.Should().Be(StatusCode.Continue.Code);
            response.Status.Should().Be(StatusCode.Continue.Name);
            response.StatusCode.Should().BeEquivalentTo(StatusCode.Continue);
            response.Message.Should().Be(expectedMessage);
        }
    }
}
