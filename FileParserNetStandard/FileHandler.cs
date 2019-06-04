﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FileParserNetStandard {
    public class FileHandler {
       
        public FileHandler() { }

        /// <summary>
        /// Reads a file returning each line in a list.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<string> ReadFile(string filePath) {
            //List<string> lines = new List<string>();
            string[] liness = File.ReadAllLines(filePath);
            return liness.ToList();
        }

        
        /// <summary>
        /// Takes a list of a list of data.  Writes to file, using delimeter to seperate data.  Always overwrites.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="delimeter"></param>
        /// <param name="rows"></param>
        public void WriteFile(string filePath, char delimeter, List<List<string>> rows) {
            string[] lines = new string[rows.Count];
            int i = 0;
            foreach(List<string> row in rows)
            { 

                for(int o = 0; o < row.Count - 1; o++)
                {
                    string item = row[o] + delimeter;
                    lines[i] += item;
                }
                lines[i] += row.Last();
                i++;
            }
            File.WriteAllLines(filePath, lines);


        }
        
        /// <summary>
        /// Takes a list of strings and seperates based on delimeter.  Returns list of list of strings seperated by delimeter.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="delimeter"></param>
        /// <returns></returns>
        public List<List<string>> ParseData(List<string> data, char delimeter) {
            List<List<string>> list = new List<List<string>>();
            foreach(string item in data)
            {
                string[] items = item.Split(delimeter);
                list.Add(items.ToList());
            }
            return new List<List<string>>(list);  //-- return result here
        }
        
        /// <summary>
        /// Takes a list of strings and seperates on comma.  Returns list of list of strings seperated by comma.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> ParseCsv(List<string> data) {
            List<List<string>> list = new List<List<string>>();
            foreach (string item in data)
            {
                string[] items = item.Split(',');
                list.Add(items.ToList());
            }
            
            return new List<List<string>>(list);  //-- return result here
        }
    }
}