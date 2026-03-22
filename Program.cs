var builder = WebApplication.CreateBuilder(args);

// 🔹 Add services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 🔹 Enable Swagger
app.UseSwagger();
app.UseSwaggerUI();

// 🔹 Optional HTTPS (can keep or remove)
app.UseHttpsRedirection();

// 🔹 Test endpoints
app.MapGet("/", () => "API is running 🚀");

app.MapGet("/weather", () => new
{
    Temperature = 30,
    Condition = "Sunny"
});

app.Run();
