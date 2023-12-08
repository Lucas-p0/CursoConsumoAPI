using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CursoConsumoAPI.Dependencias.Modelo
{
    public class MusicasPreferidas
    {
        public string Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }
        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }
        public void ExibirMusicasFavoritas(Musica musica)
        {
            Console.WriteLine($"Essas são as musicas favoritas- {Nome}");
        }
        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"\nEssas são as músicas favoritas - {Nome}\n");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"{musica.Nome} - {musica.Artista}");
            }
        }
        public void GeraArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaDeMusicasFavoritas
            });
            string nomeDoArquivo = $"Músicas favoritas-{Nome}.Json";
            File.WriteAllText(nomeDoArquivo, json);
            System.Console.WriteLine($"O aqruivo foi criado com sucesso! Caminho: {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}

