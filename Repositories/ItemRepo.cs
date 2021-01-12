namespace DapperExample.Repositories
{
  public class ItemRepo : IItemRepo
  {
    public string Get()
    {
      return "Get from repo...";
    }
  }
}