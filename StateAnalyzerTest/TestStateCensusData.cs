namespace StateAnalyzerTest
{
    public class Tests
    {
        [Test]
        public void Census_Analyzer()
        {
            int expected = 29;
            Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
            int output = state.DataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateCensusData.csv");
            Assert.AreEqual(expected, output);
        }
    }
}