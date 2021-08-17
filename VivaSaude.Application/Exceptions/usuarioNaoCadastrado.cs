using System;

namespace VivaSaude.Application.Exceptions
{
    public class usuarioNaoCadastrado : Exception
    {
        public usuarioNaoCadastrado() : base("Usuário não está cadastrado na base de dados")
        {

        }
    }
}
