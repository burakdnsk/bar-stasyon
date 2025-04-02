using barİstasyon.Persistence.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<MongoDbService>(sp =>
    new MongoDbService(builder.Configuration.GetConnectionString("MongoDB"), builder.Configuration["DatabaseName"]));

var app = builder.Build();


app.UseAuthorization();
app.MapControllers();
app.Run();

