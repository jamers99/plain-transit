using CommunityToolkit.Datasync.Server.LiteDb;
using PlainTransit.Core.Contract;

namespace PlainTransit.DataSync.Server.Models;

public class Driver : LiteDbTableData, IDriver
{
    public string Name { get; set; } = "";
    public string? PhoneNumber { get; set; }
}
