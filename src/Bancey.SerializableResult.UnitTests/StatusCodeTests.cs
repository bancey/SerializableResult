using System.Reflection;

namespace Bancey.SerializableResult.UnitTests
{
    public class StatusCodeTests
    {
        [Theory]
        [InlineData(nameof(StatusCode.Accepted), 202)]
        [InlineData(nameof(StatusCode.AuthorisationFailure), 401)]
        [InlineData(nameof(StatusCode.AuthorisationHeaderNotFound), 401)]
        [InlineData(nameof(StatusCode.AuthorisationSuccess), 200)]
        [InlineData(nameof(StatusCode.BadRequest), 400)]
        [InlineData(nameof(StatusCode.Conflict), 409)]
        [InlineData(nameof(StatusCode.Continue), 100)]
        [InlineData(nameof(StatusCode.CouldNotConnectToDatabase), 500)]
        [InlineData(nameof(StatusCode.Created), 201)]
        [InlineData(nameof(StatusCode.ExpectationFailed), 417)]
        [InlineData(nameof(StatusCode.Forbidden), 403)]
        [InlineData(nameof(StatusCode.InternalServerError), 500)]
        [InlineData(nameof(StatusCode.InvalidFileExtension), 400)]
        [InlineData(nameof(StatusCode.InvalidFileName), 400)]
        [InlineData(nameof(StatusCode.LogonFailure), 403)]
        [InlineData(nameof(StatusCode.LogonSuccess), 200)]
        [InlineData(nameof(StatusCode.MethodNotAllowed), 405)]
        [InlineData(nameof(StatusCode.MultipleChoices), 300)]
        [InlineData(nameof(StatusCode.NoContent), 201)]
        [InlineData(nameof(StatusCode.NotAcceptable), 406)]
        [InlineData(nameof(StatusCode.NotFound), 404)]
        [InlineData(nameof(StatusCode.PartialInformation), 206)]
        [InlineData(nameof(StatusCode.PreconditionFailed), 412)]
        [InlineData(nameof(StatusCode.Processing), 102)]
        [InlineData(nameof(StatusCode.RequestTimeout), 408)]
        [InlineData(nameof(StatusCode.Success), 200)]
        [InlineData(nameof(StatusCode.SwitchingProtocols), 101)]
        [InlineData(nameof(StatusCode.TooManyRequests), 429)]
        [InlineData(nameof(StatusCode.UnknownStatus), 0)]
        [InlineData(nameof(StatusCode.UnspecifiedFailure), 500)]
        [InlineData(nameof(StatusCode.UnprocessableEntity), 422)]
        [InlineData(nameof(StatusCode.ImATeapot), 418)]
        public void StatusCode_Has_Correct_Code(string name, int expectedCode)
        {
            Type type = typeof(StatusCode);
            PropertyInfo? propertyInfo = type.GetProperty(name);
            propertyInfo.Should().NotBeNull();
            StatusCode? status = propertyInfo?.GetValue(null) as StatusCode;

            status.Should().NotBeNull();
            status?.Code.Should().Be(expectedCode);
        }
    }
}
