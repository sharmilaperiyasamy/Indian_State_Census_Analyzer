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
        [Test]
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
        [Test]
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
        [Test]
        //uc1testcase1.4 invalid Delimiter
        public void CensusInvalidDelimiter()
        {
            try
            {
                int expected = 29;
                Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
                int output = state.DataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\InvalidDelimiterStateCensusData.csv");
                Assert.AreEqual(expected, output);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }
        [Test]
        //uc1testcase1.5 incorrect header
        public void Census_AnalyzerIncorrectHeader()
        {
            try
            {
                int expected = 29;
                Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
                int output = state.DataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\IncorrectHeaderStateCensusData.csv");
                Assert.AreEqual(expected, output);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }

        [Test]
        //uc2 testcase2.1 ensures state count
        public void State_Analyzer()
        {
            int expected = 37;
            Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
            int output = state.StateDataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateCode.csv");
            Assert.AreEqual(expected, output);
        }
        [Test]
        //uc2 testcase2.2 invalid file
        public void StateCode_Analyzer()
        {
            try
            {
                int expected = 37;
                Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
                int output = state.StateDataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateCodedata.csv");
                Assert.AreEqual(expected, output);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
        [Test]
        //uc2testcase2.3 invalid file type
        public void State_AnalyzerFileTypeException()
        {
            try
            {
                int expected = 37;
                Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
                int output = state.StateDataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateCode.cs");
                Assert.AreEqual(expected, output);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File Type", ex.Message);
            }
        }
        [Test]
        //uc2 testcase2.4 invalid Delimiter
        public void State_AnalyzerInvalidDelimiter()
        {
            try
            {
                int expected = 37;
                Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
                int output = state.StateDataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\DelimiterStateCode.csv");
                Assert.AreEqual(expected, output);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }
        [Test]
        //uc2testcase1.5 incorrect header
        public void State_AnalyzerIncorrectHeader()
        {
            try
            {
                int expected = 37;
                Indian_Census_Analyzer.StateAnalyser state = new Indian_Census_Analyzer.StateAnalyser();
                int output = state.StateDataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\IncorrectHeaderStateCode.csv");
                Assert.AreEqual(expected, output);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
    }
}