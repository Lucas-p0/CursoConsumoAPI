using System;
using System.Collections.Generic;
using System.Linq;
using CursoConsumoAPI.Dependencias.Modelo;

namespace CursoConsumoAPI.Dependencias.Filtros
{
    public class LinqFilter
    {
        public static void FiltraArtistaPorNome(List<Musica> musicas)
        {
            // var todosOsArtista = musicas.Select(artista => artista.Artista).Distinct().ToList();
            // todosOsArtista.Sort();
            var todosOsArtista = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var artista in todosOsArtista)
            {
                Console.WriteLine($"{artista}");
            }
        }
        public static void FiltraTonalidadeDaMusica(List<Musica> musicas)
        {
            var listaArtistas = musicas.OrderBy(musicas => musicas.Tonalidade).ToList();
            foreach (var artista in listaArtistas)
            {
                int listaDeTonalidades = artista.Tonalidade;
                switch (listaDeTonalidades)
                {
                    case 0:
                        System.Console.WriteLine($"Nota C - Dó");
                        break;
                    case 1:
                        System.Console.WriteLine($"Nota C# - Dó#");
                        break;
                    case 2:
                        System.Console.WriteLine($"Nota D - Ré");
                        break;
                    case 3:
                        System.Console.WriteLine($"Nota D# - Ré#");
                        break;
                    case 4:
                        System.Console.WriteLine($"Nota E - Mi");
                        break;
                    case 5:
                        System.Console.WriteLine($"Nota F - Fá");
                        break;
                    case 6:
                        System.Console.WriteLine($"Nota F# - Fá#");
                        break;
                    case 7:
                        System.Console.WriteLine($"Nota G - Sol");
                        break;
                    case 8:
                        System.Console.WriteLine($"Nota G# - Sol#");
                        break;
                    case 9:
                        System.Console.WriteLine($"Nota A - Lá");
                        break;
                    case 10:
                        System.Console.WriteLine($"Nota A - Lá#");
                        break;
                    case 11:
                        System.Console.WriteLine($"Nota B - Si");
                        break;
                    default:
                        System.Console.WriteLine($"Nota não existe");
                        break;
                }
            }
        }

        public static void FiltraTodosOsGeneros(List<Musica> musicas)
        {
            var todosOsGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();
            todosOsGeneros.Sort();
            foreach (var genero in todosOsGeneros)
            {
                Console.WriteLine($"{genero}");
            }
        }

        public static void FiltraArtistaPorGenero(List<Musica> musicas, string genero)
        {
            // var todosOsArtista = musicas.Select(artista => artista.Artista).Distinct().ToList();
            // todosOsArtista.Sort();
            // Gênero musical a ser filtrado
            // string generoFiltrado = "rock";
            // // Filtrando artistas por gênero
            // List<Musica> artistasFiltrado = musicas.Where(a => a.Genero.Equals(generoFiltrado, StringComparison.OrdinalIgnoreCase)).ToList();
            // Console.WriteLine($"Artista do genero filtrado{generoFiltrado}");
            // foreach (var artista in artistasFiltrado)
            // {
            //     Console.WriteLine($"{artista.Artista} - {artista.Genero}");
            // }
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"{artista}");
            }

        }
        //Filtrar as músicas de um artista.
        public static void FiltraMusicaPorArtista(List<Musica> musicas, string nomeDoArtista)
        {
            // var todasAsMusicas = musicas.Select(nomeMusica => nomeMusica.Nome).Distinct().ToList();
            // todasAsMusicas.Sort();
            // string artistaFiltrado = "Panic! At The Disco";
            // List<Musica> listArtistasFiltrado = musicas.Where(a => a.Artista.Equals(artistaFiltrado, StringComparison.OrdinalIgnoreCase)).ToList();
            var listArtistasFiltrado = musicas.Where(musicas => musicas.Artista!.Equals(nomeDoArtista)).ToList();
            Console.WriteLine(nomeDoArtista);

            Console.WriteLine($"As musicas do Artista são: \n");
            foreach (var artista in listArtistasFiltrado)
            {
                Console.WriteLine($"{artista.Nome} - {artista.Artista}");
            }
        }

    }
}

