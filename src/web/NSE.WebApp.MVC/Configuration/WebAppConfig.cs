using Microsoft.AspNetCore.Builder;

namespace NSE.WebApp.MVC.Configuration;

public static class WebAppConfig
{
    public static void AddMvcConfiguration(this IServiceCollection services, IConfiguration configuration) 
    {
        services.AddControllersWithViews();
    }

    public static void UseMvcConfiguration(this IApplicationBuilder app, IWebHostEnvironment env) 
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else 
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        app.UseIdentityConfiguration();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                                        name: "default",
                                        pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
