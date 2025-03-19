using DSD601_Student_Marks.DTO;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSD601_Student_Marks.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {


        public Marks marks { get; set; } = new Marks();

        public void OnGet()
        {

        }
    }
}
