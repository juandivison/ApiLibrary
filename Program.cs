var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddControllers();
var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization(); 
app.MapControllers();
app.Run();