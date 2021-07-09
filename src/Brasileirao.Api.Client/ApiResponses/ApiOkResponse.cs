namespace Brasileirao.Api.Client.ApiResponses
{
    public class ApiOkResponse<T> : ApiOkResponse
    {
        public T Data { get; set; }

        public ApiOkResponse(T data)
        {
            Data = data;
        }
    }

    public class ApiOkResponse
    {
        public string Message { get; set; } = "Success";
    }
}
