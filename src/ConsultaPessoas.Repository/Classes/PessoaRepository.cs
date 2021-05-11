using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ConsultaPessoas.Domain.Interfaces;
using Dapper;
using main;
using Microsoft.Extensions.Configuration;

namespace ConsultaPessoas.Repository.Classes
{
    public sealed class PessoaRepository : IPessoaRepository
    {
        private readonly IConfiguration _configuration;

        public PessoaRepository(IConfiguration configuration) => _configuration = configuration;

        public async Task<IEnumerable<Pessoa>> ObterTodos()
        {
            using(SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                return await conn.QueryAsync<Pessoa>("select * from pessoas");
            }
        }
    }
}
