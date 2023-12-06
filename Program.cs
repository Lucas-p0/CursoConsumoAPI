using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using CursoConsumoAPI.Dependencias.Filtros;
using CursoConsumoAPI.Dependencias.Modelo;

using (HttpClient client = new())
{
    string URL_API = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
    try
    {
        string response = await client.GetStringAsync(URL_API);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response);
        //LinqFilter.FiltraArtistaPorGenero(musicas);
        //LinqFilter.FiltraTodosOsGeneros(musicas);
        //LinqFilter.FiltraMusicaPorArtista(musicas);
        LinqFilter.FiltraArtistaPorNome(musicas);
        //Console.WriteLine(response);
        //musicas[0].ExibeGeneroMusical();
        //musicas[177].ExibeFichaTecnica();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Deu erro aqui:{ex.Message}");
    }
}