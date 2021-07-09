using Newtonsoft.Json;

namespace Brasileirao.Api.Client.Responses
{
    public class ExceptionResponse
    {
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
