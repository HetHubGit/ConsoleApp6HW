using ConsoleApp6HW;

public class Employee
{
    private List<float> grades = new List<float>();
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string login { get; private set; }
    public int age { get; private set; }

    public string password { get; private set; }
    public Employee(string login, string name, string surname, int age, string password)
    {
        this.login = login;
        this.Name = name;
        this.Surname = surname;
        this.age = age;
        this.password = password;
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
            statistics.Max = Math.Max(statistics.Max, grade); //cyt:"To jest taki myk, który czésto sié wykorzystuje" :)
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
        var employee = new Employee("jackski", "Jacek", "Hetman", 64, "pS464");
        var employee2 = new Employee("mayusheck", "Maya", "Hetmanska", 5, "pS464");
        employee.AddGrade(7);
        employee.AddGrade(4);
        employee.AddGrade(5);
        employee.AddGrade(3);
        employee.AddGrade(6);
        employee.AddGrade(8);
        employee.AddGrade(3);
        employee.AddGrade(9);
        var statistics = employee.GetStatistics();
        Console.WriteLine($"Pracownik:\t {employee.Name} {employee.Surname}");
        Console.WriteLine($"Grades Average:\t {statistics.Average:N2}");  // tutaj $(dolar) oznacza interpolacje czyli wrzutké
        Console.WriteLine($"Lowest grade:\t {statistics.Min:N2}");       // N2 oznacza 2 miejsca po przecinku
        Console.WriteLine($"Highest grade:\t {statistics.Max:N2}");
        void SetSth(ref Statistics statistics)
        {
            statistics = new Statistics();
        }
    }
}