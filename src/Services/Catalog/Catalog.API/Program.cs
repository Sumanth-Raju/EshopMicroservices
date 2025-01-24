var builder = WebApplication.CreateBuilder(args);

//adding the services to di container

builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddControllers();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

//configure the http request pipeline
app.MapControllers();

app.Run();
