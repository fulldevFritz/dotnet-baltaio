using System;

namespace EditorHtml{
    public static class Menu{

        public static void Show(){
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;

            int width = 30;
            int height = 10;
            DrawScreen(width, height);

            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }

        public static void DrawScreen(int width, int height){
            Extremities(width);
            body(width, height);
            Extremities(width); 
        }

        static void Extremities(int width){
            Console.Write("+");
            for(int columns = 0; columns<=width; columns++){
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n"); 
        }

        static void body(int width, int height){
            for (int lines = 0; lines <= height; lines++)
            {
                Console.Write("|");
                for(int columns = 0; columns<=width; columns++){
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
        public static void WriteOptions(){
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opcao");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Novo Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option){
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0: {
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }

}