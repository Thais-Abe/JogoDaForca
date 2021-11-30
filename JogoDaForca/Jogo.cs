using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    public static class Jogo
    {
       

        
        public static void GanharOJogo(string palavra, int acertos)
        {
            if (acertos == palavra.Length)

            {
                Console.WriteLine("Parabéns! Você Venceu o jogo!! ");
                Console.ReadLine();
            }
        }

        public static void PerderOJogo(int letra)
        {
            //if(letra == 6)  
            if (letra <= 0)
            {
                Console.WriteLine($"Você perdeu! {Environment.NewLine}Tente Novamente!");
                Console.ReadLine();
            }

        }

        public static string Forca(int vidas)
        {
            //simple function to print out the hangman

            string boneco = "";

            if (vidas < 5)
            {
                boneco += "--------\n";
            }

            if (vidas < 4)
            {
                boneco += "       |\n";
            }

            if (vidas < 3)
            {
                boneco += "       O\n";
            }

            if (vidas < 2)
            {
                boneco += "      /|\\ \n";
            }

            if (vidas == 0)
            {
                boneco += "      / \\ \n";
            }

            return boneco;

        }
    }
}


/*
public static void PerdePontos(bool letraI, int tentativasI)
{

    if (letraI == false)
    {
        tentativasI--;
    }
}
*/