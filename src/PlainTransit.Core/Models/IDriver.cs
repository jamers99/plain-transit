namespace PlainTransit.Core.Models;

public interface IDriver
{
    string Id { get; set; }
    string Name { get; set; }
    string? PhoneNumber { get; set; }
}
