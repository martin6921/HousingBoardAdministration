using HousingBoardApi.Application.Queries.Meeting.Implementation;
using HousingBoardApi.Application.Queries.Meeting.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HousingBoardApi.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {


        services.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        services.AddScoped<IMeetingGetQuery, MeetingGetQuery>();
        services.AddScoped<IMeetingGetAllQuery, MeetingGetAllQuery>();


        return services;
    }
}
