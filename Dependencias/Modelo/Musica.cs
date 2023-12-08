
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CursoConsumoAPI.Dependencias.Modelo
{
    public class Musica
    {
        [JsonPropertyName("song")]
        public string Nome { get; set; }


        [JsonPropertyName("artist")]
        public string Artista { get; set; }


        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }


        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        [JsonPropertyName("key")]
        public int Tonalidade { get; set; }

        public void ExibeFichaTecnica()
        {
            Console.WriteLine($"Nome da musica: {Nome}");
            Console.WriteLine($"Nome do artista: {Artista}");
            Console.WriteLine($"Ducação da musica: {Duracao / 1000}");
            Console.WriteLine($"Nome da musica: {Genero}");
        }


    }
}

