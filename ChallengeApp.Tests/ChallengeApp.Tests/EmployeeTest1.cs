using ChallengeApp;

public class Tests
{
    [Test]
    public void WhenEmployeeGetScores()
    {
        //arrange
        var employee = new Employee("Katarzyna", "Sowa", 34);
       
        employee.AddScore(4);
        employee.AddScore(8);
        employee.AddScore(6);
        employee.AddScore(3);
        employee.AddScore(1);

        // act
        var result = employee.Result;
        // Assert
        Assert.AreEqual(22, result);
    }

    [Test]
    public void WhenEmployeeGetMinusAndPlusScores()
    {
        //arrange
        var employee = new Employee("Marcin", "Chy³ek", 54);
        employee.AddScore(2);
        employee.AddScore(4);
        employee.AddScore(6);
        employee.AddScore(7);
        employee.AddScore(-9);

        // act
        var result = employee.Result;
        // Assert
        Assert.AreEqual(10, result);

    }

    [Test]
    public void WhenEmployeeGetMinusAndPlusAndRewardScores()
    {
        //arrange
        var employee = new Employee("Zofia", "Kowalska", 85);
        employee.AddScore(2);
        employee.AddScore(4);
        employee.AddScore(40);
        employee.AddScore(7);
        employee.AddScore(-9);
        // act
        var result = employee.Result;
        // Assert
        Assert.AreEqual(44, result);
    }
    
       

}