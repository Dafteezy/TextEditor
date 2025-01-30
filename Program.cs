﻿namespace TextEditor
{
    class Program
    {
        private static bool _sairDoApp = false;
        static void Main(string[] args)
        {
            while (!_sairDoApp)
            {
                Menu();
            }
        }

        static void Menu()
        {
            Console.Clear();
            ExibirCabecalho("EDITOR DE TEXTO");
            
            Console.WriteLine("Bem vindo ao TextEditor!");
            Console.WriteLine("O que você quer fazer?");
            Console.WriteLine("1 - Abrir arquivo existente");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("---------------------------");
            
            if (!short.TryParse(Console.ReadLine(), out short opcao))
            {
                ExibirMensagemErro("Opção inválida!");
                return;
            }
            
            switch (opcao)
            {
                case 0: 
                    _sairDoApp = true;
                    break;
                case 1: 
                    Abrir();
                    break;
                case 2: 
                    Editar();
                    break;
                default:
                    ExibirMensagemErro("Opção inválida!");
                    break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("--------------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } 
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            
            Salvar(text);
            
            


        }
        
        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            
            Console.WriteLine($"O arquivo {path} foi atualizado com sucesso!");
            Console.ReadKey();
            Menu();
        }
        
        static void ExibirMensagemErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nErro: {mensagem}");
            Console.ResetColor();
            Thread.Sleep(3000);
        }
        
        static void ExibirCabecalho(string titulo)
        {
            Console.WriteLine("====================================");
            Console.WriteLine($" {titulo}");
            Console.WriteLine("====================================");
            Console.WriteLine();
        }

        
    }
}