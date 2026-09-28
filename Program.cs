using ConnectFour;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<GameState>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<ConnectFour.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();