namespace PlainTransit.Core.Models;

public class Stop
{
    string? Address { get; set; }
    DateTimeOffset EstimatedArrivalTime { get; set; }
}
