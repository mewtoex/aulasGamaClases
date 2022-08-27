using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace aulasGamaClases.Model
{
    internal class Pessoa
    {

        public string nome;
        public string descricao;
        //public int idade;
        public string funcao;
        public Endereco endereco = new Endereco();

        public string printName()
        {

            return nome;

        }
        public void mudarFuncao(string? novaFuncao)
        {
            if (novaFuncao != null)
                funcao = novaFuncao;
            else
                Console.WriteLine("Nova Funcão Invalida");



        }






    }
}
