using CRUDcomAjax.Models;

namespace CRUDcomAjax.Repositories.Interface
{
    public interface IPessoaRepository
    {
        IEnumerable<Pessoa> Pessoas { get; }

    }
}
