using System;

namespace CSVHelper_And_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read data from CSV & Write data in CSV");
            CSVHandler.ImplementCSVDataHandling();
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
        }
    }
}
