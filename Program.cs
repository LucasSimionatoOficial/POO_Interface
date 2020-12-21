using System;
using POO_Interface.classes;

namespace POO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            Produto alteracao = new Produto();
            while (a){
                Console.WriteLine("Digite qual operação você deseja fazer");
                Console.WriteLine("Digite 1 para adicionar produtos\nDigite 2 para remover produtos\nDigite 3 para ver os produtos listados\nDigite 4 para alterar um produto\n");
                switch (Console.ReadLine()){
                    case "1":
                        Console.WriteLine("Digite o nome do produto");
                        Console.WriteLine("Digite o código do produto");
                        Console.WriteLine("Digite o preço do produto");
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
