using DIExample.Core;
using DIExample.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Setup DI container
        var services = new ServiceCollection();

        // Register implementations with transient lifetime as requested
        services.AddTransient<IMessageService, SmsService>();

        // Register Notification so it can be resolved and its constructor dependency injected
        services.AddTransient<Notification>();

        using var provider = services.BuildServiceProvider();

        // Resolve Notification and use it
        var notify = provider.GetRequiredService<Notification>();
        notify.Alert("hello dependency injection with transient lifetime!");
        
    }
}
