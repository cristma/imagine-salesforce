using System.Net;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;

namespace Com.ImagineCode.Force;

[TestClass]
public sealed class ForceClient_Test
{
    [TestMethod, ExpectedException(typeof(ArgumentException))]
    [TestCategory("Unit")]
    public void Constructor_NullInstanceUrl_ThrowsArgumentException()
    {
        var mockClient = new Mock<HttpClient>();
        
        _ = new ForceClient(null, mockClient.Object);
    }

    [TestMethod, ExpectedException(typeof(ArgumentException))]
    [TestCategory("Unit")]
    public void Constructor_EmptyInstanceUrl_ThrowsArgumentException()
    {
        var mockClient = new Mock<HttpClient>();
        _ = new ForceClient(string.Empty, mockClient.Object);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_TrailingForwardSlash_TruncatesUrl()
    {
        var mockClient = new Mock<HttpClient>();
        _ = new ForceClient("https://fakedomain.my.salesforce.com/", mockClient.Object);

        Assert.AreEqual(new Uri("https://fakedomain.my.salesforce.com"), mockClient.Object.BaseAddress);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Constructor_TrailingServicesRoute_TruncatesUrl()
    {
        var mockClient = new Mock<HttpClient>();
        _ = new ForceClient("https://fakedomain.my.salesforce.com/services/data/", mockClient.Object);

        Assert.AreEqual(new Uri("https://fakedomain.my.salesforce.com"), mockClient.Object.BaseAddress);
    }

    [TestMethod, ExpectedException(typeof(ArgumentException))]
    [TestCategory("Unit")]
    public void Constructor_NullHttpClient_ThrowsException()
    {
        var mockClient = new Mock<HttpClient>();
        _ = new ForceClient("https://fakedomain.my.salesforce.com/", null);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public async Task GetVersionsAsync_400StatusCode_ReturnsStatusBody()
    {
        var testMessage = "There was an error processing your request.";
        var mockHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
        mockHandler.Protected().Setup<Task<HttpResponseMessage>>(
            "SendAsync", 
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.BadRequest,
                Content = new StringContent(testMessage)
            })
            .Verifiable();

        var httpClient = new HttpClient(mockHandler.Object);

        var client = new ForceClient("https://fakedomain.my.salesforce.com/", httpClient);
        var response = await client.GetVersionsAsync();

        Assert.IsTrue(response?.HasErrors);
        Assert.AreEqual(HttpStatusCode.BadRequest, response?.StatusCode);
        CollectionAssert.Contains(response?.Errors?.ToList(), testMessage);
        Assert.IsNull(response?.Data);
    }

    [TestMethod]
    [TestCategory("Unit")]
    public async Task GetVersionsAsync_200StatusCode_ReturnsData()
    {
        var testObject = new List<InstanceVersion>
        {
            new InstanceVersion { Label = "Summer '14", Url = "/services/data/v31.0", Version = "31.0" },
            new InstanceVersion { Label = "Winter '15", Url = "/services/data/v32.0", Version = "32.0" },
            new InstanceVersion { Label = "Spring '15", Url = "/services/data/v33.0", Version = "33.0" }
        };

        var testMessage = JsonSerializer.Serialize(testObject);
        var mockHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
        mockHandler.Protected().Setup<Task<HttpResponseMessage>>(
            "SendAsync", 
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(testMessage)
            })
            .Verifiable();

        var httpClient = new HttpClient(mockHandler.Object);

        var client = new ForceClient("https://fakedomain.my.salesforce.com/", httpClient);
        var response = await client.GetVersionsAsync();

        Assert.IsFalse(response?.HasErrors);
        Assert.AreEqual(HttpStatusCode.OK, response?.StatusCode);
        Assert.IsNull(response?.Errors);

        Assert.AreEqual(response?.Data?.ToList()[0].Label, testObject[0].Label);
        Assert.AreEqual(response?.Data?.ToList()[0].Url, testObject[0].Url);
        Assert.AreEqual(response?.Data?.ToList()[0].Version, testObject[0].Version);

        Assert.AreEqual(response?.Data?.ToList()[1].Label, testObject[1].Label);
        Assert.AreEqual(response?.Data?.ToList()[1].Url, testObject[1].Url);
        Assert.AreEqual(response?.Data?.ToList()[1].Version, testObject[1].Version);

        Assert.AreEqual(response?.Data?.ToList()[2].Label, testObject[2].Label);
        Assert.AreEqual(response?.Data?.ToList()[2].Url, testObject[2].Url);
        Assert.AreEqual(response?.Data?.ToList()[2].Version, testObject[2].Version);
    }

    [TestMethod]
    [TestCategory("Integration")]
    [Ignore("This test is only ran on a limited basis since the subdomain need to be valid.  We will run it periodically to confirm integration.")]
    public async Task GetVersionsAsync_Integration_CheckResults()
    {
        var url = "https://[replace].my.salesforce.com/";
        var httpClient = new HttpClient();

        var client = new ForceClient(url, httpClient);
        var response = await client.GetVersionsAsync();

        Assert.IsFalse(response?.HasErrors);
        Assert.AreEqual(HttpStatusCode.OK, response?.StatusCode);
        Assert.IsNull(response?.Errors);
        Assert.IsTrue(response?.Data?.Any());
    }
}