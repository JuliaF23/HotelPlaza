using System.Data;

namespace HotelPlaza.Models
{
    public class Usuario : Interface
    { 
        public Usuario(string nome, string email)
        {
            if (nome.Length < 2)
            {
                throw new Exception($"O nome {nome} tem que ter mais do que 2 caracteres");
            }
            Nome = nome;
            Email = email;
        }

        private string Nome { get; set; }

        protected string Email { get; set; }

        internal DataSetDateTime DtNasc { get; set; }

        public string RecuperarNome()
        {
            return $"O nome do usuario é: {Nome} {Email}";
        }

        public virtual void Logar()
        {
           
        }

        public void Deslogar()
        {
            
        }

    }
}
