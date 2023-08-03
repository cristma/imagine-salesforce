using System.Globalization;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Com.ImagineCode.Force;

/// <summary>
/// Service that will be used to perform API operations with Salesforce.
/// </summary>
public sealed class ForceClient : IForceClient
{
    /// <summary>
    /// The base URL that will be used when making requests to a Salesforce instance.
    /// </summary>
    private readonly string _instanceUrl;

    /// <summary>
    /// Client that will be used to make request to HTTP resources.
    /// </summary>
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Options that will be used when serializing and deserializing objects.
    /// </summary>
    private readonly JsonSerializerOptions _serializerOptions;

    /// <summary>
    /// Initializes a new instance of the <see cref="ForceClient" /> class.
    /// </summary>
    /// <param name="instanceUrl">The instance URL for the Salesforce instance. E.G.: https://<subdomain>.my.salesforce.com</param>
    public ForceClient(string? instanceUrl, HttpClient? httpClient, JsonSerializerOptions? serializerOptions = null)
    {
        _instanceUrl = string.IsNullOrEmpty(instanceUrl) ? throw new ArgumentException("Instance URL must be specified for force client construction.", nameof(instanceUrl)) 
                                                         : instanceUrl.TrimEnd('/').EndsWith("/services/data", true, CultureInfo.InvariantCulture) ? instanceUrl.Replace("/services/data", string.Empty, true, CultureInfo.InvariantCulture).TrimEnd('/')
                                                                                                                                                   : instanceUrl.TrimEnd('/');
        _httpClient = httpClient ?? throw new ArgumentException("Http client must be supplied in order to make calls to Salesforce.", nameof(httpClient));
        _serializerOptions = serializerOptions ?? new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        _httpClient.BaseAddress = new Uri(_instanceUrl);
    }

    /// <summary>
    /// Acquires the available versions that may be used with this instance.
    /// </summary>
    /// <param name="token">The cancellation token for cancelling the async process of the request.</param>
    /// <returns>An enumeration of the versions that are available for this instance.</returns>
    public async Task<ForceResponse<IEnumerable<InstanceVersion>>?> GetVersionsAsync(CancellationToken token = default)
    {
        using var response = await _httpClient.GetAsync("/services/data/");

        return new ForceResponse<IEnumerable<InstanceVersion>>(
            response.IsSuccessStatusCode ? JsonSerializer.Deserialize<IEnumerable<InstanceVersion>>(await response.Content.ReadAsStringAsync(token), _serializerOptions) 
                                         : null,
            response.StatusCode,
            !response.IsSuccessStatusCode ? new List<string> { await response.Content.ReadAsStringAsync(token) } 
                                          : null
        );
    }

    /// <summary>
    /// Acquires the available limits for an instance.
    /// </summary>
    /// <param name="authToken">The bearer token that will be used to make authenticated requests.</param>
    /// <param name="apiVersion">The api version that is used to make the request.</param>
    /// <param name="token">The cancellation token for cancelling the async process of the request.</param>
    /// <returns>Meta information about the limits for this instance.</returns>
    public async Task<ForceResponse<InstanceLimits>?> GetLimitsAsync(string? authToken, string? apiVersion, CancellationToken token = default)
    {
        if (string.IsNullOrEmpty(authToken))
            throw new ArgumentException("Bearer token must be specified in order to make and authenticated request.", nameof(authToken));
        if (string.IsNullOrEmpty(apiVersion))
            throw new ArgumentException("API version must be specified when making a request for meta information under instance version.", nameof(apiVersion));

        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
        using var response = await _httpClient.GetAsync($"/services/data/{apiVersion}/limits");

        return new ForceResponse<InstanceLimits>(
            response.IsSuccessStatusCode ? JsonSerializer.Deserialize<InstanceLimits>(await response.Content.ReadAsStringAsync(token), _serializerOptions)
                                         : null,
            response.StatusCode,
            !response.IsSuccessStatusCode ? new List<string> { await response.Content.ReadAsStringAsync(token) }
                                          : null);
    }
}