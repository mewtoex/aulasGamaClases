// See https://aka.ms/new-console-template for more information
using aulasGamaClases.Model;


bool sair = true;

do
{
    Console.WriteLine("Digite qual tipo de pessoa gostaria de chamar fisica ou juricica");
    var tipoPessoa = Console.ReadLine();
    switch (tipoPessoa.ToLower())
    {
        case ("fisica"):
            Fisisa pessoaf = new Fisisa();
            Console.WriteLine("Digite o nome da Pessoa");
            pessoaf.nome = Console.ReadLine();
            Console.WriteLine("Digite a função da " + pessoaf.nome);
            pessoaf.funcao = Console.ReadLine();
            Console.WriteLine("Digite o CPF da " + pessoaf.nome);
            pessoaf.CPF = Console.ReadLine();
            while (!pessoaf.validaCPF())
            {
                Console.WriteLine("CPF invalido digite novamente");
                pessoaf.mudaDocumento(Console.ReadLine());
            }
            Console.WriteLine("Digite o endereco da " + pessoaf);
            pessoaf.endereco.lerEndereco(pessoaf.nome);
            pessoaf.endereco.printEndereco();

            break;

        case ("juridica"):
            Juridica pessoaj = new Juridica();
            Console.WriteLine("Digite o nome da empresa");
            pessoaj.nome = Console.ReadLine();
            Console.WriteLine("Digite a função da empresa " + pessoaj.nome);
            pessoaj.funcao = Console.ReadLine();
            Console.WriteLine("Digite o CNPJ da empresa " + pessoaj.nome);
            pessoaj.CNPJ = Console.ReadLine();
            while (!pessoaj.validaCNPJ())
            {
                Console.WriteLine("CNPJ invalido digite novamente");
                pessoaj.mudaDocumento(Console.ReadLine());
            }
            Console.WriteLine("Digite o endereco da empresa");
            pessoaj.endereco.lerEndereco(pessoaj.nome);
            pessoaj.endereco.printEndereco();



            break;


        default:
            Console.WriteLine("Entrada invalida");

            break;

    }
  //  Console.WriteLine("Deseja exibir dados cadastrato");
  //  var verDados = Console.ReadLine();
  //  switch (verDados.ToLower())
  //  {
  //      case ("sim"):
  //          {


  //          }
  //          sair = true;
  //          break;
  //      case ("nao"):
  //          {


  //          }
  //          break;
  //      case ("não"):
  //{


  //          }            break;

  //      default:
  //          Console.WriteLine("Entrada invalida");
  //          break;
  //  }

    Console.WriteLine("Deseja sair\nDigite sim ou não");
    var saida = Console.ReadLine();
    switch (saida.ToLower())
    {
        case ("sim"):
            sair = false;
            break;
        case ("nao"):
            sair = true;
            break;
        case ("não"):
            sair = true;
            break;

        default:
            Console.WriteLine("Entrada invalida");
            break;
    }



} while (sair);
