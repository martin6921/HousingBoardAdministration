﻿using BookingSystemApi.Application.IRepositories;
using BookingSystemApi.Application.Queris.Booking.GetAllBooking;
using BookingSystemApi.Application.Transaction.Behaviors;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BookingSystemApi.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            cfg.AddOpenBehavior(typeof(UnitOfWorkBehavior<,>));
        });
        
        //services.AddScoped<GetAllBookingsQuery, GetAllBookingsQueryHandler>();
        //services.AddScoped<IBookingGetQuery, BookingGetQuery>();
        //services.AddScoped<IResourceGetAllQuery, ResourceGetAllQuery>();
        //services.AddScoped<IResourceGetQuery, ResourceGetQuery>();

        return services;
    }
}
