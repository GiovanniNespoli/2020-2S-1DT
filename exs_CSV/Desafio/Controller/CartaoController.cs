using Model;
using View;

namespace Controller
{
    public class CartaoController
    {
        Cartao cartao = new Cartao();
        CartaoView cartaoView = new CartaoView();

        public CartaoController()
        {
            cartao.inserir( cartaoView.perguntas() );
        }

        public void Listar()
        {
            cartaoView.list( cartao.ler() );
        }
    }
}