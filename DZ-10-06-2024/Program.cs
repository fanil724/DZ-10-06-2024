var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Use(async (context, next) =>
{
    if (context.Request.Path != "/favicon.ico")
    {
        Console.WriteLine($"Date: {DateTime.Now.ToShortDateString()}: {context.Request.Path}");
    }
    await next.Invoke();
});

app.UseMiddleware<ErrorHandlingMiddlweare>();
app.UseMiddleware<AuthenticationMiddleware>();

app.Map("users/{name}/{age:int}", (string name, int age) => $"User name: {name}, age: {age}.");
app.Map("/message/{name}/{message}", (string name, string message) => $"Message for users:{name}-<{message}>");
app.Map("/Hello/{name}", (string name) => $"Hello {name}");
app.Map("/{message}", (string message) => $"{message}");

app.Run();
