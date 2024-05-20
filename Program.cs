using CatFact.Components;
using CatFact.Interfaces;
using CatFact.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Rejestracja us³ug w kontenerze DI
builder.Services.AddHttpClient<IHttpClientService, HttpClientService>();
builder.Services.AddSingleton<IFileService, FileService>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddBlazorBootstrap();

var app = builder.Build();

// Konfiguracja middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();
app.UseAntiforgery();

// Mapowanie komponentów Razor
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();