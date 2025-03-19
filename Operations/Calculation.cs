using DSD601_Student_Marks.DTO;

namespace DSD601_Student_Marks.Operations
{
    public class Calculation
    {


        public string CalcResult(Marks marks)
        {
            float StudentAverage = (marks.Marks1 + marks.Marks2 + marks.Marks3 + marks.Marks4) / 4;


            if (marks.Marks1 > marks.PassMark || marks.Marks2 > marks.PassMark || marks.Marks3 > marks.PassMark || marks.Marks4 > marks.PassMark)
            {
                marks.Pass1 = true;
            }


            if (marks.Marks1 > marks.PassMark && marks.Marks2 > marks.PassMark && marks.Marks3 > marks.PassMark && marks.Marks4 > marks.PassMark)
            {
                marks.PassAll = true;
            }


            if ((marks.Marks1 > marks.PassMark && marks.Marks2 > marks.PassMark && marks.Marks3 > marks.PassMark) || (marks.Marks2 > marks.PassMark && marks.Marks3 > marks.PassMark && marks.Marks4 > marks.PassMark) || (marks.Marks3 > marks.PassMark && marks.Marks4 > marks.PassMark && marks.Marks1 > marks.PassMark) || (marks.Marks4 > marks.PassMark && marks.Marks1 > marks.PassMark && marks.Marks2 > marks.PassMark))
            {
                marks.Pass3 = true;
            }


            marks.Result = marks.Name + " Pass 1 = " + marks.Pass1 + ". Pass All = " + marks.PassAll + ". Pass 3 = " + marks.Pass3 + ".  Student Average = " + StudentAverage;


            StaticList.StaticStudentResults?.Add(marks.Result);


            //  marks.StudentResults.AddRange(StaticList.StaticStudentResults);
            return marks.Result;


        }




    }

}
