using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using App;
using App.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Persistence;
using Persistence.Repositories;

namespace Api
{
	public class Startup
	{
		private readonly IConfiguration _config;
		public Startup(IConfiguration config)
		{
			_config = config;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();

			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo 
					{ 
						Title = "API",
						Version = "v1",
						Description = "Application for gross written premium calculation",
						Contact = new OpenApiContact
						{
							Name = "Michal Fiala",
						}
					});
				// Set the comments path for the Swagger JSON and UI.
				var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
				c.IncludeXmlComments(xmlPath);
			});

			services.AddDbContext<DataContext>(opt =>
			{
				opt.UseSqlite(_config.GetConnectionString("DefaultConnection"));
			});

			services.AddScoped<ICountryRepository, CountryRepository>();
			services.AddScoped<IGrossWrittenPremiumRepository, GrossWrittenPremiumRepository>();
			services.AddScoped<ILineOfBusinessRepository, LineOfBusinessRepository>();
			
			services.AddScoped<ICountryService, CountryService>();
			services.AddScoped<IGrossWrittenPremiumService, GrossWrittenPremiumService>();
			services.AddScoped<ILineOfBusinessService, LineOfBusinessService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
			}
			app.UseRouting();

			app.UseAuthentication();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}