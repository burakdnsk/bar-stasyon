using barİstasyon.Persistence.Services;


var builder = WebApplication.CreateBuilder(args);

// MongoDbService için bağlantı dizisini ve veritabanı adını yapılandırma
builder.Services.AddSingleton<MongoDbService>(sp =>
    new MongoDbService(
        builder.Configuration.GetConnectionString("MongoDB"),
        builder.Configuration["DatabaseName"]
    ));

var app = builder.Build();

// Authorization middleware eklenmiş ancak burada authentication işlemi yapılmadığı için gerek yoksa kaldırabilirsin
app.UseAuthorization();

// Controller'larınızı map edin
app.MapControllers();

// Uygulamayı çalıştır
app.Run();
