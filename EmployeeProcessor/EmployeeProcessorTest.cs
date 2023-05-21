using DryDemoLibrary;

namespace EmployeeProcessor
{
    public class EmployeeProcessorTest
    {
        [Theory]
        [InlineData("Sifiso", "Khoza", "SifiKhoz")]
        [InlineData("Sifiso", "", "Sifi")]

        public void GenerateEmployeeId_shouldCalculate(string firstName, string lastName, string expextedStart)
        {
            //Arrange 
            DryDemoLibrary.EmployeeProcessor processor = new DryDemoLibrary.EmployeeProcessor();


            //Act
            string Actual = processor.GenerateEmployeeId(firstName, lastName).Substring(0, expextedStart.Length); 
           // var Act2  = Actual[0..^3];
            //Assert
            Assert.True(Actual == expextedStart);
        }

    }
}
