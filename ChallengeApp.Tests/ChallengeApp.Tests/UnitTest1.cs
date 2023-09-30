namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            int age = 4;
            int age1 = 5;
            int result = age + age1;
            Assert.AreEqual(9, result);
        }

    }
}