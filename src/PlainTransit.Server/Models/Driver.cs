using CommunityToolkit.Datasync.Server.LiteDb;
using PlainTransit.Core.Models;

namespace PlainTransit.Server.Models;

public class Driver : LiteDbTableData, IDriver
{
    public string Name { get; set; } = "";
    public string? PhoneNumber { get; set; }
}
