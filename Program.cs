using databaseService;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IEventService, EventService>();



builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.UseCors("AllowAll");

app.UseRouting();

app.MapGraphQL();

app.Run();
