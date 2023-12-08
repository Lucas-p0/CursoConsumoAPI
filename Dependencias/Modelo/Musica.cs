
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CursoConsumoAPI.Dependencias.Modelo
{
    public class Musica
    {
        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
        [JsonPropertyName("song")]
        public string Nome { get; set; }


        [JsonPropertyName("artist")]
        public string Artista { get; set; }


        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }


        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        [JsonPropertyName("key")]
        public int NotaMusical { get; set; }

        public string Tonalidade
        {
            get
            {
                return tonalidades[NotaMusical];
            }
        }

        public void ExibeFichaTecnica()
        {
            Console.WriteLine($"Nome da musica: {Nome}");
            Console.WriteLine($"Nome do artista: {Artista}");
            Console.WriteLine($"Ducação da musica: {Duracao / 1000}");
            Console.WriteLine($"Nome da musica: {Genero}");
            Console.WriteLine($"Tonalidade da musica: {Tonalidade}");
        }


    }
}

