using HousingBoardApi.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HousingBoardApi.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IMeetingRepository, MeetingRepository>();

        return services;
    }
}
