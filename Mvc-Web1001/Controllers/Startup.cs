public void ConfigureServices(IServiceCollection services)
{
    // ... other configurations

    services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
}