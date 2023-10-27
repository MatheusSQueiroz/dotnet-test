﻿using donet_test.Data;
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

        public async Task<Produto?> GetById(long id)
        {
            try
            {
                var Produto = await _context.Produtos.FirstAsync(p => p.Id == id);
                return Produto;
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<Produto>> GetByNome(string nome)
        {
           var Produto = await _context.Produtos
                .Where(p => p.Nome.Contains(nome))
                .ToListAsync();

            return Produto;
        }

        public async Task<Produto?> Create(Produto produto)
        {

            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();

            return produto;

        }

        public async Task<Produto?> Update(Produto produto)
        {
            var ProdutoUpdate = await _context.Produtos.FindAsync(produto.Id);

            if (ProdutoUpdate is null)
                return null;

            _context.Entry(ProdutoUpdate).State = EntityState.Detached;
            _context.Entry(produto).State = EntityState.Modified;

            return produto;

        }

        public Task<Produto?> Delete(Produto produto)
        {
            throw new NotImplementedException();
        }

    }
}
