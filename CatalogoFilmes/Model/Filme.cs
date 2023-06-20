﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoFilmes.Model
{
    internal class Filme
    {
        private static int id;
        private static string nomeFilme;
        private static string estreiaFilme;
        private static string categoriaFilme;
        private static string duracaoFilme;

        public static int Id { get => id; set => id = value; }
        public static string NomeFilme { get => nomeFilme; set => nomeFilme = value; }
        public static string EstreiaFilme { get => estreiaFilme; set => estreiaFilme = value; }
        public static string CategoriaFilme { get => categoriaFilme; set => categoriaFilme = value; }
        public static string DuracaoFilme { get => duracaoFilme; set => duracaoFilme = value; }
    }
}
