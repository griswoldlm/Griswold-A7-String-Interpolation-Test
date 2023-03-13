using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Services;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate;

internal class Startup
{
    public IServiceProvider ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddLogging(builder =>
        {
            builder.AddConsole();
            builder.AddFile("app.log");
        });
        services.AddTransient<IStringInterpolationService, StringInterpolationService>();
        services.AddTransient<IMainService, MainService>();
        services.AddTransient<ISystemDate, SystemDate>();

        return services.BuildServiceProvider();
    }
}
