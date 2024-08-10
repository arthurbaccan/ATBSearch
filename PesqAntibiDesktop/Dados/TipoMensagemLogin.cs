using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    
    public enum TipoMensagemLogin
    {
        LOGIN_INCORRETO = 0,
        LOGIN_SUCESSO = 1,
        USERNAME_NAO_EXISTE = 2,
        CONTA_NAO_E_PRO = 3,
        LOGIN_VAZIO = 4,
        SENHA_INCORRETA = 5,
        SEM_CONEXAO_INTERNET = 6,
        USUARIO_NAO_EXISTE = 7
    }
}
