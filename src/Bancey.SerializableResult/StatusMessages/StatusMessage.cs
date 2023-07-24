using Newtonsoft.Json;

namespace Bancey.SerializableResult.StatusMessages
{
    public class StatusMessage
    {
        [JsonIgnore]
        public virtual StatusCode StatusCode { get; } = StatusCode.UnknownStatus;

        public virtual string Message { get; } = "Unknown Status";

        public string Status
        {
            get { return this.StatusCode.Name; }
        }

        public int Code
        {
            get { return this.StatusCode.Code; }
        }

        [JsonConstructor]
        protected StatusMessage(StatusCode statusCode, string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                this.Message = message;
            }
            this.StatusCode = statusCode;
        }

        public static StatusMessage Create(string message = "Unknown Status") => new StatusMessage(StatusCode.UnknownStatus, message);

        public static StatusMessage Create(StatusCode statusCode, string message) => new StatusMessage(statusCode, message);
    }
}
