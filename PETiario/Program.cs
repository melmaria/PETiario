using System.Text;
using EFCore.UnitOfWork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PETiario.PETiary.Application.Appointements.Services;
using PETiario.PETiary.Application.Appointements.Services.Interfaces;
using PETiario.PETiary.Application.GroomingBaths.Services;
using PETiario.PETiary.Application.GroomingBaths.Services.Interfaces;
using PETiario.PETiary.Application.Owners.Services;
using PETiario.PETiary.Application.Owners.Services.Interfaces;
using PETiario.PETiary.Application.Pets.Services;
using PETiario.PETiary.Application.Pets.Services.Interfaces;
using PETiario.PETiary.Application.Vaccinations.Services;
using PETiario.PETiary.Application.Vaccinations.Services.Interfaces;
using PETiario.PETiary.Application.Walks.Services;
using PETiario.PETiary.Application.Walks.Services.Interfaces;
using PETiario.PETiary.Infra.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddUnitOfWork<PetiaryDbContext>();

builder.Services.AddDbContext<PetiaryDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var issuer = builder.Configuration["JwtSettings:Issuer"];
var audience = builder.Configuration["JwtSettings:Audience"];
var secretKey = builder.Configuration["JwtSettings:SecretKey"];

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = issuer,
            ValidAudience = audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
        };
    }
);

builder.Services.AddAuthorization();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IAppointmentApplication, AppointmentApplication>();
builder.Services.AddScoped<IGroomingBathApplication, GroomingBathApplication>();
builder.Services.AddScoped<IOwnerApplication, OwnerApplication>();
builder.Services.AddScoped<IPetApplication, PetApplication>();
builder.Services.AddScoped<IVaccinationApplication, VaccinationApplication>();
builder.Services.AddScoped<IWalkApplication, WalkApplication>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "petiary api v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();

