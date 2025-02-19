using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrocas.Models {
    public abstract class Produto {
        public string Nome {  get; set; }
        public string Descricao { get; set; }
        public string Genero { get; set; }
        public string Foto { get; set; }
        public bool Status { get; set; }

        public abstract void ExibirDados();
        public virtual string ExibirDadosProduto() {

            return "Dados do produto" +
                "\n------------------------" +
                "\nNome: " + Nome +
                "\n Descrição: " + Descricao +
                "\n Genero: " + Genero +
                "\n Status: " + Status;
        }
    }
}
