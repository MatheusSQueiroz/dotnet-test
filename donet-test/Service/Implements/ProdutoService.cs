using donet_test.Data;
using donet_test.Model;
using Microsoft.EntityFrameworkCore;

namespace donet_test.Service.Implements
{
    public class ProdutoService : IProdutoService
    {
        private readonly AppDbContext _context;

        public ProdutoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await _context.Produtos.ToListAsync();
        }

        public Task<Produto?> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

            public Task<Produto?> Create(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto?> Update(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto?> Delete(long id)
        {
            throw new NotImplementedException();
        }

    }
}
