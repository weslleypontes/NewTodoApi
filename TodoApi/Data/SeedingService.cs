using Microsoft.EntityFrameworkCore;
using Models;
namespace Data
{
    public class SeedingService
    {


        public static void SeedAsync(IServiceProvider serviceProvider)
        {
            /*using (var context = new TodoContext(
                serviceProvider.GetRequiredService<DbContextOptions<TodoContext>>()))
            {
                if (context.TodoItens.Any())
                {
                    return;
                }
                else
                {

                    TodoItem ti1 = new TodoItem(new int(), "arroz", true);
                    TodoItem ti2 = new TodoItem(new int(), "macarrão", true);
                    TodoItem ti3 = new TodoItem(new int(), "feijão", true);
                    TodoItem ti4 = new TodoItem(new int(), "goiaba", true);
                    TodoItem ti5 = new TodoItem(new int(), "banana", true);

                    context.TodoItens.AddRange(ti1, ti2, ti3, ti3, ti4, ti5);

                    context.SaveChanges();

                }
            }*/
        }
    }
}
