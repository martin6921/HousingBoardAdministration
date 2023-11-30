using HousingBoardApi.Application.Transaction;
using HousingBoardApi.Infrastructure.Repositories;
using HousingBoardApi.Infrastructure.TransactionHandling.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace HousingBoardApi.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IMeetingRepository, MeetingRepository>();
        services.AddScoped<IDocumentRepository, DocumentRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
