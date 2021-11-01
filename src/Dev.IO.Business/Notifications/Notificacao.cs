using System;
using System.Text;
using System.Threading.Tasks;

namespace Dev.IO.Business.Notifications
{
    public class Notificacao
    {
        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }

        public string Mensagem { get;}
    }
}
