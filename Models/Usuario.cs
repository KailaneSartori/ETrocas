using ETrocas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrocas.Models {
    internal class Usuario : IAutenticavel {
        public string Nome  { get; set; }
        public string Telefone { get; set; }
        public string Email  { get; set; }
        public string Senha  { get; set; }
        public string Apelido { get; set; }

        public bool Autenticar(string usarname, string password) {
            if (usarname == null || password == null)
                throw new ArgumentNullException("Favor digitar usuario e senha");
            else {
                return true;
            }
        }
        public string ExibirDados() {
            return "Usuario " + Nome;

        }
    }
}
