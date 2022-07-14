namespace StateAnalyzerTest
{
    public class Tests
    {
        [Test]
        //uc1 testcase1.1
        public void Census_Analyzer()
        {
            int expected = 29;
            Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
            int output = state.DataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateCensusData.csv");
            Assert.AreEqual(expected, output);
        }
        //uc1 testcase1.2
        public void Census_AnalyzerException()
        {
            try
            {
                int expected = 29;
                Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
                int output = state.DataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateData.csv");
                Assert.AreEqual(expected, output);
            }
                 catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
    }
}