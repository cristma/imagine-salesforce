namespace Com.ImagineCode.Force;

/// <summary>
/// Response that represents the version information.
/// </summary>
/// <remarks>/services/data</remarks>
public sealed class InstanceVersion
{
    /// <summary>
    /// Gets or sets the release name that is associated with this <see cref="InstanceVersion" />
    /// </summary>
    /// <value></value>
    public string? Label { get; set; }

    /// <summary>
    /// Gets or sets the path that is associated with this <see cref="InstanceVersion" />.
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Gets or sets the Salesforce API version that is associated with this <see cref="InstanceVersion" />.
    /// </summary>
    public string? Version { get; set; }
}