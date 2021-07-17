using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaSaude.Application.Exceptions
{
    public class usuarioNaoCadastrado : Exception
    {
        public usuarioNaoCadastrado() : base("Usuário não está cadastrado na base de dados")
        {

        }
    }
}
