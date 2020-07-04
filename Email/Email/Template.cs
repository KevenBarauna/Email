using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    class Template
    {
       

        public String GetMensagemHtml()
        {
            String mensagem = "<strong>Atenção:</strong> <br><br> essa é uma mensagem de teste com HTML";

            return mensagem;
        }

        public String GetMensagem()
        {
            String mensagem = @"Olá, essa é uma mensagem enviada pelo C# do projeto de estudo de Keven Baraúna. Vlw ;)";

            return mensagem;
        }
    }
}
