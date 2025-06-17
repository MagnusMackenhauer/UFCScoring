using UFCScoring.Components;

var builder = WebApplication.CreateBuilder(args);

// Blazor & API
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddControllers(); // ✅ ← Denne var manglende

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5033") // skal matche porten appen kører på
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

// app.UseHttpsRedirection(); // stadig deaktiveret, godt!

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapControllers(); // virker nu fordi AddControllers() er tilføjet

app.Run();