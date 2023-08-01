using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Data;
using TodoApi.ViewModels;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class TodoItemsController : ControllerBase
    { 
        // GET: api/todos
        [HttpGet]
        [Route("todos")]
        public async Task<ActionResult> GetAsync(
            [FromServices] TodoContext context)
        {
          /*if (context.TodoItens == null)
          {
              return NotFound();
          }*/
          var todos = await context.TodoItens.AsNoTracking().ToListAsync();
            return Ok(todos);
        }

        // GET: api/TodoItems/5
        [HttpGet]
        [Route("todos/{id}")]
        public async Task<ActionResult> GetByIdAsync(
            [FromServices] TodoContext context,
            [FromRoute]int id)
        {
            /*if (context.TodoItens == null)
            {
                return NotFound();
            }*/
            var todo = await context.TodoItens.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return todo == null 
                ? NotFound() 
                : Ok(todo);
        }

        [HttpPost("todos")]
        public async Task<IActionResult> PostAsync(
            [FromServices] TodoContext context,
            [FromBody] CreateTodoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var todo = new TodoItem
            {
               Name = model.Name,
               IsComplete = false
            };
            try
            {
                await context.TodoItens.AddAsync(todo);
                await context.SaveChangesAsync();
                return Created($"api/todos/{todo.Id}", todo);
            }catch (Exception ex)
            {
                return BadRequest();
            }

        }


    }
}
