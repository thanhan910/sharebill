using Microsoft.AspNetCore.Mvc;
using ShareBill.Contracts;
using ShareBill.Interface;

namespace ShareBill.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController(ITodoServices todoServices) : ControllerBase
    {
        private readonly ITodoServices _todoServices = todoServices;

        [HttpPost]
        public async Task<IActionResult> CreateTodoAsync(CreateTodoRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                await _todoServices.CreateTodoAsync(request);
                return Ok(new { message = "Blog post successfully created" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the  crating Todo Item", error = ex.Message });

            }
        }
    }
}
