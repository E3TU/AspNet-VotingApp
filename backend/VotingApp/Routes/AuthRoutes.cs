using Microsoft.AspNetCore.Mvc;

namespace VotingApp.Routes;

public static class AuthRoutes
{
    public static void MapAuthRoutes(this WebApplication app)
    {
        var group = app.MapGroup("/auth");

        group.MapPost("/register", async ([FromBody] RegisterRequest request, Services.AuthService authService) =>
        {
            var (user, error) = await authService.RegisterAsync(request.Email, request.Password, request.Name);
            
            if (error != null)
            {
                return Results.BadRequest(new { error });
            }

            return Results.Created($"/auth/me/{user!.Id}", new { 
                message = "User registered successfully", 
                userId = user!.Id,
                email = user.Email,
                name = user.Name
            });
        });

        group.MapPost("/login", async ([FromBody] LoginRequest request, Services.AuthService authService) =>
        {
            var (session, error) = await authService.LoginAsync(request.Email, request.Password);
            
            if (error != null)
            {
                return Results.BadRequest(new { error });
            }

            return Results.Ok(new { 
                message = "Login successful",
                sessionId = session!.Id,
                userId = session.UserId
            });
        });

        group.MapGet("/me", async (Services.AuthService authService) =>
        {
            var (user, error) = await authService.GetCurrentUserAsync();
            
            if (error == "Unauthorized")
            {
                return Results.Unauthorized();
            }

            if (error != null)
            {
                return Results.BadRequest(new { error });
            }

            return Results.Ok(new 
            { 
                userId = user!.Id,
                email = user.Email,
                name = user.Name,
                registration = user.Registration,
                emailVerified = user.EmailVerification
            });
        });

        group.MapPost("/logout", async (Services.AuthService authService) =>
        {
            var error = await authService.LogoutAsync();
            
            if (error != null)
            {
                return Results.BadRequest(new { error });
            }

            return Results.Ok(new { message = "Logged out successfully" });
        });
    }
}

public record RegisterRequest(string Email, string Password, string Name);
public record LoginRequest(string Email, string Password);
