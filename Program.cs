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
                    int opcaoCadastros;
                    do
                    {
                        Console.WriteLine("-----------------");
                        Console.WriteLine("MENU DE CADASTROS");
                        Console.WriteLine("-----------------");
                        Console.WriteLine("1 - Médicos");
                        Console.WriteLine("2 - Animais");
                        Console.WriteLine("3 - Atendimentos");
                        Console.WriteLine("4 - Voltar para o Menu Principal");
                        Console.WriteLine();

                        Console.Write("Selecione uma opção: ");
                        opcaoCadastros = int.Parse(Console.ReadLine());

                        Console.Clear();

                        switch (opcaoCadastros)
                        {
                            case 1:
                                Console.WriteLine("----------------");
                                Console.WriteLine("CADASTRO DE MÉDICOS");
                                Console.WriteLine("----------------");
                                Console.WriteLine("Nome do médico para o cadastro:");
                                string medicoNome = Console.ReadLine();
                                Console.WriteLine("Digite o cpf para o cadastro:");
                                string medicoCpf = Console.ReadLine();

                                Console.WriteLine($"Bem vindo Dr {medicoNome}, portador do CPF:{medicoCpf} seu cadastro foi efetuado!!");
                                break;
                            case 2:
                                Console.WriteLine("----------------");
                                Console.WriteLine("CADASTRO DE ANIMAIS");
                                Console.WriteLine("----------------");
                                Console.WriteLine("Informe o nome do seu animal:");
                                string nomeAnimal = Console.ReadLine();
                                Console.WriteLine("Qual é o seu animal de estimação (cachorro, gato...):");
                                string tipoAnimal = Console.ReadLine();

                                Console.WriteLine($"O seu {tipoAnimal}, com o nome {nomeAnimal} foi cadastrado!!");
                                break;

                            case 3:
                                Console.WriteLine("--------------------");
                                Console.WriteLine("CADASTRO DE ATENDIMENTOS");
                                Console.WriteLine("--------------------");
                                Console.WriteLine("Informe a data desejada para a consulta (dd-mm-YYYY):");
                                string dataConsulta = Console.ReadLine();
                                Console.WriteLine($"Sua consulta foi marcada, para o dia {dataConsulta}");
                                break;

                            case 4:
                                Console.WriteLine("Voltando para o Menu Principal...");
                                break;
                            default:
                                Console.WriteLine("Opção inválida");
                                break;
                        }

                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();

                    } while (opcaoCadastros != 4);

                    break;

                case 2:
                    int opcaoRelatorios;
                    do
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("MENU DE RELATÓRIOS");
                        Console.WriteLine("------------------");
                        Console.WriteLine("1 - Animais");
                        Console.WriteLine("2 - Atendimentos");
                        Console.WriteLine("3 - Voltar para o Menu Principal");
                        Console.WriteLine();

                        Console.Write("Selecione uma opção: ");
                        opcaoRelatorios = int.Parse(Console.ReadLine());

                        Console.Clear();

                        switch (opcaoRelatorios)
                        {
                            case 1:
                                Console.WriteLine("-----------------");
                                Console.WriteLine("RELATÓRIO DE ANIMAIS");
                                Console.WriteLine("-----------------");
                                // Lógica para exibir relatório de animais
                                break;
                            case 2:
                                Console.WriteLine("--------------------");
                                Console.WriteLine("RELATÓRIO DE ATENDIMENTOS");
                                Console.WriteLine("--------------------");
                                // Lógica para exibir relatório de atendimentos
                                break;
                            case 3:
                                Console.WriteLine("Voltando para o Menu Principal...");
                                break;
                            default:
                                Console.WriteLine("Opção inválida");
                                break;
                        }

                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();

                    } while (opcaoRelatorios != 3);

                    break;