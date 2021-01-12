using Microsoft.AspNetCore.Mvc;
using DapperExample.Repositories;

namespace DapperExample.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ItemsController : ControllerBase
  {
    private readonly IItemRepo _itemRepo;

    public ItemsController(IItemRepo itemRepo)
    {
      _itemRepo = itemRepo;
    }
    
    [HttpGet]
    public string Get()
    {
      return _itemRepo.Get();
    }
  }
}