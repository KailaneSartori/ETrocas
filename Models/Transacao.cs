using ETrocas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrocas.Models {
    internal class Transacao {
        public int IdTransacao { get; set; }
        public DateTime DataReserva { get; set; }

        public DateTime DataTroca { get; set; }

        public DateTime DataCancelamento { get; set; }
        public string MotivoCancelamento { get; set; }

        public DateTime DisponivelAte { get; set; }

        public Produto Produto { get; set; }

        public Usuario Usuario { get; set; }

        public string ExibirDados() {
            return "";
        }
        private Repository<Produto> repositoryProdutos;
        private Repository<Usuario> repositoryUsuarios;

        public void AdicionarProdutos(Produto produto) {
            repositoryProdutos.Add(produto);
        }
        public void AdicionarUsuario(Usuario usuario) {
            repositoryUsuarios.Add(usuario);
        }

    }
}
