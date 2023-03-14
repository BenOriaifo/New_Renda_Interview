// See https://aka.ms/new-console-template for more information
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");
WebHost.CreateDefaultBuilder()
    .UseKestrel()
    .ConfigureServices(services => { services.AddMvc(); })
    .Configure(config => { config.UseMvc(); })
    .Build()
    .Run();
    