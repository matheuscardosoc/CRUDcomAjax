using CRUDcomAjax.Context;
using CRUDcomAjax.Models;
using CRUDcomAjax.Repositories.Interface;

namespace CRUDcomAjax.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly AppDbContext _context;
        public PessoaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Pessoa> Pessoas => _context.Pessoas;
    }
}
