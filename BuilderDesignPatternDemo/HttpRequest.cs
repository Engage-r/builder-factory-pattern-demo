/******************************************************************************
 * Filename    = HttpRequest.cs
 * Description = Represents an HTTP request with method, URL, version, headers, and body.
 *****************************************************************************/

namespace BuilderDesignPatternDemo
{
    /// <summary>
    /// Represents an HTTP request with method, URL, version, headers, and body.
    /// </summary>
    public class HttpRequest
    {
        public string method { get; set; }                     // The HTTP method (e.g., GET, POST).
        public string url { get; set; }                        // The URL of the request.
        public double version { get; set; }                    // The HTTP version (e.g., 1.1, 2.0).
        public Dictionary<string, string> headers { get; set; } // The request headers.
        public string body { get; set; }                       // The request body.

        

        /// <summary>
        /// Displays the details of the HTTP request.
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Method: {this.method}");
            Console.WriteLine($"URL: {this.url}");
            Console.WriteLine($"Version: {this.version}");
            Console.WriteLine("Headers:");
            foreach (var header in this.headers)
            {
                Console.WriteLine($"{header.Key}: {header.Value}");
            }
            Console.WriteLine($"Body: {this.body}");
        }
    }
}
