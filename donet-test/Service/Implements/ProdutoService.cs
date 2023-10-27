using donet_test.Model;

namespace donet_test.Service.Implements
{
    public class ProdutoService : IProdutoService
    {
        public Task<Produto?> Create(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto?> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Produto?> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public Task<Produto?> Update(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
