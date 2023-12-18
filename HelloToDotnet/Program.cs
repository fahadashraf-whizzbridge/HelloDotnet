
using ORM.DatabaseContext;
using RESTCore.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

// Add services to the container.
builder.Services.AddTransient<HelloToDotnet.Services.HelloService>();
builder.Services.AddTransient<HelloToDotnetSOmethingElseNewNS.Services.HelloService>();


builder.Services.AddScoped<UserService>();

builder.Services.AddScoped<HelloToDotnet.Services.ByeService>();
builder.Services.AddSingleton<HelloToDotnet.Services.ByeService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
