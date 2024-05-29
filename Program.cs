public class Employee
{
    private List<int> score = new List<int>();
    public string name { get; private set; }
    public string surname { get; private set; }
    public int age { get; private set; }
    public string login { get; private set; }
    public string password { get; private set; }
    public Employee(string login, string name, string surname, int age, string password)
    {
        this.login = login;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.password = password;
    }
    public int Result
    {
        get
        {
            return score.Sum();
        }
    }
    public void AddScore(int number)
    {
        score.Add(number);
    }

    public static void Main(string[] args)
    {
        int maxValue = -1;
        Employee maxValueEmployee = null;
        Employee employee1 = new Employee("kottek", "kot", "Pies", 5, "");
        Employee employee2 = new Employee("jackski", "Jacek", "human", 46, "pS232");
        Employee employee3 = new Employee("Vexatio", "Olga", "Human", 47, "");
        List<Employee> listofEmployees = new List<Employee>()
    {
    employee1, employee2, employee3
    };
        employee1.AddScore(1);
        employee1.AddScore(2);
        employee1.AddScore(5);
        employee1.AddScore(6);
        employee1.AddScore(7);
        employee3.AddScore(1);
        employee3.AddScore(7);
        employee3.AddScore(7);
        employee3.AddScore(4);
        employee3.AddScore(5);
        employee2.AddScore(3);
        employee2.AddScore(6);
        employee2.AddScore(8);
        employee2.AddScore(3);
        employee2.AddScore(9);
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
        Console.WriteLine("Nazwisko: " + maxValueEmployee.surname);
        Console.WriteLine("Age: " + maxValueEmployee.age);
        Console.WriteLine("Login: " + maxValueEmployee.login);
        Console.WriteLine("Points: " + maxValueEmployee.Result);
    }
}