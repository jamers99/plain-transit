namespace PlainTransit.Core.Models;

public interface IRide
{
    string Id { get; set; }
    IRider? Rider { get; set; }
    IDriver? Driver { get; set; }
    IVehicle? Vehicle { get; set; }
    List<Stop> Stops { get; set; }
    int NumberOfRiders { get; set; }
    decimal? TotalCost { get; set; }
}