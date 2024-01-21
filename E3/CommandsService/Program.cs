// English: Using directives for necessary namespaces.
// Espa�ol: Directivas de uso para los espacios de nombres necesarios.
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

// English: Create a new instance of WebApplication.
// Espa�ol: Crea una nueva instancia de WebApplication.
var builder = WebApplication.CreateBuilder(args);

// English: Add services to the container.
// Espa�ol: Agrega servicios al contenedor.
builder.Services.AddControllers();  // English: Add services for controllers. Espa�ol: Agrega servicios para controladores.
builder.Services.AddEndpointsApiExplorer();  // English: Add services for API endpoints. Espa�ol: Agrega servicios para los puntos finales de la API.
builder.Services.AddSwaggerGen();  // English: Add services for Swagger. Espa�ol: Agrega servicios para Swagger.

// English: Build the web application.
// Espa�ol: Construye la aplicaci�n web.
var app = builder.Build();

// English: Configure the HTTP request pipeline.
// Espa�ol: Configura el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())  // English: If the environment is Development... Espa�ol: Si el entorno es Desarrollo...
{
    app.UseSwagger();  // English: Use Swagger. Espa�ol: Usa Swagger.
    app.UseSwaggerUI();  // English: Use Swagger UI. Espa�ol: Usa la interfaz de usuario de Swagger.
}

//app.UseHttpsRedirection();  // English: Redirect HTTP requests to HTTPS. Espa�ol: Redirige las solicitudes HTTP a HTTPS.

app.MapControllers();  // English: Map HTTP requests to controllers. Espa�ol: Mapea las solicitudes HTTP a los controladores.

app.Run();  // English: Run the application. Espa�ol: Ejecuta la aplicaci�n.
