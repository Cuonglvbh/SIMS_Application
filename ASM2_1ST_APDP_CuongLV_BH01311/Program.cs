using ASM2_1ST_APDP_CuongLV_BH01311;

class Program
{
    static void Main(string[] args)
    {
        // Create some departments
        Department computerScience = new Department { DepartmentName = "Engineering" };
        Department literature = new Department { DepartmentName = "Arts" };

        // Create some teachers
        Teacher mrLee = new Teacher("David", "Lee", "DL789");
        Teacher msTaylor = new Teacher("Sophia", "Taylor", "ST012");

        // Create some courses
        Course dataStructures = new Course("CS202", "Data Structures", mrLee);
        Course worldLiterature = new Course("LT305", "World Literature", msTaylor);

        // Add courses to departments
        computerScience.Courses = new List<Course> { dataStructures };
        literature.Courses = new List<Course> { worldLiterature };

        // Create some subjects and add them to courses
        Subject algorithms = new Subject { SubjectCode = "CS2021", SubjectName = "Algorithms", Description = "Introduction to algorithms and problem solving" };
        Subject databases = new Subject { SubjectCode = "CS2022", SubjectName = "Databases", Description = "Basics of database management systems" };
        dataStructures.Subjects.Add(algorithms);
        dataStructures.Subjects.Add(databases);

        Subject modernLiterature = new Subject { SubjectCode = "LT3051", SubjectName = "Modernism", Description = "Exploration of modern literature" };
        worldLiterature.Subjects.Add(modernLiterature);

        // Create some students
        Student studentJohn = new Student("Emily", "Davis", "E3003");
        Student studentJane = new Student("Michael", "Brown", "M4004");

        // Output information about departments, courses, and subjects
        PrintDepartmentCourses(computerScience);
        PrintDepartmentCourses(literature);

        // Output information about Students
        Console.WriteLine(studentJohn.ToString());
        Console.WriteLine(studentJane.ToString());

        // Output information about Teachers
        Console.WriteLine(mrLee.ToString());
        Console.WriteLine(msTaylor.ToString());

        Console.ReadKey();
    }

    static void PrintDepartmentCourses(Department department)
    {
        Console.WriteLine($"Department: {department.DepartmentName}");
        foreach (var course in department.Courses)
        {
            Console.WriteLine($" Course: {course.CourseName} ({course.CourseID})");
            Console.WriteLine($"  Instructor: {course.CourseInstructor.FirstName} {course.CourseInstructor.LastName}");
            foreach (var subject in course.Subjects)
            {
                Console.WriteLine($"   Subject: {subject.SubjectName} - {subject.Description}");
            }
        }
    }
}
