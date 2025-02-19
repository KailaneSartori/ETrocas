using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrocas.Models {
    internal class Roupa : Produto {
        public string Material { get; set; }
        public ECategoriaRoupa Categoria {  get; set; }
        public ETamanhoRoupa Tamanho { get; set; }
        public EComprimentoRoupa Comprimento { get; set; }

    }
}
