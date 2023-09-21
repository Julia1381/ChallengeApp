using ChallengeApp;

Employee employee1 = new Employee ("Katarzyna", "Sowa", 34);
Employee employee2 = new Employee ("Marcin", "Chyłek", 54);
Employee employee3 = new Employee ("Zofia", "Kowalska", 85);

employee1.AddScore(4);
employee1.AddScore(8);
employee1.AddScore(6);
employee1.AddScore(3);
employee1.AddScore(1);

employee2.AddScore(2);
employee2.AddScore(4);
employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(9);

employee3.AddScore(9);
employee3.AddScore(1);
employee3.AddScore(4);
employee3.AddScore(7);
employee3.AddScore(1);

Console.WriteLine(employee1.Name + " " + employee1.Surname + " " + employee1.Age + " " + employee1.Result);
Console.WriteLine(employee2.Name + " " + employee2.Surname + " " + employee2.Age + " " + employee2.Result);
Console.WriteLine(employee3.Name + " " + employee3.Surname + " " + employee3.Age + " " + employee3.Result);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

 int BestResult = -1;
Employee? BestResultEmployee = null;


foreach (Employee employee in employees)
{
    if(employee.Result > BestResult)
    {
        BestResult = employee.Result;
        BestResultEmployee = employee;

    }
}

Console.WriteLine("Najlepszy wynik ma :" + BestResultEmployee?.Name + " " + BestResultEmployee?.Surname + " " + BestResultEmployee?.Age);

Console.ReadLine();

