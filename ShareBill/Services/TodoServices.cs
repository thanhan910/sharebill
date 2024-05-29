using AutoMapper;
using ShareBill.Contracts;
using ShareBill.Interface;
using ShareBill.Models;
using ShareBill.AppDataContext;

namespace ShareBill.Services
{
    public class TodoServices(TodoDbContext context, ILogger<TodoServices> logger, IMapper mapper) : ITodoServices
    {
        private readonly TodoDbContext _context = context;
        private readonly ILogger<TodoServices> _logger = logger;
        private readonly IMapper _mapper = mapper;

        public async Task CreateTodoAsync(CreateTodoRequest request)
        {
            try
            {
                var todo = _mapper.Map<Todo>(request);
                todo.CreatedAt = DateTime.UtcNow;
                _context.Todos.Add(todo);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the Todo item.");
                throw new Exception("An error occurred while creating the Todo item.");
            }
        }

        public Task DeleteTodoAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Todo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Todo> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTodoAsync(Guid id, UpdateTodoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}