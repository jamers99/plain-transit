using CommunityToolkit.Datasync.Server;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatasyncServices();
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.Run();