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
       public string postfix="";
       public string prefix= "";
        public string totaltext;
        public string keyword = "";
        public int num;
        
        public int SearchWord(string word)
        {
            
            
            int no = Regex.Matches(totaltext, word,RegexOptions.IgnoreCase).Count;
            num = no;
            keyword = word;
            return no;
            
            
            
        }
      
        public string gettotaltext()
        {
            return totaltext;
        }
        public void mydoc(string path)
        {
            Microsoft.Office.Interop.Word.Application words = new Microsoft.Office.Interop.Word.Application();
            object miss = System.Reflection.Missing.Value;
            object readOnly = true;
            Microsoft.Office.Interop.Word.Document docs = words.Documents.Open(path);
            string totaltextt = "";
            for (int i = 0; i < docs.Paragraphs.Count; i++)
            {
                totaltextt += " \r\n " + docs.Paragraphs[i + 1].Range.Text.ToString();
            }
            docs.Close();
            words.Quit();
            totaltext = totaltextt;
        }
        public void getsemantics()
        {
            string total = gettotaltext();
            int number = num;
            string pre="", post="";
            string[] neww = total.Split(' ', '.', ',');
            for (int i = 0; i < number; i++)
            {
                int ind=Array.IndexOf(neww,keyword);
                pre += neww[ind - 1]+"\r\n";
                post += neww[ind + 1] + "\n\r";
                neww[ind] = "";

            }
            prefix = pre;
            postfix = post;

        }

    }
}
