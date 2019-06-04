using System.Collections.Generic;
using System.Linq;

namespace FileParserNetStandard {
    public class DataParser {
        

        /// <summary>
        /// Strips any whitespace before and after a data value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripWhiteSpace(List<List<string>> data) {
            List<List<string>> list = new List<List<string>>();
            foreach (List<string> items in data)
            {
                List<string> line = new List<string>();
                for (int o = 0; o < items.Count; o++)
                {
                    string item = items[o];
                    item = item.Trim();
                    line.Add(item);
                }
                list.Add(line);
            }
            return list;
        }

        /// <summary>
        /// Strips quotes from beginning and end of each data value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripQuotes(List<List<string>> data) {
            List<List<string>> list = new List<List<string>>();
            foreach (List<string> items in data)
            {
                List<string> line = new List<string>();
                for (int o = 0; o < items.Count; o++)
                {
                    string item = items[o];
                    item = item.Trim('"');
                    line.Add(item);
                }
                list.Add(line);
            }
            return list;
            
        }

    }
}