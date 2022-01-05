using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.MODEL
{
    public class Elevador
    {
        // Declaração das  caracteristicas do elevador
        public int numeroDeAndares = 0; // Numero de Andares Total do Edificio

        public int Capacidade = 0; // Capacidade Total de passageiros

        public int andarAtual = 0; // Andar no qual se encontra o Elevador

        public int pessoasDentro = 0; //Numero de passageiros no Elevador

        //Métodos

        public void Inicializar(Elevador elevador) // Método para inicializar um novo elevador ou resetar caso ja inicializado.
        {
            elevador.pessoasDentro = 0;
            elevador.andarAtual =0; 

            Console.WriteLine("Qual o numero de andares ?");
            elevador.numeroDeAndares = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a capacidade Máxima ?");
            elevador.Capacidade = int.Parse(Console.ReadLine());
            

        }
        public void Entrar(Elevador elevador) // Método para adicionar pessoas ao elevador
        {
            Console.WriteLine("Quantas pessoas vão entrar ?");
            int passageiros = int.Parse(Console.ReadLine());
            if (passageiros + elevador.pessoasDentro > elevador.Capacidade) // verifica se não  excede a capacidade
            {
                Console.WriteLine("Excedeu a capacidade !");

            } else
            {
                elevador.pessoasDentro = elevador.pessoasDentro + passageiros;
            }

        }
        public void Sair(Elevador elevador) // Método para retirar pessoas do elevador
        {
            Console.WriteLine("Quantas pessoas vão sair ?");
            int passageiros = int.Parse(Console.ReadLine());
            if ( elevador.pessoasDentro - passageiros < 0) // verifica se não  excede a capacidade
            {
                Console.WriteLine("Numero superior ao de ocupantes");

            }
            else
            {
                elevador.pessoasDentro = elevador.pessoasDentro - passageiros;
            }
        }
        public void Subir(Elevador elevador) // Método para alterar o andar de forma  positiva
        {
            Console.WriteLine("Quantas andares para subir ?");
            int andares = int.Parse(Console.ReadLine());
            if (elevador.andarAtual + andares > elevador.numeroDeAndares) // verifica se não  excede a capacidade
            {
                Console.WriteLine("Subida Inválida, excedeu numero de andares");
            } else
            {
                elevador.andarAtual = elevador.andarAtual + andares;
            }
        }
        public void Descer(Elevador elevador) // Método para alterar o andar de forma  negativa
        {
            Console.WriteLine("Quantas andares para descer ?");
            int andares = int.Parse(Console.ReadLine());
            if (elevador.andarAtual - andares < 0) // verifica se não  excede a capacidade
            {
                Console.WriteLine("Descida Inválida, excedeu numero de andares");
            }
            else
            {
                elevador.andarAtual = elevador.andarAtual - andares;
            }
        }
        public void Status (Elevador elevador) // Método para verificar onde se encontra o Elevador e com quantos passageiros
        {
            Console.WriteLine("O Elevador está no " + elevador.andarAtual + " andar, com " + elevador.pessoasDentro + " pessoas dentro.");
        }
    }
}
