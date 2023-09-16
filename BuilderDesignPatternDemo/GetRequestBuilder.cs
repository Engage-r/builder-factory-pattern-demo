/******************************************************************************
 * Filename    = GetRequestBuilder.cs
 * Description = Constructs a GET HTTP request with specific method, URL, version, headers, and body.
 *****************************************************************************/

namespace BuilderDesignPatternDemo
{
    /// <summary>
    /// Constructs a GET HTTP request with specific method, URL, version, headers, and body.
    /// </summary>
    public class GetRequestBuilder : HttpRequestBuilder
    {
        /// <summary>
        /// Sets the HTTP method for the request to "GET".
        /// </summary>
        public override void SetMethod()
        {
            request.method = "GET";
        }

        /// <summary>
        /// Sets the URL for the request.
        /// </summary>
        public override void SetUrl()
        {
            request.url = "https://api.example.com/resource";
        }

        /// <summary>
        /// Sets the HTTP version for the request to 1.1.
        /// </summary>
        public override void SetVersion()
        {
            request.version = 1.1;
        }

        /// <summary>
        /// Sets the headers for the request, including Authorization and Accept.
        /// </summary>
        public override void SetHeaders()
        {
            request.headers = new Dictionary<string, string>
            {
                { "Authorization", "Bearer <token>" },
                { "Accept", "application/json" }
            };
        }

        /// <summary>
        /// Sets the request body to null (GET request has no body).
        /// </summary>
        public override void SetBody()
        {
            request.body = null;
        }
    }
}
