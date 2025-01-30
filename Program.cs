namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao TextEditor!");
            Console.WriteLine("O que você quer fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case: 0 System.Environment.Exit(0); 
            }
        }
        
        static void AbrirTextEditor() {}
        static void FecharTextEditor() {}
        
    }
}