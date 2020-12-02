using System;
using CadastroAlunoPOO.classes;

namespace CadastroAlunoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            
            Console.Write("Digite o nome do Aluno: ");
            aluno.nome = Console.ReadLine();
            
            Console.Write("Digite o curso do Aluno: ");
            aluno.curso = Console.ReadLine();
            
            Console.Write("Digite o RG do Aluno: ");
            aluno.rg = Console.ReadLine();
            
            Console.Write("Digite a idade do Aluno: ");
            aluno.idade = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a média Final do Aluno: ");
            aluno.mediaFinal = float.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor da Mensalidade do Aluno: ");
            aluno.valorMensalidade = float.Parse(Console.ReadLine());
            
            Console.Write("Digite se o aluno é bolsista : s/n");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                aluno.bolsista = true;
            }else
            {
                aluno.bolsista = false;
            }

            //Menu
            int opcao;
            do
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Ver Média do Aluno");
                Console.WriteLine("[2] - Ver Mensalidade do Aluno");
                Console.WriteLine("[0] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    Console.WriteLine($"A média final do aluno {aluno.nome} = {aluno.VerMediaAluno()}");
                        break;
                    case 2:
                    Console.WriteLine($"O valor da mensalidade do aluno fica em: {aluno.VerMensalidade()}");

                        break;
                    case 0:
                    Console.WriteLine("Obrigado por acessar!");
                        break;
                    default:
                    Console.WriteLine("Opção Inválida");
                        break;
                }
                
            } while (opcao != 0);
        }
    }
}
