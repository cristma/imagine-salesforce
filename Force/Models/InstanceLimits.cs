namespace Com.ImagineCode.Force;

/// <summary>
/// Response that represents the instance limit information.
/// </summary>
/// <remarks>/services/data/v##.#/limits</remarks>
public sealed class InstanceLimits
{
    public ActiveScratchOrgs ActiveScratchOrgs { get; set; } = new();
    public AnalyticsExternalDataSizeMB AnalyticsExternalDataSizeMB { get; set; } = new();
    public ConcurrentAsyncGetReportInstances ConcurrentAsyncGetReportInstances { get; set; } = new();
    public ConcurrentEinsteinDataInsightsStoryCreation ConcurrentEinsteinDataInsightsStoryCreation { get; set; } = new();
    public ConcurrentEinsteinDiscoveryStoryCreation ConcurrentEinsteinDiscoveryStoryCreation { get; set; } = new();
    public ConcurrentSyncReportRuns ConcurrentSyncReportRuns { get; set; } = new();
    public DailyAnalyticsDataflowJobExecutions DailyAnalyticsDataflowJobExecutions { get; set; } = new();
    public DailyAnalyticsUploadedFilesSizeMB DailyAnalyticsUploadedFilesSizeMB { get; set; } = new();
    public DailyFunctionsApiCallLimit DailyFunctionsApiCallLimit { get; set; } = new();
    public DailyApiRequests DailyApiRequests { get; set; } = new();
    public DailyAsyncApexExecutions DailyAsyncApexExecutions { get; set; } = new();
    public DailyAsyncApexTests DailyAsyncApexTests { get; set; } = new();
    public DailyBulkApiBatches DailyBulkApiBatches { get; set; } = new();
    public DailyBulkV2QueryFileStorageMB DailyBulkV2QueryFileStorageMB { get; set; } = new();
    public DailyBulkV2QueryJobs DailyBulkV2QueryJobs { get; set; } = new();
    public DailyDeliveredPlatformEvents DailyDeliveredPlatformEvents { get; set; } = new();
    public DailyDurableGenericStreamingApiEvents DailyDurableGenericStreamingApiEvents { get; set; } = new();
    public DailyDurableStreamingApiEvents DailyDurableStreamingApiEvents { get; set; } = new();
    public DailyEinsteinDataInsightsStoryCreation DailyEinsteinDataInsightsStoryCreation { get; set; } = new();
    public DailyEinsteinDiscoveryPredictAPICalls DailyEinsteinDiscoveryPredictAPICalls { get; set; } = new();
    public DailyEinsteinDiscoveryPredictionsByCDC DailyEinsteinDiscoveryPredictionsByCDC { get; set; } = new();
    public DailyEinsteinDiscoveryStoryCreation DailyEinsteinDiscoveryStoryCreation { get; set; } = new();
    public DailyGenericStreamingApiEvents DailyGenericStreamingApiEvents { get; set; } = new();
    public DailyScratchOrgs DailyScratchOrgs { get; set; } = new();
    public DailyStandardVolumePlatformEvents DailyStandardVolumePlatformEvents { get; set; } = new();
    public DailyStreamingApiEvents DailyStreamingApiEvents { get; set; } = new();
    public DailyWorkflowEmails DailyWorkflowEmails { get; set; } = new();
    public DataStorageMB DataStorageMB { get; set; } = new();
    public DurableStreamingApiConcurrentClients DurableStreamingApiConcurrentClients { get; set; } = new();
    public FileStorageMB FileStorageMB { get; set; } = new();
    public HourlyAsyncReportRuns HourlyAsyncReportRuns { get; set; } = new();
    public HourlyDashboardRefreshes HourlyDashboardRefreshes { get; set; } = new();
    public HourlyDashboardResults HourlyDashboardResults { get; set; } = new();
    public HourlyDashboardStatuses HourlyDashboardStatuses { get; set; } = new();
    public HourlyLongTermIdMapping HourlyLongTermIdMapping { get; set; } = new();
    public HourlyManagedContentPublicRequests HourlyManagedContentPublicRequests { get; set; } = new();
    public HourlyODataCallout HourlyODataCallout { get; set; } = new();
    public HourlyPublishedPlatformEvents HourlyPublishedPlatformEvents { get; set; } = new();
    public HourlyPublishedStandardVolumePlatformEvents HourlyPublishedStandardVolumePlatformEvents { get; set; } = new();
    public HourlyShortTermIdMapping HourlyShortTermIdMapping { get; set; } = new();
    public HourlySyncReportRuns HourlySyncReportRuns { get; set; } = new();
    public HourlyTimeBasedWorkflow HourlyTimeBasedWorkflow { get; set; } = new();
    public MassEmail MassEmail { get; set; } = new();
    public MonthlyEinsteinDiscoveryStoryCreation MonthlyEinsteinDiscoveryStoryCreation { get; set; } = new();
    public MonthlyPlatformEventsUsageEntitlement MonthlyPlatformEventsUsageEntitlement { get; set; } = new();
    public Package2VersionCreates Package2VersionCreates { get; set; } = new();
    public Package2VersionCreatesWithoutValidation Package2VersionCreatesWithoutValidation { get; set; } = new();
    public PermissionSets PermissionSets { get; set; } = new();
    public PrivateConnectOutboundCalloutHourlyLimitMB PrivateConnectOutboundCalloutHourlyLimitMB { get; set; } = new();
    public SingleEmail SingleEmail { get; set; } = new();
    public StreamingApiConcurrentClients StreamingApiConcurrentClients { get; set; } = new();
}

