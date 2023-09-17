using FastFood_Web.Api.Confegurations;
using FastFood_Web.Api.Confegurations.LayerConfigurations;
using FastFood_Web.Api.Middlewares;
using FastFood_Web.Service.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDataAccess(builder.Configuration);
builder.Services.AddService();
builder.Services.AddMemoryCache();

builder.ConfigureAuth();
builder.Services.ConfigureSwaggerAuthorize();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


if (app.Services.GetService<IHttpContextAccessor>() != null)
{
    HttpContextHelper.Accessor = app.Services.GetRequiredService<IHttpContextAccessor>();
}

app.UseMiddleware<TokenRedirectMiddleware>();
app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
