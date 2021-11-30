using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    public class ConfiguracoesDoUsuario
    {
        public string CorDeFundo { get; set; }
        public string CorDaLetra { get; set; }
        
        public void CarregarConfiguracoes()
        {
            string[] arquivo = File.ReadAllLines("config.user");
            CorDeFundo = arquivo[0];
            CorDaLetra = arquivo[1];
        }

        public void GuardarConfiguracoes()
        {
            File.WriteAllText("config.user", CorDeFundo + Environment.NewLine + CorDaLetra);    
        }
    }
}
