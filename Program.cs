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
        var minhaMusicasFavoritas = new MusicasPreferidas("Lucas");

        minhaMusicasFavoritas.AdicionarMusicasFavoritas(musicas[145]);
        minhaMusicasFavoritas.AdicionarMusicasFavoritas(musicas[77]);
        minhaMusicasFavoritas.AdicionarMusicasFavoritas(musicas[29]);
        minhaMusicasFavoritas.AdicionarMusicasFavoritas(musicas[17]);
        minhaMusicasFavoritas.AdicionarMusicasFavoritas(musicas[33]);




        //minhaMusicasFavoritas.ExibirMusicasFavoritas();
        //minhaMusicasFavoritas.GeraArquivoJson();
        //LinqFilter.FiltraArtistaPorGenero(musicas, "rock");
        //LinqFilter.FiltraTodosOsGeneros(musicas);
        //LinqFilter.FiltraMusicaPorArtista(musicas, "Panic! At The Disco");
        //LinqFilter.FiltraArtistaPorNome(musicas);

        //Console.WriteLine(response);
        //musicas[0].ExibeGeneroMusical();
        musicas[177].ExibeFichaTecnica();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Deu erro aqui:{ex.Message}");
    }
}