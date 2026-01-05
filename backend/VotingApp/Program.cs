using Microsoft.Extensions.ObjectPool;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.UseHttpsRedirection();


string test = "Hello World";


app.MapGet("/test", () =>
{
    return test;
});

app.Run();

