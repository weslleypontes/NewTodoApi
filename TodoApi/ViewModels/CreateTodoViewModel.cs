using System.ComponentModel.DataAnnotations;

namespace TodoApi.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string? Name { get; set; }

        //Microsoft.VisualStudio.Web.CodeGeneration.Design
        //Microsoft.EntityFrameworkCore.SqlServer
    }
}
