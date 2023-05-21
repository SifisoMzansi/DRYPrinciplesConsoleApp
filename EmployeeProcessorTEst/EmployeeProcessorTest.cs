namespace EmployeeProcessorTEst
{
    public class EmployeeProcessorTest
    {
        [Theory]
        [InlineData("Sifiso", "Khoza", "SifiKhoz")]
        public void GenerateEmployeeId_shouldCalculate(string firstName, string lastName, string expextedStart)
        {
            //Arrange 
            EmployeeProcessor processor = new EmployeeProcessor();


            //Act
            string Actual = processor.GenerateEmployeeId(firstName, lastName)[0..^4];
            //Assert
            Assert.True(Actual == expextedStart);
        }

    }
}