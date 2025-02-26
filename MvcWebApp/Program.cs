using MongoDB.Driver;
using MvcMongoApp.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IMongoClient>(new MongoClient("mongodb://localhost:27017"));


builder.Services.AddSingleton<UserLogService>();


builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
