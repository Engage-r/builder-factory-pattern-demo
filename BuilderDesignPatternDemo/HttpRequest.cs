/******************************************************************************
 * Filename    = HttpRequest.cs
 *
 * Author      = [Author Name]
 *
 * Product     = [Product Name]
 * 
 * Project     = [Project Name]
 *
 * Description = Represents an HTTP request with method, URL, version, headers, and body.
 *****************************************************************************/

namespace BuilderDesignPatternDemo
{
    /// <summary>
    /// Represents an HTTP request with method, URL, version, headers, and body.
    /// </summary>
    public class HttpRequest
    {
        private string _method;                     // The HTTP method (e.g., GET, POST).
        private string _url;                        // The URL of the request.
        private double _version;                    // The HTTP version (e.g., 1.1, 2.0).
        private Dictionary<string, string> _headers; // The request headers.
        private string _body;                       // The request body.

        /// <summary>
        /// Gets or sets the HTTP method (e.g., GET, POST).
        /// </summary>
        public string Method
        {
            get { return _method; }
            set { _method = value; }
        }

        /// <summary>
        /// Gets or sets the URL of the request.
        /// </summary>
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        /// Gets or sets the HTTP version (e.g., 1.1, 2.0).
        /// </summary>
        public double Version
        {
            get { return _version; }
            set { _version = value; }
        }

        /// <summary>
        /// Gets or sets the request headers.
        /// </summary>
        public Dictionary<string, string> Headers
        {
            get { return _headers; }
            set { _headers = value; }
        }

        /// <summary>
        /// Gets or sets the request body.
        /// </summary>
        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        /// <summary>
        /// Displays the details of the HTTP request.
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Method: {_method}");
            Console.WriteLine($"URL: {_url}");
            Console.WriteLine($"Version: {_version}");
            Console.WriteLine("Headers:");
            foreach (var header in _headers)
            {
                Console.WriteLine($"{header.Key}: {header.Value}");
            }
            Console.WriteLine($"Body: {_body}");
        }
    }
}
