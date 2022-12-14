using Api;
using Microsoft.EntityFrameworkCore;
using Persistence;

public class Program
{
	public static async Task Main(string[] args)
	{
		var host = CreateHostBuilder(args).Build();

		using var scope = host.Services.CreateScope();

		var services = scope.ServiceProvider;

		var context = services.GetRequiredService<DataContext>();

		await context.Database.MigrateAsync();
        
          await host.RunAsync();
	}

	public static IHostBuilder CreateHostBuilder(string[] args) =>
	    Host.CreateDefaultBuilder(args)
		   .ConfigureWebHostDefaults(webBuilder =>
		   {
			   webBuilder.UseStartup<Startup>();
		   });
}
