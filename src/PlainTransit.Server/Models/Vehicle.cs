using CommunityToolkit.Datasync.Server.LiteDb;
using PlainTransit.Core.Models;

namespace PlainTransit.Server.Models;

public class Vehicle : LiteDbTableData, IVehicle
{
    public string Name { get; set; } = "";
    public int MaxPassengers { get; set; }
}
