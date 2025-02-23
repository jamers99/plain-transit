namespace PlainTransit.Core.Contract;

public class Stop
{
    string? Address { get; set; }
    DateTimeOffset EstimatedArrivalTime { get; set; }
}
