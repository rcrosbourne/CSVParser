using ComLib.CsvParse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSVParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvString = "a,b,c,\"d,c,e\",f";
            Console.Write(csvString);
            CsvDoc csvDoc = Csv.LoadText(csvString, false);

            List<string> records = new List<string>();
            for (int i = 0; i < csvDoc.Columns.Count; i++)
            {
                records.Add(csvDoc.Data[0][i] as string) ;
            }
            Console.ReadKey();

        }
    }
}
