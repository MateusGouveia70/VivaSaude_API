using System;

namespace VivaSaude.API.Exceptions
{
    public class usuarioNaoCadastrado : Exception
    {
        public usuarioNaoCadastrado() : base("Usuário não está cadastrado")
        {

        }
    }
}
