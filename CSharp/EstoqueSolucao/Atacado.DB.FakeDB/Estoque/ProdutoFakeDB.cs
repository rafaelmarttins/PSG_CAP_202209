﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Domino.Estoque;

namespace Atacado.DB.FakeDB.Estoque
{
    public static class ProdutoFakeDB
    {
        private static List<Produto> produtos;

        public static List<Produto> Produtos
        {
            get
            {
                if(produtos == null)
                {
                    produtos = new List<Produto>();
                    Carregar();
                }
                return produtos;
            }
        }
        private static void Carregar()
        {
            produtos.Add(new Produto(1, "Farinha de Mandioca Mimosa", true, DateTime.Now, 1));
        }                                                                                     
    }                                                                                         
}                                                                                             
