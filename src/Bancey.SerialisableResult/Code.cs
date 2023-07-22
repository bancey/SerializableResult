using System;
using System.Collections.Generic;
using System.Text;

namespace Bancey.SerialisableResult
{
    public class Code
    {
        public static string Accepted => nameof(Accepted);
        public static string AuthorisationFailure => nameof(AuthorisationFailure);
        public static string AuthorisationHeaderNotFound => nameof(AuthorisationHeaderNotFound);
        public static string AuthorisationSuccess => nameof(AuthorisationSuccess);
        public static string BadRequest => nameof(BadRequest);
        public static string Conflict => nameof(Conflict);
        public static string CouldNotConnectToDatabase => nameof(CouldNotConnectToDatabase);
        public static string Created => nameof(Created);
        public static string ExpectationFailed => nameof(ExpectationFailed);
        public static string Forbidden => nameof(Forbidden);
        public static string InternalServerError => nameof(InternalServerError);
        public static string InvalidFileExtension => nameof(InvalidFileExtension);
        public static string InvalidFileName => nameof(InvalidFileName);
        public static string LogonFailure => nameof(LogonFailure);
        public static string LogonSuccess => nameof(LogonSuccess);
        public static string MethodNotAllowed => nameof(MethodNotAllowed);
        public static string NoContent => nameof(NoContent);
        public static string NotAcceptable => nameof(NotAcceptable);
        public static string NotFound => nameof(NotFound);
        public static string PartialInformation => nameof(PartialInformation);
        public static string PreconditionFailed => nameof(PreconditionFailed);
        public static string RequestTimeout => nameof(RequestTimeout);
        public static string Success => nameof(Success);
        public static string TooManyRequests => nameof(TooManyRequests);
        public static string UnknownStatus => nameof(UnknownStatus);
        public static string UnspecifiedFailure => nameof(UnspecifiedFailure);
        public static string UnprocessableEntity => nameof(UnprocessableEntity);
        public static string ImATeapot => nameof(ImATeapot);
    }
}
