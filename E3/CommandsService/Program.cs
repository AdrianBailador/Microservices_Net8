// English: Using directives for necessary namespaces.
// Español: Directivas de uso para los espacios de nombres necesarios.
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

// English: Create a new instance of WebApplication.
// Español: Crea una nueva instancia de WebApplication.
var builder = WebApplication.CreateBuilder(args);

// English: Add services to the container.
// Español: Agrega servicios al contenedor.
builder.Services.AddControllers();  // English: Add services for controllers. Español: Agrega servicios para controladores.
builder.Services.AddEndpointsApiExplorer();  // English: Add services for API endpoints. Español: Agrega servicios para los puntos finales de la API.
builder.Services.AddSwaggerGen();  // English: Add services for Swagger. Español: Agrega servicios para Swagger.

// English: Build the web application.
// Español: Construye la aplicación web.
var app = builder.Build();

// English: Configure the HTTP request pipeline.
// Español: Configura el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())  // English: If the environment is Development... Español: Si el entorno es Desarrollo...
{
    app.UseSwagger();  // English: Use Swagger. Español: Usa Swagger.
    app.UseSwaggerUI();  // English: Use Swagger UI. Español: Usa la interfaz de usuario de Swagger.
}

app.UseHttpsRedirection();  // English: Redirect HTTP requests to HTTPS. Español: Redirige las solicitudes HTTP a HTTPS.

app.MapControllers();  // English: Map HTTP requests to controllers. Español: Mapea las solicitudes HTTP a los controladores.

app.Run();  // English: Run the application. Español: Ejecuta la aplicación.
