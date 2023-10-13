//using Service.Service;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DLL_Namespace_Abstraction.Controller
//{
    //internal class StudentController
    //{
    //    private readonly StudentService _studentService;
    //    public StudentController()
    //    {
    //        _studentService = new StudentService();
    //    }
    //    public void GetAllStudents()
    //    {
    //     var students = _studentService.GetAllStudents();
    //        foreach (var item in students)
    //        {
    //            string result = $"{item.FullName} - {item.Age} - {item.Email}";
    //            Console.WriteLine(result);
    //        }   

    //    }

    //    public void GetStudentById()
    //    {
    //        var student = _studentService.GetById(3);
    //        string result = $"{student.FullName} - {student.Age} - {student.Email}";
    //        Console.WriteLine(result);
    //    }
    //    public void AverageOfStudentAge()
    //    {
    //        var students = _studentService.GetAllStudents();

    //        var averageAge = students.Average(m => m.Age);

    //        Console.WriteLine(averageAge);
    //    }


    //}
//}
