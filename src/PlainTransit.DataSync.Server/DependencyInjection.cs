using CommunityToolkit.Datasync.Server;
using Microsoft.Extensions.DependencyInjection;

namespace PlainTransit.DataSync.Server;

public static class DependencyInjection
{
    public static IServiceCollection AddServerDataProvider(this IServiceCollection services) => services
        .AddDatasyncServices();
}
