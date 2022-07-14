Indian_Census_Analyzer.StateAnalyser model = new Indian_Census_Analyzer.StateAnalyser();
int count = model.DataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateCensusData.csv");
Console.WriteLine("Number of Records in StateCensusData are : " + count);
Console.WriteLine("------------------------------------------------------------------------------------------------");
int numberofrecords = model.StateDataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateCode.csv");
Console.WriteLine("Number of Records in StateCodeData are : " + numberofrecords);