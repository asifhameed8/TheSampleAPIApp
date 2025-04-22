using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options=>
         {
             options.Title = "The Smaple API"; // Set the title for the API reference page
             options.Theme = ScalarTheme.Saturn;
             options.Layout = ScalarLayout.Modern;
             options.HideClientButton = true; // Hide the "Try it out" button for client generation
         }
        );    
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");

app.Run();
