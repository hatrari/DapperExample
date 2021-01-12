using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DapperExample.Repositories
{
  public class ItemRepo : IItemRepo
  {
    private readonly SqlConnection _connection;
    
    public ItemRepo(IConfiguration configuration)
    {
      var connectionString = configuration["mysqlconnection:connectionString"];
      _connection = new SqlConnection(connectionString);
    }
    
    public string Get()
    {
      return "Get from repo...";
    }

    public async Task<IEnumerable<string>> GetAsync()
    {
      string sql = "SELECT TOP 10 * FROM Items";
      var items = _connection.Query<string>(sql);
      return items.AsList();
    }
  }
}