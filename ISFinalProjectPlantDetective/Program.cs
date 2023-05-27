using ISFinalProjectPlantDetective;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddScoped<MachineLearningService>();

var app = builder.Build();

//app.MapGet("/", () => result.PredictedLabel);
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();

});

app.Run();
