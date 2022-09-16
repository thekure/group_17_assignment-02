using Assignment2.NewClassLib;

namespace Assignment2.Tests;

public class StudentTests
{
    [Fact]
    public void Test1()
    {
        var students = new List<Student>();
        students.Add(new Student {id = 0, givenName = "Jens", surname = "Hansen", startDate = new DateTime(2017), endDate = new DateTime(2020), graduationDate = new DateTime(2020)});
        foreach(Student s in students){
            Console.WriteLine(s.ToString());
        }
        
    }
}
