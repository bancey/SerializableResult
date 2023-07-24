using Newtonsoft.Json;

namespace Bancey.SerializableResult.StatusMessages
{
    public class Continue : StatusMessage
    {
        [JsonConstructor]
        protected Continue(StatusCode statusCode, string message)
            : base(statusCode, message) { }

        public static new Continue Create(string message = "The client should continue or disregard this response if the request has already completed.") => new Continue(StatusCode.Continue, message);
    }
}
