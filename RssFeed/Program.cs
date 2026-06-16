using Microsoft.EntityFrameworkCore;
using RssFeed;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

WebApplication app = builder.Build();
app.MapOpenApi();
app.UseHttpsRedirection();
app.MapControllers();
app.UseStaticFiles();
app.Run();