/******************************************************************************
 * Filename    = HttpRequestDirector.cs
 * Description = Orchestrates the construction of an HTTP request using a builder.
 *****************************************************************************/

namespace BuilderDesignPatternDemo
{
    /// <summary>
    /// Orchestrates the construction of an HTTP request using a builder.
    /// </summary>
    public class HttpRequestDirector
    {
        private HttpRequestBuilder _builder; // The builder used for constructing the request.

        /// <summary>
        /// Sets the builder for constructing the HTTP request.
        /// </summary>
        /// <param name="builder">The HttpRequestBuilder to use for construction.</param>
        public void SetBuilder(HttpRequestBuilder builder)
        {
            this._builder = builder;
        }

        /// <summary>
        /// Gets the constructed HTTP request.
        /// </summary>
        /// <returns>The constructed HttpRequest.</returns>
        public HttpRequest GetRequest()
        {
            return this._builder.GetHttpRequest();
        }

        /// <summary>
        /// Constructs the HTTP request using the builder's methods.
        /// </summary>
        public void Construct()
        {
            this._builder.SetMethod();
            this._builder.SetUrl();
            this._builder.SetVersion();
            this._builder.SetHeaders();
            this._builder.SetBody();
        }
    }
}
