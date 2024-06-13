namespace TestUN6;

public class Tests
{
    [Test]
    public void CheckUserLogin()
    {
        // arrange
        Employee employee = new Employee("kottek", "kot", "Pies", 5, "");

        // act
        var result = employee.login;

        // assert
        Assert.That("kottek", Is.EqualTo(result));
    }

    [Test]
    public void CheckUserPassword()
    {
        // arrange
        Employee employee2 = new Employee("jackski", "Jacek", "human", 46, "pS232");

        // act
        var result = employee2.password;

        // assert
        Assert.That("pS232", Is.EqualTo(result));
    }
    [Test]
    public void TwoStringsShouldBeEqual()
    {
        // arrange
        string a = "I see";
        string b = "I see";

        //act

        //assert
        Assert.AreEqual(a, b);
    }


    private Employee GetEmployee(string login, string name, string surname, int age, string password)
    {
        return new Employee(login, name, surname, age, password);
    }
    [Test]
    public void ObjectTest()
    {
        //arrange
        var employee1 = GetEmployee("LoginTest", "Maya", "Hetmanska", 5, "pS464");
        var employee2 = GetEmployee("LoginTest", "Maya", "Hetmanska", 5, "pS464");
        //act
        //assert
        Assert.AreNotEqual(employee1, employee2);
    }
}