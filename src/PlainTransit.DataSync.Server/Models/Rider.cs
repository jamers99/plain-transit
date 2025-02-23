using CommunityToolkit.Datasync.Server.LiteDb;
using PlainTransit.Core.Contract;

namespace PlainTransit.DataSync.Server.Models;

public class Rider : LiteDbTableData, IRider
{
    public string Name { get; set; } = "";
    public string? PhoneNumber { get; set; }
    public string? BillingAddress { get; set; }
}
