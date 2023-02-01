var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/greeting", () => "Hello from .NET");
            app.MapGet("/time/utc", () => Results.Ok(DateTime.UtcNow));

app.Run();
