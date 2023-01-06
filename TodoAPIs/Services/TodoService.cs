using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using TodoApi.Models;
using TodoAPIs.Model;

namespace TodoAPIs.Services;

public class TodoService: ITodoService
{
    private readonly TodoContext _context;
    
    public TodoService(TodoContext context)
    {
        _context = context;
    }
    public async Task<List<TodoItem>> GetTodoItems()
    {
        return await _context.TodoItems.ToListAsync();
    }
}