using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivaSaude.API.Exceptions
{
    public class usuarioNaoCadastrado : Exception
    {
        public usuarioNaoCadastrado() : base("Usuário não está cadastrado")
        {

        }
    }
}
