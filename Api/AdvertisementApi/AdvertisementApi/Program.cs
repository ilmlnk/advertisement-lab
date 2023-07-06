using AdIntegration.Api.Helpers;
using AdIntegration.Api.Hubs;
using AdIntegration.Business.Interfaces;
using AdIntegration.Business.Interfaces.Telegram;
using AdIntegration.Business.Interfaces.Viber;
using AdIntegration.Business.Interfaces.WhatsApp;
using AdIntegration.Business.Services;
using AdIntegration.Business.Services.Telegram;
using AdIntegration.Business.Services.Viber;
using AdIntegration.Business.Services.WhatsApp;
using AdIntegration.Data.DatabaseContext;
using AdIntegration.Data.Entities.Abstractions;
using AdIntegration.Repository.Interfaces;
using AdIntegration.Repository.Interfaces.Telegram;
using AdIntegration.Repository.Interfaces.Viber;
using AdIntegration.Repository.Interfaces.WhatsApp;
using AdIntegration.Repository.Repositories;
using AdIntegration.Repository.Repositories.Telegram;
using AdIntegration.Repository.Repositories.Viber;
using AdIntegration.Repository.Repositories.WhatsApp;
using log4net.Config;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Configuration;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

XmlConfigurator.Configure(new FileInfo("log4net.config"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IAuthenticateService, AuthenticateService>();

builder.Services.AddScoped<ITelegramAdvertisementService, TelegramAdvertisementService>();
builder.Services.AddScoped<ITelegramChannelService, TelegramChannelService>();
builder.Services.AddScoped<ITelegramUserService, TelegramUserService>();

builder.Services.AddScoped<IViberAdvertisementService, ViberAdvertisementService>();
builder.Services.AddScoped<IViberChannelService, ViberChannelService>();
builder.Services.AddScoped<IViberUserService, ViberUserService>();

builder.Services.AddScoped<IWhatsAppAdvertisementService, WhatsAppAdvertisementService>();
builder.Services.AddScoped<IWhatsAppChannelService, WhatsAppChannelService>();
builder.Services.AddScoped<IWhatsAppUserService, WhatsAppUserService>();

builder.Services.AddScoped<ISystemUserService, SystemUserService>();

builder.Services.AddScoped<ITelegramAdvertisementRepository, TelegramAdvertisementRepository>();
builder.Services.AddScoped<ITelegramChannelRepository, TelegramChannelRepository>();
builder.Services.AddScoped<ITelegramUserRepository, TelegramUserRepository>();

builder.Services.AddScoped<IViberAdvertisementRepository, ViberAdvertisementRepository>();
builder.Services.AddScoped<IViberChannelRepository, ViberChannelRepository>();
builder.Services.AddScoped<IViberUserRepository, ViberUserRepository>();

builder.Services.AddScoped<IWhatsAppAdvertisementRepository, WhatsAppAdvertisementRepository>();
builder.Services.AddScoped<IWhatsAppChannelRepository, WhatsAppChannelRepostitory>();
builder.Services.AddScoped<IWhatsAppUserRepository, WhatsAppUserRepository>();

builder.Services.AddScoped<ISystemUserRepository, SystemUserRepository>();

builder.Services.AddScoped<DbSeeder>();

builder.Services.AddSignalR();

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();

builder.Services.AddScoped<JwtService>();

builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Advertisement App", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});

builder.Services.AddDbContext<ApplicationDbContext>();

builder.Services.AddIdentityCore<User>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
})
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidAudience = builder.Configuration["Jwt:Audience"],
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Secret"]))
        };
});

// builder.Services.AddAutoMapper(typeof(AppMappingProfile));

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", 
        options => options
        .WithOrigins("https://localhost:3000")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());
});


builder.Services.AddHttpContextAccessor();

    
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();



using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dataContext.Database.EnsureCreated();

    var dbSeeder = scope.ServiceProvider.GetRequiredService<DbSeeder>();
    dbSeeder.SeedData();
}
app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapHub<ChatHub>("/hubs/chat");
});

app.UseHttpsRedirection();
app.UseAuthentication();
    
app.MapControllers();


app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());


app.Run();

