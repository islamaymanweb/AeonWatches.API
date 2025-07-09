

using AeonWatches.API.Data;
using AeonWatches.API.Data.Repositories;
using AeonWatches.API.Services;
using Microsoft.EntityFrameworkCore;

namespace AeonWatches.API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {

        services.AddDbContext<DataContext>(options =>
       options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
        services.AddCors();
        services.AddScoped<IWatchRepository, WatchRepository>();
        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<IWatchTypeRepository, WatchTypeRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        return services;
    }
}