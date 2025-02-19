using ETrocas.Models;

namespace ETrocas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Toda vez que tiver um Conjunto finito de valores constantes = Não se alteram 
             Roupa roupa = new Roupa();
             roupa.Categoria = ECategoriaRoupa.Jeans;

            Console.WriteLine("Selecione o tipo da roupa a ser trocada: " + "\n1 - Jeans" +
                " \n2 - Vestido\n3 - Blusa");

            int opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1) {
                roupa.Categoria = ECategoriaRoupa.Jeans;
            }else if (opcao == 2) {
                roupa.Categoria = ECategoriaRoupa.Vestidos;
            }
            Console.WriteLine(roupa.Categoria);
        }
    }
}
