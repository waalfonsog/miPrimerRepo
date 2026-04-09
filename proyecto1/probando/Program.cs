using System.IO;
using Newtonsoft.Json.Linq;

// Simulación de lectura de cadena de conexión desde appsettings.json
var configFile = "appsettings.json";

if (!File.Exists(configFile))
{
    Console.WriteLine($"No se encontró el archivo de configuración: {configFile}");
    return;
}

var json = File.ReadAllText(configFile);
var jObject = JObject.Parse(json);
var connectionString = jObject["ConnectionStrings"]? ["DefaultConnection"]?.ToString();

if (string.IsNullOrWhiteSpace(connectionString))
{
    Console.WriteLine("No se encontró la cadena de conexión en appsettings.json.");
}
else
{
    Console.WriteLine("Simulación de cadena de conexión:");
    Console.WriteLine(connectionString);
}
string stripe_api_key="sk_test_51N8m9sLh5nu9s8s8s8s8s8s8s8s8s8";
