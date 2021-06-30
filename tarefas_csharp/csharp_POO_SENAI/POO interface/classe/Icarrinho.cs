namespace POO_interface.classe
{
    public interface Icarrinho
    {
         void Listar();
         void produtos(Produto x, Produto y, Produto c);
         void Cadastrar( Produto x);
         void Alterar(int x, Produto xy);
         void delete( int x);
         void precoTotal();
    }
}