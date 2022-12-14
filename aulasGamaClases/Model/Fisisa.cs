using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulasGamaClases.Model
{
	internal class Fisisa : Pessoa
	{

		public string CPF;



		public string printDocumento()
		{

			return CPF;

		}
        public void mudaDocumento(string nCPF)
        {

            CPF = nCPF;

        }
        public bool validaCPF()
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			CPF = CPF.Trim();
			CPF = CPF.Replace(".", "").Replace("-", "");
			if (CPF.Length != 11)
				return false;
			tempCpf = CPF.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)

				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)

				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return CPF.EndsWith(digito);

		}
	}
}
