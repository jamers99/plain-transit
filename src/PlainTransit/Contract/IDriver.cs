namespace PlainTransit.Core.Contract;

public interface IDriver
{
    string Id { get; set; }
    string Name { get; set; }
    string? PhoneNumber { get; set; }
}
