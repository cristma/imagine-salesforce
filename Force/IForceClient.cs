namespace Com.ImagineCode.Force;

/// <summary>
/// Service that will be used to perform API operations with Salesforce.
/// </summary>
public interface IForceClient
{
    /// <summary>
    /// Acquires the available versions that may be used with this instance.
    /// </summary>
    /// <param name="token">The cancellation token for cancelling the async process of the request.</param>
    /// <returns>An enumeration of the versions that are available for this instance.</returns>
    Task<ForceResponse<IEnumerable<InstanceVersion>>?> GetVersionsAsync(CancellationToken token = default);
}