using TodoAPIs.Model;

namespace TodoAPIs.Services;

public interface ITodoService
{ 
    public Task<List<TodoItem>> GetTodoItems();
}