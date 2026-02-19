using Appwrite;
using Appwrite.Services;
using Appwrite.Models;
using VotingApp.Appwrite;

namespace VotingApp.Services;

public class AuthService
{
    public async Task<(User? User, string? Error)> RegisterAsync(string email, string password, string name)
    {
        try
        {
            var client = AppwriteExtensions.CreateClientWithKey();
            var account = new Account(client);
            
            var userId = Guid.NewGuid().ToString();
            
            var user = await account.Create(userId, email, password, name);
            
            var sessionAccount = new Account(AppwriteExtensions.CreateClientWithKey());
            await sessionAccount.CreateEmailPasswordSession(email, password);
            
            return (user, null);
        }
        catch (AppwriteException ex)
        {
            return (null, GetAppwriteErrorMessage(ex));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Register error: {ex.Message}");
            return (null, "Registration failed. Please try again.");
        }
    }

    public async Task<(Session? Session, string? Error)> LoginAsync(string email, string password)
    {
        try
        {
            var client = AppwriteExtensions.CreateClientWithKey();
            var account = new Account(client);
            
            var session = await account.CreateEmailPasswordSession(email, password);
            
            return (session, null);
        }
        catch (AppwriteException ex)
        {
            Console.WriteLine($"Login error: {ex.Message}");
            return (null, GetAppwriteErrorMessage(ex));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Login error: {ex.Message}");
            return (null, "Invalid email or password");
        }
    }

    public async Task<(User? User, string? Error)> GetCurrentUserAsync()
    {
        try
        {
            var client = new Client()
                .SetEndpoint(AppwriteExtensions.Endpoint)
                .SetProject(AppwriteExtensions.ProjectId);
            
            var account = new Account(client);
            var user = await account.Get();
            
            return (user, null);
        }
        catch (AppwriteException ex)
        {
            if (ex.Code == 401 || ex.Message.Contains("Unauthorized"))
            {
                return (null, "Unauthorized");
            }
            return (null, ex.Message);
        }
        catch (Exception)
        {
            return (null, "Unauthorized");
        }
    }

    public async Task<string?> LogoutAsync()
    {
        try
        {
            var client = new Client()
                .SetEndpoint(AppwriteExtensions.Endpoint)
                .SetProject(AppwriteExtensions.ProjectId);
            
            var account = new Account(client);
            await account.DeleteSession("current");
            
            return null;
        }
        catch (AppwriteException ex)
        {
            return ex.Message;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    private static string GetAppwriteErrorMessage(AppwriteException ex)
    {
        if (ex.Message.Contains("user already exists", StringComparison.OrdinalIgnoreCase))
            return "An account with this email already exists";
        if (ex.Message.Contains("invalid email", StringComparison.OrdinalIgnoreCase))
            return "Please enter a valid email address";
        if (ex.Message.Contains("invalid password", StringComparison.OrdinalIgnoreCase))
            return "Invalid password";
        if (ex.Message.Contains("rate limit", StringComparison.OrdinalIgnoreCase))
            return "Too many attempts. Please try again later";
        return "Authentication failed. Please try again";
    }
}
