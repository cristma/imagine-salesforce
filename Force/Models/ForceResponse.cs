using System.Net;

namespace Com.ImagineCode.Force;

/// <summary>
/// Generalized response for all requests made to Salesforce that will wrap a call for additional metadata.
/// </summary>
/// <typeparam name="T">The return type expect from Salesforce.  See <see cref="Data" />.</typeparam>
public sealed class ForceResponse<T> where T : class
{
    public ForceResponse(
        T? data,
        HttpStatusCode? statusCode,
        IEnumerable<string>? errors)
    {
        Data = data;
        StatusCode = statusCode;
        HasErrors = errors != null && errors.Any();
        Errors = errors;
    }

    /// <summary>
    /// Gets or sets the Salesforce response object that is expected.
    /// </summary>
    public T? Data { get; private set; }

    /// <summary>
    /// Gets or sets the response code from the request made to Salesforce.
    /// </summary>
    public HttpStatusCode? StatusCode { get; private set; }

    /// <summary>
    /// Gets or sets a value indicating whether this response has errors.
    /// </summary>
    /// <value></value>
    public bool? HasErrors { get; private set; }

    /// <summary>
    /// Gets or sets the errors that were returned by the request.
    /// </summary>
    public IEnumerable<string>? Errors { get; private set; }
}