using System.ComponentModel.DataAnnotations;

namespace DSD601_Student_Marks.DTO
{
    public class Marks
    {

        [Display(Name = "Marks 1")]
        public Single Marks1 { get; set; } = 54;

        [Display(Name = "Marks 2")]
        public float Marks2 { get; set; } = 45;

        [Display(Name = "Marks 3")]
        public float Marks3 { get; set; } = 45;

        [Display(Name = "Marks 4")]
        public float Marks4 { get; set; } = 34;

        [Required(ErrorMessage = "Pass Mark is required.")]
        [Display(Name = "Pass Mark")]
        public float PassMark { get; set; } = 50;

        [Display(Name = "All Student Average")]
        public float StudentAverage { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = "Grendal";

        [Display(Name = "Pass 1 ")]
        public bool Pass1 { get; set; }

        [Display(Name = "Pass All")]
        public bool PassAll { get; set; }
        [Display(Name = "Pass 3")]
        public bool Pass3 { get; set; }

        [Display(Name = "Student Result")]
        public string Result { get; set; }

    }
}
