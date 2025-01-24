using CommunityToolkit.Datasync.Server.LiteDb;
using PlainTransit.Core.Models;

namespace PlainTransit.Server.Models;

public class Ride : LiteDbTableData, IRide
{
    public IRider? Rider { get; set; }
    public IDriver? Driver { get; set; }
    public IVehicle? Vehicle { get; set; }
    public List<Stop> Stops { get; set; } = [];
    public int NumberOfRiders { get; set; }
    public decimal? TotalCost { get; set; }
}
