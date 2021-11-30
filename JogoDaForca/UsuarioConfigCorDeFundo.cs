using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    public class UsuarioConfigCorDeFundo
    {
       
        public static void RetornaOpcoes()
        {
            
            Console.WriteLine($" 1-Preto { Environment.NewLine} 2-Branco { Environment.NewLine} 3-Amarelo { Environment.NewLine} 4-Verde { Environment.NewLine} " +
                $"5-Vermelho { Environment.NewLine} 6-Azul");
            
           // Console.WriteLine($" 1-Preto  2-Branco  3-Amarelo  4-Verde 5-Vermelho  6-Azul{ Environment.NewLine}");
        }
        public static void RetornaCorDeFundo(string opcaoDeCor)
        {
            
            switch (opcaoDeCor)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                case "2":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                case "3":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
                case "4":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                case "5":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case "6":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
            }
        }
        public static void RetornaCorDaLetra(string opcaoDeCor)
        {

            switch (opcaoDeCor)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
                case "4":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                case "5":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case "6":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
            }
        }
    }
}

