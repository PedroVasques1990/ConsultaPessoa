using System.Collections.Generic;
using System.Threading.Tasks;
using main;

namespace ConsultaPessoas.Domain.Interfaces
{
    public interface IPessoaRepository
    {
         Task<IEnumerable<Pessoa>> ObterTodos();
    }
}