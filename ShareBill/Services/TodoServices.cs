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

        public Task CreateTodoAsync(CreateTodoRequest request)
        {
            throw new NotImplementedException();
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