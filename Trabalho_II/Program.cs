using System;

class Program
{
    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("--------------");
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("--------------");
            Console.WriteLine("1 - Cadastros");
            Console.WriteLine("2 - Relatórios");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine();

            Console.Write("Selecione uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("-----------------");
                    Console.WriteLine("MENU DE CADASTROS");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("1 - Médicos");
                    Console.WriteLine("2 - Animais");
                    Console.WriteLine("3 - Atendimentos");
                    Console.WriteLine("4 - Voltar para o Menu Principal");
                    break;
                case 2:
                    Console.WriteLine("------------------");
                    Console.WriteLine("MENU DE RELATÓRIOS");
                    Console.WriteLine("------------------");
                    Console.WriteLine("1 - Animais");
                    Console.WriteLine("2 - Atendimentos");
                    Console.WriteLine("3 - Voltar para o Menu Principal");
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        } while (opcao != 0);

        Console.WriteLine("Programa encerrado.");
    }
}