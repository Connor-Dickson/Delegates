using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using FileParserNetStandard;

public delegate List<List<string>> Parser(List<List<string>> data);

namespace Delegate_Exercise {
 
    
    internal class Delegate_Exercise {

        public static List<List<string>> StripHash(List<List<string>> data)
        {
            List<List<string>> list = new List<List<string>>();
            //foreach (List<string> items in data)
            for (int i = 0; i < data.Count; i++)
            {
                List<string> line = new List<string>();
                for(int o = 0; o < i; o++)
                {
                    string text = line[o];
                    text = text.Trim('#');
                    line.Add(text);
                }
                list.Add(line);
            }
            return list;
        }
        public static void Main(string[] args)
        {
            DataParser data = new DataParser();
            CsvHandler test = new CsvHandler();
            Func<List<List<string>>, List<List<string>>> whiteTrimmer = new Func<List<List<string>>, List<List<string>>>(data.StripWhiteSpace);
            whiteTrimmer += data.StripQuotes;
            test.ProcessCsv(@"C:\Users\102051563\source\repos\Dip-Seminar-Delegates-Lambda-Linq_Exercises\Files\data.csv",
                @"C:\Users\102051563\source\repos\Dip-Seminar-Delegates-Lambda-Linq_Exercises\Files\processed_data.csv", whiteTrimmer);
            
        }

        
        
    }
}