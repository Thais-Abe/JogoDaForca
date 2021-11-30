using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace JogoDaForca
{
    public static class PalavrasDoJogo
    {
        

        public static List<string> MostrarPalavrasDoTxt()
        {
            var caminhoDoArquivo = ConfigurationManager.AppSettings["palavrasParaJogar"];

            string[] linhas = File.ReadAllLines(caminhoDoArquivo);

            List<string> palavras = new List<string>();

            foreach (string linha in linhas)
            {

                palavras.Add(linha);
            }

            return palavras;

        }

        public static string SortearPalavraDoTxt(List<string> nomes)
        {
            var rand = new Random();

            var palavraAleatoria = nomes[rand.Next(nomes.Count())];
            return palavraAleatoria;
        }

        public static void SelecionarSoLetras(string ler)
        {
            try
            {

                char palavraChar = Convert.ToChar(ler);
                bool letra = char.IsLetter(palavraChar);

                if (letra == false)
                {
                    throw new Exception("Somente letras são permitidas ");
                }

            }
            catch (Exception)
            {


                Console.WriteLine("Somente letras são permitidas ");
                Console.ReadKey();
                Console.Clear();
            }
        }
    /*public void ValidadorPalavra(string letra)
    {

        if (char.IsLetter(letra))
        {
            Console.WriteLine(letra);
        }
        else
        {
            Console.WriteLine("Informe um caracter válido");
            Console.ReadLine();

        }

    }

    */


}
}
