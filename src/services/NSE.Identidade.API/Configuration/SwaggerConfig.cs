using Microsoft.OpenApi.Models;

namespace NSE.Identidade.API.Configuration;

public static class SwaggerConfig
{
    public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "NerdStore Enterprise Identity API",
                Description = "Esta API foi criada para fins de aprendizado",
                Contact = new OpenApiContact { Name = "Josué Diogo Pedro", Email = "pedrojosuediogo@gmail.com" },
                License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://opensource.org/licences/MIT") }
            });
        });

        return services;
    }

    public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app,
        IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        return app;
    }
}
