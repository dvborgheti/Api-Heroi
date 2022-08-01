using EFcore.WebAPI.Data;
using EFcore.WebAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IHeroiServices, HeroiServices>();
builder.Services.AddScoped<IBatalhaServices, BatalhaServices>();


builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer($"Password=123456;Persist Security Info=True;User ID=sa;Initial Catalog=HeroApp;Data Source=BORGHETI\\SQLEXPRESS");
});


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.RoutePrefix = "";
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
