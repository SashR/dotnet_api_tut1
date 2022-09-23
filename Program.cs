/* Code creates a WebApplicationBuilder and a WebApplication with preconfigured defaults: */
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/* The following code creates an HTTP GET endpoint / which returns Hello World!: */
app.MapGet("/", () => "Hello World!");

app.Run();