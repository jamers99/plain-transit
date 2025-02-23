using CommunityToolkit.Datasync.Server.LiteDb;
using PlainTransit.Core.Contract;

namespace PlainTransit.DataSync.Server.Models;

public class Vehicle : LiteDbTableData, IVehicle
{
    public string Name { get; set; } = "";
    public int MaxPassengers { get; set; }
}
