using Model;
using View;

namespace Controller
{
    public class ProdutoController
    {
        // Instanciamos as duas classes para o controller ter as informações delas
        Produto produtos = new Produto();
        ProdutoView ver = new ProdutoView();

        public void Listar()
        {
            ver.Write( produtos.Read() );
        }

        public void escrever()
        {
            produtos.inserir( ver.quest() );
        }
        
    }
}