public sealed class ActiveScratchOrgs
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class AnalyticsExternalDataSizeMB
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class ConcurrentAsyncGetReportInstances
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class ConcurrentEinsteinDataInsightsStoryCreation
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class ConcurrentEinsteinDiscoveryStoryCreation
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class ConcurrentSyncReportRuns
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class CreateCustom
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyAnalyticsDataflowJobExecutions
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyAnalyticsUploadedFilesSizeMB
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyApiRequests
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyAsyncApexExecutions
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyAsyncApexTests
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyBulkApiBatches
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyBulkV2QueryFileStorageMB
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyBulkV2QueryJobs
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyDeliveredPlatformEvents
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyDurableGenericStreamingApiEvents
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyDurableStreamingApiEvents
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyEinsteinDataInsightsStoryCreation
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyEinsteinDiscoveryPredictAPICalls
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyEinsteinDiscoveryPredictionsByCDC
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyEinsteinDiscoveryStoryCreation
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyFunctionsApiCallLimit
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyGenericStreamingApiEvents
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyScratchOrgs
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyStandardVolumePlatformEvents
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyStreamingApiEvents
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DailyWorkflowEmails
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DataStorageMB
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class DurableStreamingApiConcurrentClients
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class FileStorageMB
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlyAsyncReportRuns
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlyDashboardRefreshes
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlyDashboardResults
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlyDashboardStatuses
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlyLongTermIdMapping
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlyManagedContentPublicRequests
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlyODataCallout
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlyPublishedPlatformEvents
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlyPublishedStandardVolumePlatformEvents
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlyShortTermIdMapping
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlySyncReportRuns
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class HourlyTimeBasedWorkflow
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class MassEmail
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class MonthlyEinsteinDiscoveryStoryCreation
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class MonthlyPlatformEventsUsageEntitlement
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class Package2VersionCreates
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class Package2VersionCreatesWithoutValidation
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class PermissionSets
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
    public CreateCustom CreateCustom { get; set; } = new();
}

public sealed class PrivateConnectOutboundCalloutHourlyLimitMB
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}
public sealed class SingleEmail
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}

public sealed class StreamingApiConcurrentClients
{
    public int? Max { get; set; }
    public int? Remaining { get; set; }
}