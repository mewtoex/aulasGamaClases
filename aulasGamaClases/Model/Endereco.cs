using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulasGamaClases.Model
{
    internal class Endereco
    {
       public int numero;
       public string rua, bairro, cidade, estado, pais, cep;

        public void printEndereco()
        {

            Console.WriteLine("O endereco e :\nRua: " + rua +
                "\nBairro: " + bairro + "\nCidade: " + cidade + "\nEstado: " +
                estado + "\nCEP: " + cep);


        }

        public void lerEndereco(string pessoa)
        {

            Console.WriteLine("Digite o numro da " + pessoa);
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o rua da " + pessoa);
            rua = Console.ReadLine();
            Console.WriteLine("Digite o bairro da " + pessoa);
            bairro = Console.ReadLine();
            Console.WriteLine("Digite o cidade da " + pessoa);
            cidade = Console.ReadLine();
            Console.WriteLine("Digite o cep da " + pessoa);
            cep = Console.ReadLine();




        }
    }
}
