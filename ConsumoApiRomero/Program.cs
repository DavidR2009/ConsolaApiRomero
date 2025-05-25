using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
    private static readonly HttpClient client = new HttpClient
    {
        BaseAddress = new Uri("http://appdavid-acfgcxe0g0fvc5be.westus2-01.azurewebsites.net/api/") 
    };

    static async Task Main(string[] args)
    {
        Console.WriteLine("=== Listar Participantes ===");
        await ListarParticpantes();

        Console.WriteLine("=== Listar Ponentes ===");
        await ListarPonentes();


        Console.WriteLine("\n=== Listar Espacios ===");
        await ListarEspacios();

       
        Console.WriteLine("\n=== Listar Eventos ===");
        await ListarEventos();

    }

    static async Task ListarParticpantes()
    {
        try
        {
            var ponentes = await client.GetFromJsonAsync<List<Participante>>("Ponentes");
            foreach (var p in ponentes)
            {
                Console.WriteLine($"ID: {p.participante_id}, Nombre: {p.nombre} {p.apellido}, Email: {p.email}, Institución: {p.institucion}, Fecha nacimiento: {p.fecha_nacimiento}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener ponentes: " + ex.Message);
        }
    }
    // Métodos para Ponentes
    static async Task ListarPonentes()
    {
        try
        {
            var ponentes = await client.GetFromJsonAsync<List<Ponente>>("Ponentes");
            foreach (var p in ponentes)
            {
                Console.WriteLine($"ID: {p.ponente_id}, Nombre: {p.nombre} {p.apellido}, Email: {p.email}, Institución: {p.institucion}, Bio: {p.bio}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener ponentes: " + ex.Message);
        }
    }


    // Métodos para Espacios
    static async Task ListarEspacios()
    {
        try
        {
            var espacios = await client.GetFromJsonAsync<List<Espacio>>("Espacios");
            foreach (var e in espacios)
            {
                Console.WriteLine($"ID: {e.espacio_id}, Nombre: {e.nombre}, Ubicación: {e.ubicacion}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener espacios: " + ex.Message);
        }
    }

    

    // Métodos para Eventos
    static async Task ListarEventos()
    {
        try
        {
            var eventos = await client.GetFromJsonAsync<List<Evento>>("Eventos");
            foreach (var ev in eventos)
            {
                Console.WriteLine($"ID: {ev.evento_id}, Nombre: {ev.nombre}, Inicio: {ev.fecha_inicio.ToShortDateString()}, Fin: {ev.fecha_fin.ToShortDateString()}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener eventos: " + ex.Message);
        }
    }

}
