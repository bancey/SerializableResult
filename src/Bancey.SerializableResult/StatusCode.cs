namespace Bancey.SerializableResult
{
    public class StatusCode
    {
        public string Name { get; }
        public int Code { get; }

        protected StatusCode(string name, int code)
        {
            this.Name = name;
            this.Code = code;
        }

        public static StatusCode Accepted => new StatusCode(nameof(Accepted), 202);
        public static StatusCode AuthorisationFailure => new StatusCode(nameof(AuthorisationFailure), 401);
        public static StatusCode AuthorisationHeaderNotFound => new StatusCode(nameof(AuthorisationHeaderNotFound), 401);
        public static StatusCode AuthorisationSuccess => new StatusCode(nameof(AuthorisationSuccess), 200);
        public static StatusCode BadRequest => new StatusCode(nameof(BadRequest), 400);
        public static StatusCode Conflict => new StatusCode(nameof(Conflict), 409);
        public static StatusCode Continue => new StatusCode(nameof(Continue), 100);
        public static StatusCode CouldNotConnectToDatabase => new StatusCode(nameof(CouldNotConnectToDatabase), 500);
        public static StatusCode Created => new StatusCode(nameof(Created), 201);
        public static StatusCode ExpectationFailed => new StatusCode(nameof(ExpectationFailed), 417);
        public static StatusCode Forbidden => new StatusCode(nameof(Forbidden), 403);
        public static StatusCode InternalServerError => new StatusCode(nameof(InternalServerError), 500);
        public static StatusCode InvalidFileExtension => new StatusCode(nameof(InvalidFileExtension), 400);
        public static StatusCode InvalidFileName => new StatusCode(nameof(InvalidFileName), 400);
        public static StatusCode LogonFailure => new StatusCode(nameof(LogonFailure), 403);
        public static StatusCode LogonSuccess => new StatusCode(nameof(LogonSuccess), 200);
        public static StatusCode MethodNotAllowed => new StatusCode(nameof(MethodNotAllowed), 405);
        public static StatusCode MultipleChoices => new StatusCode(nameof(MultipleChoices), 300);
        public static StatusCode NoContent => new StatusCode(nameof(NoContent), 201);
        public static StatusCode NotAcceptable => new StatusCode(nameof(NotAcceptable), 406);
        public static StatusCode NotFound => new StatusCode(nameof(NotFound), 404);
        public static StatusCode PartialInformation => new StatusCode(nameof(PartialInformation), 206);
        public static StatusCode PreconditionFailed => new StatusCode(nameof(PreconditionFailed), 412);
        public static StatusCode Processing => new StatusCode(nameof(Processing), 102);
        public static StatusCode RequestTimeout => new StatusCode(nameof(RequestTimeout), 408);
        public static StatusCode Success => new StatusCode(nameof(Success), 200);
        public static StatusCode SwitchingProtocols => new StatusCode(nameof(SwitchingProtocols), 101);
        public static StatusCode TooManyRequests => new StatusCode(nameof(TooManyRequests), 429);
        public static StatusCode UnknownStatus => new StatusCode(nameof(UnknownStatus), 0);
        public static StatusCode UnspecifiedFailure => new StatusCode(nameof(UnspecifiedFailure), 500);
        public static StatusCode UnprocessableEntity => new StatusCode(nameof(UnprocessableEntity), 422);
        public static StatusCode ImATeapot => new StatusCode(nameof(ImATeapot), 418);
    }
}
