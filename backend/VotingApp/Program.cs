
using Appwrite.Services;
using VotingApp.Appwrite;
using VotingApp.Routes;
using VotingApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppwriteClient();
builder.Services.AddSingleton<AuthService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});

var app = builder.Build();

app.UseCors("AllowFrontend");

app.UseHttpsRedirection();

app.MapAuthRoutes();

app.Run();
