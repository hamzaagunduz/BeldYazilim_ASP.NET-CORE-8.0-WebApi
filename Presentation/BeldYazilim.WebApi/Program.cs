using BeldYazilim.Application.Interfaces;
using BeldYazilim.Application.Services;
using BeldYazilim.Application.Tools;
using BeldYazilim.Domain.Entities;
using BeldYazilim.Persistence.Context;
using BeldYazilim.Persistence.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidAudience = JwtTokenDefaults.ValidAudience,
        ValidIssuer = JwtTokenDefaults.ValidIssuer,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true
    };
});


builder.Services.AddScoped<BeldYazilimContext>();

//builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<BeldYazilimContext>();

builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
	//options.User.RequireUniqueEmail = false;

	options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
})
.AddEntityFrameworkStores<BeldYazilimContext>();





builder.Services.AddHttpClient();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

    



builder.Services.AddApplicationService(builder.Configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
