using Bancey.SerializableResult.StatusMessages;

namespace Bancey.SerializableResult.UnitTests.StatusMessages
{
    public class StatusMessageTests
    {
        [Fact]
        public void Create_EmptyMessage_DefaultValues()
        {
            var result = StatusMessage.Create();

            result.Should().NotBeNull();
            result.Status.Should().Be(StatusCode.UnknownStatus.Name);
            result.Code.Should().Be(StatusCode.UnknownStatus.Code);
            result.StatusCode.Should().BeEquivalentTo(StatusCode.UnknownStatus);
            result.Message.Should().Be("Unknown Status");
        }

        [Fact]
        public void Create_WithMessage_ExpectedValues()
        {
            const string expectedMessage = "Test Create method with message";
            var result = StatusMessage.Create(expectedMessage);

            result.Should().NotBeNull();
            result.Status.Should().Be(StatusCode.UnknownStatus.Name);
            result.Code.Should().Be(StatusCode.UnknownStatus.Code);
            result.StatusCode.Should().BeEquivalentTo(StatusCode.UnknownStatus);
            result.Message.Should().Be(expectedMessage);
        }

        [Fact]
        public void Create_WithStatusCodeAndMessage_ExpectedValues()
        {
            var statusCode = StatusCode.Success;
            const string expectedMessage = "Test Create method with status code and message";
            var result = StatusMessage.Create(statusCode, expectedMessage);

            result.Should().NotBeNull();
            result.Status.Should().Be(StatusCode.Success.Name);
            result.Code.Should().Be(StatusCode.Success.Code);
            result.StatusCode.Should().BeEquivalentTo(StatusCode.Success);
            result.Message.Should().Be(expectedMessage);
        }
    }
}