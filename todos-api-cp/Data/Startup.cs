using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using todos_api_cp.Data;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        string connectionString = "postgres://z4ffe:xODFMNKm72vc@ep-orange-bird-24775976.eu-central-1.aws.neon.tech/neondb";

        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
    }
}