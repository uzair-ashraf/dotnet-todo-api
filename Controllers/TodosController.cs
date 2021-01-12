using System.Collections.Generic;
using TodoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
  // /api/todos <-- Takes the controllers name
  [Route("api/[controller]")]
  // Decorator, like override in Dart
  [ApiController]
  public class TodosController : ControllerBase
  {
    // GET /api/todos
    [HttpGet]
    public ActionResult <IEnumerable<Todo>> GetAllTodos()
    {
      var todos = new List<Todo>
      {
        new Todo{
          Id = 0,
          Name = "My Todo",
          Description = "Example Todo",
          IsComplete = false
        },
        new Todo{
          Id = 1,
          Name = "Your Todo",
          Description = "Example Todo Desc",
          IsComplete = true
        }
      };
      return Ok(todos);
    }
    // GET /api/todos/{id} <-- id is identified by the parameter
    [HttpGet("{id}")]
    public ActionResult <Todo> GetTodoById(int id)
    {
      var todo = new Todo
      {
        Id = 1,
        Name = "Your Todo",
        Description = "Example Todo Desc",
        IsComplete = true
      };
      return Ok(todo);
    }
  }
}
