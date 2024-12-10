internal class Classroom
{
    public string classId;
    public string className;
    public List<Student> students;

    // 1. Class
    // create Classroom to manage class
    // classId
    // className
    // student in class

    // constructor
    public Classroom(string classId, string className)
    {
        this.classId = classId;
        this.className = className;
        students = new List<Student>();
    }

    // add method to add student
    public void addStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine($"Student {student.studentName} added to class {className} ");
    }

    // show method to print student
    public void showStudents()
    {
        Console.WriteLine($"\n ----Students in class {className} ----");
        foreach (var student in students) student.DisplayInfo();
    }

    // find method based on student ID
    public void findStudentByStudentId(string studentId)
    {
        // 1. use foreach
        foreach (var student in students)
            if (student.studentId == studentId)
            {
                student.DisplayInfo();
                return;
            }

        // catch not found
        Console.WriteLine($"Student with ID {studentId} not found in class {className}");
    }
}