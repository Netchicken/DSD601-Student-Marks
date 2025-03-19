using DSD601_Student_Marks.DTO;
using DSD601_Student_Marks.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace DSD601_Student_Marks.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {


        public Marks marks { get; set; }


        [Display(Name = "Student Results")]
        public List<string>? StudentResults;


        [Display(Name = "Student Results")]
        public string StudentResult { get; set; }


        public IndexModel()
        {
            StudentResults = new List<string>();
        }




        public void OnPost()
        {
            //new up an instance of the Operations Class
            Calculation calculation = new Calculation();


            StudentResult = calculation.CalcResult(marks);


            // StudentResults.AddRange(StaticList.StaticStudentResults);





        }
    }
}