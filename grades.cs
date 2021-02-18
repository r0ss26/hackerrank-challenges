class Result 
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        var result = new List<int>();
        for (var i = 0; i < grades.Count; i++)
        {
            var grade = grades[i];
            int roundedGrade;
            
            var differenceOfGradeAndNextMultiple = 5 - (grade % 5);
            if (grade < 38 || differenceOfGradeAndNextMultiple > 2)
            {
                roundedGrade = grade;
            } else
            {
                roundedGrade = grade + differenceOfGradeAndNextMultiple;
            }       
            result.Add(roundedGrade);
        }
        return result;
    }
}