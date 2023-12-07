using System;
using System.Collections.Generic;

namespace CursoConsumoAPI.Dependencias.Modelo
{
    public class MusicasPreferidas
    {
        public string? Nome { get; set; }
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
            Console.WriteLine($"Essas são as músicas favoritas- {Nome}");
        }
        public void ExibirMusicasFavoritas()
        {
            System.Console.WriteLine($"Essas são as músicas favoritas - {Nome}");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                System.Console.WriteLine($"{musica.Nome} de {musica.Artista}");
            }
        }
    }
}

