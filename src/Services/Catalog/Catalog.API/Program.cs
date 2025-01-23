var builder = WebApplication.CreateBuilder(args);

//adding the services to di container


var app = builder.Build();

//configure the http request pipeline


app.Run();
