namespace PlainTransit.Core.Models;

public interface IRider
{
    string Id { get; set; }
    string Name { get; set; }
    string? PhoneNumber { get; set; }
    string? BillingAddress { get; set; }
}
