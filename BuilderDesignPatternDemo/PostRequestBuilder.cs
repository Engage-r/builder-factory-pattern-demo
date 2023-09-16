/******************************************************************************
 * Filename    = PostRequestBuilder.cs
 * Description = Constructs a POST HTTP request with specific method, URL, version, headers, and body.
 *****************************************************************************/

namespace BuilderDesignPatternDemo
{
    /// <summary>
    /// Constructs a POST HTTP request with specific method, URL, version, headers, and body.
    /// </summary>
    public class PostRequestBuilder : HttpRequestBuilder
    {
        /// <summary>
        /// Sets the HTTP method for the request to "POST".
        /// </summary>
        public override void SetMethod()
        {
            request.method = "POST";
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
        /// Sets the headers for the request, including Authorization and Content-Type.
        /// </summary>
        public override void SetHeaders()
        {
            request.headers = new Dictionary<string, string>
            {
                { "Authorization", "Bearer <token>" },
                { "Content-Type", "application/json" }
            };
        }

        /// <summary>
        /// Sets the request body to a JSON string.
        /// </summary>
        public override void SetBody()
        {
            request.body = "{ \"key\": \"value\" }"; // JSON request body
        }
    }
}
