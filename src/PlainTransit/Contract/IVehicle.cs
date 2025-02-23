namespace PlainTransit.Core.Contract;

public interface IVehicle
{
    string Id { get; set; }
    string Name { get; set; }
    int MaxPassengers { get; set; }
}
