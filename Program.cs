//Q1


int[] stockRatesPrices  = new int[] { 5,4,9,2,8,7,7,9,6,8 };

int MaxRevenue(int[] arr) => (arr.Max() - arr.Min());

Console.WriteLine("The maximum revenue is: " + MaxRevenue(stockRatesPrices));


//Q2


var items = new List<StudentCourseGrade>()
            {
                new StudentCourseGrade(){StudentId = 1,CourseId=1123,Grade = 34},
                new StudentCourseGrade(){StudentId = 1,CourseId=1124,Grade = 88},
                new StudentCourseGrade(){StudentId = 2,CourseId=1123,Grade = 65},
            };

//int CoursesPerStudent(int studentId)
//{
//    //var StudentCourses = new List<StudentCourse>();
//    //StudentCourse prodc = new StudentCourse();

//    //foreach (var item in items)
//    //{
//    //    if (StudentCourses.Contains()
//    //}
      

            //   
//}




public class StudentCourseGrade
{
    public int StudentId;
    public int CourseId;
    public int Grade;
}

public class StudentCourse
{
    public int StudentId;
    public List<int> Courses;
}

//Q3
//1:  SELECT Max(Score) FROM Game_tbl Where PlayerId = 2
//2:  Select PlayerId From Players Where NOT EXISTS (select distinct PlayerId from Game_tbl);
//3: SELECT SUM(Score) FROM Game_tbl where ;
