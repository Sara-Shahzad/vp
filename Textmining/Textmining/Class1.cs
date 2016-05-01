using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;

namespace Textmining
{
    class Class1
    {
        public int SearchWord(string word, string path)
        {
            Microsoft.Office.Interop.Word.Application words = new Microsoft.Office.Interop.Word.Application();
            object miss = System.Reflection.Missing.Value;
            object readOnly = true;
            Microsoft.Office.Interop.Word.Document docs = words.Documents.Open(path);
            string totaltext = "";
            for (int i = 0; i < docs.Paragraphs.Count; i++)
            {
                totaltext += " \r\n " + docs.Paragraphs[i + 1].Range.Text.ToString();
            }
            Console.WriteLine(totaltext);
            docs.Close();
            words.Quit();
            int no = Regex.Matches(totaltext, word).Count;
            return no;
            
        }

    }
}
