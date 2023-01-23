using System.Net;
using Microsoft.AspNetCore.Mvc;
using OnlyCats.Controllers.ReplaceDogController;

namespace OnlyCats_tests
{
    public class ReplaceDogControllerTest
    {
        private readonly ReplaceDogController _controller;

        public ReplaceDogControllerTest()
        {
            _controller = new ReplaceDogController();
        }

        [Fact]
        public void ReplaceDog_ReturnsOk()
        {
            // Arrange - create json object that has the string dog in several places 
            var json = new { name = "dog", message = "this is a message about dogs", todo = "pickup dog food" };

            // Act - get the response 
            var response = _controller.ReplaceDog(json) as OkObjectResult;
            if (response != null && response.Value != null && response.StatusCode != null)
            {
                var responseString = response.Value.ToString();

                // Assert - confirm that the status is 200, we have the string "cat" and not longer have and instance of "dog" 
                Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)response.StatusCode);
                Assert.Contains("cat", responseString);
                Assert.DoesNotContain("dog", responseString);
            }
        }
    }
}