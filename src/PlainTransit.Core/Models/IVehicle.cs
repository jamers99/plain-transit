namespace PlainTransit.Core.Models;

public interface IVehicle
{
    string Id { get; set; }
    string Name { get; set; }
    int MaxPassengers { get; set; }
}
