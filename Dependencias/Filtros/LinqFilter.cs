using System;
using System.Collections.Generic;
using System.Linq;
using CursoConsumoAPI.Dependencias.Modelo;

namespace CursoConsumoAPI.Dependencias.Filtros
{
    public class LinqFilter
    {
        public static void FiltraTodosOsGeneros(List<Musica> musicas)
        {
            var todosOsGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();
            todosOsGeneros.Sort();
            foreach (var genero in todosOsGeneros)
            {
                Console.WriteLine($"{genero}");
            }
        }
        public static void FiltraArtistaPorNome(List<Musica> musicas)
        {
            var todosOsArtista = musicas.Select(artista => artista.Artista).Distinct().ToList();
            todosOsArtista.Sort();
            foreach (var artista in todosOsArtista)
            {
                Console.WriteLine($"{artista}");
            }
        }
        public static void FiltraArtistaPorGenero(List<Musica> musicas)
        {
            var todosOsArtista = musicas.Select(artista => artista.Artista).Distinct().ToList();
            todosOsArtista.Sort();
            // Gênero musical a ser filtrado
            string generoFiltrado = "rock";

            // Filtrando artistas por gênero
            List<Musica> artistasFiltrado = musicas.Where(a => a.Genero.Equals(generoFiltrado, StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine($"Artista do genero filtrado{generoFiltrado}");
            foreach (var artista in artistasFiltrado)
            {
                Console.WriteLine($"{artista.Artista} - {artista.Genero}");
            }


        }
        //Filtrar as músicas de um artista.
        public static void FiltraMusicaPorArtista(List<Musica> musicas)
        {
            var todasAsMusicas = musicas.Select(nomeMusica => nomeMusica.Nome).Distinct().ToList();
            todasAsMusicas.Sort();
            string artistaFiltrado = "Panic! At The Disco";
            List<Musica> listArtistasFiltrado = musicas.Where(a => a.Artista.Equals(artistaFiltrado, StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine($"As musicas do Artista são: \n");
            foreach (var artista in listArtistasFiltrado)
            {
                Console.WriteLine($"{artista.Nome} - {artista.Artista}");
            }
        }
    }
}

