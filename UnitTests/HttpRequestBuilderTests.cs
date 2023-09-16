/******************************************************************************
 * Filename    = HttpRequestBuilderTests.cs
 *
 * Author      = [Author Name]
 *
 * Product     = [Product Name]
 * 
 * Project     = UnitTests
 *
 * Description = Unit tests for the builder design pattern demo (HTTP request builders).
 *****************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuilderDesignPatternDemo;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for the HttpRequestBuilder and HttpRequestDirector classes.
    /// </summary>
    [TestClass]
    public class HttpRequestBuilderTests
    {
        /// <summary>
        /// Tests the construction of a GET request using the builder pattern.
        /// </summary>
        [TestMethod]
        public void TestGetRequestBuilder()
        {
            HttpRequestBuilder builder;

            // Arrange
            HttpRequestDirector director = new HttpRequestDirector();

            // Act
            builder = new GetRequestBuilder();
            director.SetBuilder(builder);
            director.Construct();
            HttpRequest request = director.GetRequest();

            // Assert
            Assert.AreEqual("GET", request.method); // Verifies if the HTTP method is set correctly.
            Assert.IsNotNull(request.headers);     // Verifies if headers are set (should not be null).
            Assert.IsNull(request.body);           // Verifies if the body is not set for a GET request.
        }

        /// <summary>
        /// Tests the construction of a POST request using the builder pattern.
        /// </summary>
        [TestMethod]
        public void TestPostRequestBuilder()
        {
            HttpRequestBuilder builder;

            // Arrange
            HttpRequestDirector director = new HttpRequestDirector();

            // Act
            builder = new PostRequestBuilder();
            director.SetBuilder(builder);
            director.Construct();
            HttpRequest request = director.GetRequest();

            // Assert
            Assert.AreEqual("POST", request.method); // Verifies if the HTTP method is set correctly.
            Assert.IsNotNull(request.headers);      // Verifies if headers are set (should not be null).
            Assert.IsNotNull(request.body);         // Verifies if a body is set for a POST request.
        }
    }
}
