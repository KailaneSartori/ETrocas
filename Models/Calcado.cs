using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ETrocas.Models {
    internal class Calcado : Produto {
        public string Material { get; set; }

        public ECategoriaCalcado Categoria { get; set; }
        public ETipoAjuste TipoAjuste { get; set; }
        public ETamanhoCalcado TamanhoCalcado { get; set; }

        public override void ExibirDados() {
            Console.WriteLine("Dados do produto" +
                "\n------------------------" +
                "\nNome: " + Nome +
                "\n Descrição: " + Descricao +
                "\n Genero: " + Genero +
                "\n Status: " + Status +
                 "\n Material: " + Material
            );
            
        }
        public override string ExibirDadosProduto() {
            string mensagem = base.ExibirDadosProduto();
            mensagem += "\nMaterial: " + Material + "\nTamanho" + TamanhoCalcado;
            return mensagem;
        }
    }
}
