using Microsoft.AspNetCore.Mvc;
using ShareBill.Interface;

namespace ShareBill.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController(ITodoServices todoServices) : ControllerBase
    {
        private readonly ITodoServices _todoServices = todoServices;
    }
}
