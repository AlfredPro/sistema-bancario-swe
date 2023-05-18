using BankTransfer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.SqlServer.Server;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add configuration
var configuration = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json")
    .Build();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BankTransfer.DataAccess.DbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DbConnectionString")));
//builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<TransferRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseStaticFiles();

app.Run();
