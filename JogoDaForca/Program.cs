using System;
using System.Configuration;
using System.IO;

namespace JogoDaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string escolhaDoJogador;
            ConfiguracoesDoUsuario configUsuario = new ConfiguracoesDoUsuario();
            configUsuario.CarregarConfiguracoes();
            
            UsuarioConfigCorDeFundo.RetornaCorDaLetra(configUsuario.CorDaLetra);
            UsuarioConfigCorDeFundo.RetornaCorDeFundo(configUsuario.CorDeFundo);
            /*
            Config config = new Config();
            UsuarioConfigCorDeFundo.RetornaCorDaLetra(config.CorDaLetra);
            UsuarioConfigCorDeFundo.RetornaCorDeFundo(config.CorDeFundo);
            */
            /*
             Configuration configa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
             Console.WriteLine("Caminho de config do usuário local: {0}", configa.FilePath);
             Console.ReadLine();
             */



            do
            {

                Console.WriteLine($"**************************");
                Console.WriteLine("| J O G O  D A  F O R C A |");
                Console.WriteLine($"**************************");
                Console.WriteLine("1 - Jogar ");
                Console.WriteLine("2 - Customizar aplicação ");
                Console.WriteLine("3 - Sair");
                escolhaDoJogador = Console.ReadLine();

                if (escolhaDoJogador != "1" && escolhaDoJogador != "2" && escolhaDoJogador != "3")
                {
                    Console.WriteLine("Favor digite 1 ou 2 para começar a brincar =], ou 3 para sair =[ ");
                    Console.ReadLine();
                    Console.Clear();
                }
                
                      
                Console.Clear();

                switch (escolhaDoJogador)
                {
                    case "1":
                        //PalavrasDoJogo palavra = new PalavrasDoJogo();
                        //Jogo jogo = new Jogo();
                        var listaTxt = PalavrasDoJogo.MostrarPalavrasDoTxt();//retorna 1 lista
                        string palavraDoJogo = PalavrasDoJogo.SortearPalavraDoTxt(listaTxt);//retorna 1 palavra
                        char[] letrasDaPalavra = palavraDoJogo.ToCharArray();//transformando a palavra em um array de letras
                        char[] cadaEspaco = palavraDoJogo.ToCharArray();

                        for (int i = 0; i < palavraDoJogo.Length; i++)
                        {
                            cadaEspaco[i] = '_';
                        }

                        int acertos = 0;
                            
                        int tentativas = 6;

                        while (tentativas > 0 && acertos != palavraDoJogo.Length)
                        {

                            Console.Write(Jogo.Forca(tentativas));
                            Console.WriteLine("   ");
                            Console.Write(cadaEspaco);
                            Console.Write("(" + cadaEspaco.Length + " letras)" + Environment.NewLine);
                            Console.WriteLine("Total de tentativas: " + tentativas);
                            string ler;

                            do
                            {
                                Console.WriteLine("Digite uma letra: ");
                                ler = Console.ReadLine().ToLower();

                                PalavrasDoJogo.SelecionarSoLetras(ler); 
                       
                           } while (ler.Length != 1 );
  
                                char letraEscolhida = Convert.ToChar(ler);


                            for (int i = 0; i < palavraDoJogo.Length; i++)
                            {
                                if (cadaEspaco[i] == letraEscolhida)
                                {
                                    Console.Write("Letra já digitada -- aperte qualquer tecla para voltar");
                                   
                                    Console.ReadKey();

                                }
                                else if (letraEscolhida == letrasDaPalavra[i])

                                {
                                    cadaEspaco[i] = letraEscolhida;
                                    
                                    acertos++;

                                }
   
                            }
                     
                                if (palavraDoJogo.IndexOf(letraEscolhida) == -1)
                                {
                                    tentativas--;
                                    
                                }

                                
                            Jogo.PerderOJogo(tentativas);
                            Jogo.GanharOJogo(palavraDoJogo, acertos);
                            Console.Clear();
                        }

                                         break;
                
                    case "2":
                        string opcaoDeFundo;
                        do
                        {
                            Console.WriteLine("Escolha a Cor de fundo desejada :");
                            UsuarioConfigCorDeFundo.RetornaOpcoes();
                            opcaoDeFundo = Console.ReadLine();

                            if(opcaoDeFundo != "1" && opcaoDeFundo != "2" && opcaoDeFundo != "3" && opcaoDeFundo != "4" && opcaoDeFundo != "5" && opcaoDeFundo != "6")
                            {
                                Console.WriteLine("Digite apenas as opções de 1 a 6");
                            }

                        }
                        while (opcaoDeFundo != "1" && opcaoDeFundo != "2" && opcaoDeFundo != "3" && opcaoDeFundo != "4" && opcaoDeFundo != "5" && opcaoDeFundo != "6");
                        /* config.CorDeFundo = opcaoDeCorDeLetra;
                       config.Salvar();
                        */
                        configUsuario.CorDeFundo = opcaoDeFundo;    
                        configUsuario.GuardarConfiguracoes();   

                        UsuarioConfigCorDeFundo.RetornaCorDeFundo(opcaoDeFundo);
                        Console.Clear();

                       string opcaoDeCorDeLetra;
                       do
                       {
                           Console.WriteLine("Agora esolha a cor da letra desejada: ");
                           UsuarioConfigCorDeFundo.RetornaOpcoes();
                            opcaoDeCorDeLetra = Console.ReadLine();

                           if (opcaoDeCorDeLetra != "1" && opcaoDeCorDeLetra != "2" && opcaoDeCorDeLetra != "3" && opcaoDeCorDeLetra != "4" && opcaoDeCorDeLetra != "5" && opcaoDeCorDeLetra != "6")
                           {
                               Console.WriteLine("Digite apenas as opções de 1 a 6");
                           }
                       }
                       while (opcaoDeCorDeLetra != "1" && opcaoDeCorDeLetra != "2" && opcaoDeCorDeLetra != "3" && opcaoDeCorDeLetra != "4" && opcaoDeCorDeLetra != "5" && opcaoDeCorDeLetra != "6");
                      /* config.CorDaLetra = opcaoDeCorDeLetra;
                       config.Salvar();
                      */
                        configUsuario.CorDaLetra = opcaoDeCorDeLetra;
                        configUsuario.GuardarConfiguracoes();  

                        UsuarioConfigCorDeFundo.RetornaCorDaLetra(opcaoDeCorDeLetra);
                        Console.Clear();
                                                break;

                    case "3":

                        Console.WriteLine("Saindo da aplicação.... Volte logo!");
                        Console.ReadLine();
                                                 break;

                }
            } while (escolhaDoJogador != "3");
        }
       
    }
}
