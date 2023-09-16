/******************************************************************************
 * Filename    = HttpRequestBuilder.cs
 * Description = Defines the interface for building an HTTP request.
 *****************************************************************************/

namespace BuilderDesignPatternDemo
{
    /// <summary>
    /// Defines the interface for building an HTTP request.
    /// </summary>
    public abstract class HttpRequestBuilder
    {
        protected HttpRequest request = new HttpRequest(); // The HttpRequest being constructed.

        /// <summary>
        /// Sets the HTTP method for the request.
        /// </summary>
        public abstract void SetMethod();

        /// <summary>
        /// Sets the URL for the request.
        /// </summary>
        public abstract void SetUrl();

        /// <summary>
        /// Sets the HTTP version for the request.
        /// </summary>
        public abstract void SetVersion();

        /// <summary>
        /// Sets the headers for the request.
        /// </summary>
        public abstract void SetHeaders();

        /// <summary>
        /// Sets the body for the request.
        /// </summary>
        public abstract void SetBody();

        /// <summary>
        /// Gets the constructed HttpRequest.
        /// </summary>
        /// <returns>The constructed HttpRequest.</returns>
        public HttpRequest GetHttpRequest()
        {
            return request;
        }
    }
}
