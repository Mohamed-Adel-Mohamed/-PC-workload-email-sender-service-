namespace Q1_WindowsService;

/// <summary>
/// Representation of Host Machine Workload 
/// </summary>
public sealed class Workload
{
    public float CpuUtilizationPercentage { get; set; }

    /// <summary>
    /// Current Memory Utilization in MB
    /// </summary>
    public float MemoryUtilization { get; set; }

    /// <summary>
    /// Total available size in all drives on machine in GB
    /// </summary>
    public long TotalFreeDriveSize { get; set; }

    /// <summary>
    /// Total Sent Network Size in all Network Interfaces in KB
    /// </summary>
    public long TotalNetworkSentSize { get; set; }

    /// <summary>
    /// Total Received Network Size in all Network Interfaces in KB
    /// </summary>
    public long TotalNetworkReceivedSize { get; set; }
}
