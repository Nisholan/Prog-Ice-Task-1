public class StudentInput: Students
{   
    public static getStudentInput()
    {
        List<object> studentInput = new List<object>();  
        students Student = new students();
        string name;
        string course;
        bool decision;
        
       Console.WriteLine("Enter Your Name:");
        name = Console.Read();
        
        Console.WriteLine("Enter Your Course:");
        course = Console.Read();
         
         Console.WriteLine("Are You Employed, Yes or No?");
         decision = Console.Read();

         Student.Name = name;
         Student.CourseName = course;
         Student.Employed = decision;

         studentInput.Add(Student);

    }

}