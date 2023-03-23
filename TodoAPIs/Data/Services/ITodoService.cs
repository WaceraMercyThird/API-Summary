using TodoAPIs.Model;

namespace TodoAPIs.Services;

public interface ITodoService
{ 
   //Get All
    public Task<List<TodoItem>> GetTodoItems();

    public Task<TodoItem> GetTodoItem(long id);
    
    
    
    
    
   
    



}