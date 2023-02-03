﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap5
{
    internal class Produto
    {
        // Atributos
        private string _nome;
        private double _preco;
        private int _quantidade;


        //Construtor vazio
        public Produto()
        {
        }




        // Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }


        // metodo Get e Set
            public string GetNome()
            { 
             
               return _nome; 
            }
        
           public void SetNome(string nome)
           {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
            else { Console.WriteLine("Nome Inválido! "); }
           }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }




        // Metodos
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
