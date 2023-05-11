namespace API.Extensions
{
    public static class ExamGradeExtensions
    {
        public static float CalculateExamGrade(float[] grades)
        {
            float sum = 0;
            foreach (float grade in grades)
            {
                sum += grade;
            }
            return sum;
        }
    }
}