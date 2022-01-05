using ProjetoElevador.MODEL;
using System;
namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            Elevador elevador = new Elevador();
            // Menu para guiar o usuário.
            Console.WriteLine("Sistema Para  Elevador");
                Console.WriteLine("");
            Console.WriteLine("============== Comandos Disponíveis ==============");
            Console.WriteLine("1 = Inicializar Elevador (Redefinir Elevador)");
            Console.WriteLine("2 = Entrada de Passageiros");
            Console.WriteLine("3 = Saída de Passageiros");
            Console.WriteLine("4 = Subir andares ");
            Console.WriteLine("5 = Descer andares");
            Console.WriteLine("6 = Status do Elevador");
            Console.WriteLine("0 = Finalizar Programa");
            Console.WriteLine("");



            do
            {
                Console.WriteLine("");
                Console.WriteLine("Qual o Comando ?");
                opcao = int.Parse(Console.ReadLine());
            switch (opcao)
                {
                    case 1: elevador.Inicializar(elevador); break;
                    case 2: elevador.Entrar(elevador); break;
                    case 3: elevador.Sair(elevador); break;
                    case 4: elevador.Subir(elevador); break;
                    case 5: elevador.Descer(elevador); break;
                    case 6: elevador.Status(elevador); break;
                        default: Console.WriteLine("Comando inválido");break;
                }
            } while (opcao!= 0);

            Console.WriteLine("Programa Finalizado pelo Usuário");



        }
    }
}
