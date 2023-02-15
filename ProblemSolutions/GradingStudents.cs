namespace GradingStudents
{
    internal class GradingStudents
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> grades = new List<int>();
            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }
            gradingStudents(grades).ForEach(x => Console.WriteLine(x));
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> students = new List<int>();
            grades.ForEach(grade =>
            {
                students.Add(grade >= 38 && grade % 5 >= 3 ? grade = grade + 5 - grade % 5 : grade);              
            });
            return students;
        }
    }
}