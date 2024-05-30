using ConsoleApp6HW;

public class Employee
{
    private List<float> grades = new List<float>();
    public string Name { get; private set; }
    public string Surname { get; private set; }
    /* public int age { get; private set; }
    public string login { get; private set; }
    public string password { get; private set; } */
    public Employee(string name, string surname)
    {
       // this.login = login;
        this.Name = name;
        this.Surname = surname;
       // this.age = age;
       // this.password = password;
    }
    public float Result
    {
        get
        {
            return this.grades.Sum();
        }
    }
    public void AddGrade(float grade)
    {
        this.grades.Add(grade);
    }
    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade); //cyt:"To jest taki myk, który czésto sié wykorzystuje"
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }
        statistics.Average /= this.grades.Count;
        return statistics;
    }

    public static void Main(string[] args)
    {
        int maxValue = -1;
        Employee maxValueEmployee = null;
        var employee = new Employee("Jacek", "Hetman");
        employee.AddGrade(2);
        employee.AddGrade(2);
        employee.AddGrade(6);
        employee.AddGrade(1);
        employee.AddGrade(2);
        employee.AddGrade(5);
        employee.AddGrade(6);
        employee.AddGrade(7);
        employee.AddGrade(1);
        employee.AddGrade(7);
        employee.AddGrade(7);
        employee.AddGrade(4);
        employee.AddGrade(5);
        employee.AddGrade(3);
        employee.AddGrade(6);
        employee.AddGrade(8);
        employee.AddGrade(3);
        employee.AddGrade(9);
        var statistics = employee.GetStatistics();
        Console.WriteLine($"Average: {statistics.Average:N2}  "); // tutaj $(dolar) oznacza interpolacje czyli wrzutké  - N2 oznacza 2 miejsca po przecinku
        Console.WriteLine($"Min: {statistics.Min}  ");
        Console.WriteLine($"Max: {statistics.Max}  ");
        
        /*
        List<Employee> listofEmployees = new List<Employee>()
    {
    employee
    };

        foreach (var employee in listofEmployees)
        {
            if (employee.Result > maxValue)
            {
                maxValue = employee.Result;
                maxValueEmployee = employee;
            }
        }
        Console.WriteLine("Najlepszy pracownik");
        Console.WriteLine("Imie: " + maxValueEmployee.name);
        Console.WriteLine("Nazwisko: " + maxValueEmployee.surname);*/
    }
}