using Servak;   // пространство имен класса ChatHub

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://192.168.1.108:60185");

builder.Services.AddSignalR();

var app = builder.Build();


app.UseDefaultFiles();
app.UseStaticFiles();

app.MapHub<ChatHub>("/chat");
app.Run();
