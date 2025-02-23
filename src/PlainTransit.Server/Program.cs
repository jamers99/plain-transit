using PlainTransit.DataSync.Server;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddServerDataProvider()
    .AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.Run();