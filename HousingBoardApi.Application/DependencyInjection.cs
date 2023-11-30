using HousingBoardApi.Application.Queries.Meeting.Implementation;
using HousingBoardApi.Application.Queries.Meeting.Interface;
using HousingBoardApi.Application.Transaction.Behaviors;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HousingBoardApi.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddOpenBehavior(typeof(UnitOfWorkBehavior<,>));
        });

        services.AddScoped<IMeetingGetQuery, MeetingGetQuery>();
        services.AddScoped<IMeetingGetAllQuery, MeetingGetAllQuery>();

        return services;
    }
}
