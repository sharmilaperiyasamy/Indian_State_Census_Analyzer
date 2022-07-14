Indian_Census_Analyzer.StateAnalyser model = new Indian_Census_Analyzer.StateAnalyser();
Console.WriteLine("0.Exit\n1.State Census Data\n2.State Code\nEnter your choice:");
int choice = Convert.ToInt32(Console.ReadLine());
while (choice != 0)
{
    switch (choice)
    {
        case 1:
            int count = model.DataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateCensusData.csv");
            Console.WriteLine("Number of Records in StateCensusData are : " + count);
            break;
        case 2:
            int numberofrecords = model.StateDataAnalyzer(@"C:\Users\Lenovo\source\repos\Bridgelabz\Indian_State_Census_Analyzer\StateCode.csv");
            Console.WriteLine("Number of Records in StateCodeData are : " + numberofrecords);
            break;
        default:
            Console.WriteLine("Enter valid choice");
            break;
    }
    Console.WriteLine("0.Exit\n1.State Census Data\n2.State Code\nEnter your choice:");
    choice = Convert.ToInt32(Console.ReadLine());
}