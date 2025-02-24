var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Ќачальна€ страница, дл€ продолжени€ перейдите в /hello");
app.MapGet("/hello", () => new { message = "Hello, World!" });

app.Run();
