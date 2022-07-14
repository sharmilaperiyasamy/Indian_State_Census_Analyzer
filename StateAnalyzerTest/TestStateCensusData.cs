namespace StateAnalyzerTest
{
    public class Tests
    {
        [Test]
        //uc1 testcase1.1 ensures state count
        public void Census_Analyzer()
        {
            int expected = 29;
            Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
            int output = state.DataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateCensusData.csv");
            Assert.AreEqual(expected, output);
        }
        //uc1 testcase1.2 invalid file
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
        //uc1testcase1.3 invalid file type
        public void Census_AnalyzerFileTypeException()
        {
            try
            {
                int expected = 29;
                Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
                int output = state.DataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateData.cs");
                Assert.AreEqual(expected, output);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File Type", ex.Message);
            }
        }
        //uc1testcase1.4 invalid Delimiter
        public void Census_AnalyzerInvalidDelimiter()
        {
            try
            {
                int expected = 29;
                Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
                int output = state.DataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\InvalidDelimiterStateData.csv");
                Assert.AreEqual(expected, output);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Delimiter", ex.Message);
            }
        }
        
        //uc1testcase1.5 incorrect header
        public void Census_AnalyzerIncorrectHeader()
        {
            try
            {
                int expected = 29;
                Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
                int output = state.DataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\IncorrectHeaderStateCensus.csv");
                Assert.AreEqual(expected, output);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
    }
}