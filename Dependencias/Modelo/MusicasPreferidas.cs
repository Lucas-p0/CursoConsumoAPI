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
        public static void ExibirMusicasFavoritas(Musica musica)
        {
            Console.WriteLine();
        }
    }
}

