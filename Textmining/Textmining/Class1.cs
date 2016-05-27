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
        public string mykeys = "";
        
        public int SearchWord(string word)
        {
            
            
            int no = Regex.Matches(totaltext, word).Count;
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
            string keywordd = keyword;
            string key1 = keyword+"(\\w+)";
            string key2 = "(\\w+)"+keyword;
            string key3 = "(\\w+)" + keyword + "(\\w+)";
            string total = gettotaltext();
            string pre="", post="";
            string prepattren = "(\\w+\\s\\b"+keywordd+"\\s)";
            string postpattern = "(" + keywordd + "\\b\\s\\w+)";
            string prepattren1 = "(\\w+\\s\\b" + key1 + ")";
            string postpattern1 = "(" + key1 + "\\b\\s\\w+)";
            string prepattren2 = "(\\w+\\s\\b" + key2 + ")";
            string postpattern2 = "(" + key2 + "\\b\\s\\w+)";
            string prepattren3 = "(\\w+\\s\\b" + key3 + ")";
            string postpattern3 = "(" + key3 + "\\b\\s\\w+)";
            String[] pre1 = Regex.Matches(total, prepattren)
                        .Cast<Match>()
                        .Select(match => match.Groups[1].Value)
                        .ToArray();
             String[] post1 = Regex.Matches(total, postpattern)
                       .Cast<Match>()
                       .Select(match => match.Groups[1].Value)
                       .ToArray();
             String[] pre2 = Regex.Matches(total, prepattren1)
                         .Cast<Match>()
                         .Select(match => match.Groups[1].Value)
                         .ToArray();
             String[] post2 = Regex.Matches(total, postpattern1)
                       .Cast<Match>()
                       .Select(match => match.Groups[1].Value)
                       .ToArray();
             String[] pre3 = Regex.Matches(total, prepattren2)
                          .Cast<Match>()
                          .Select(match => match.Groups[1].Value)
                          .ToArray();
             String[] post3 = Regex.Matches(total, postpattern2)
                        .Cast<Match>()
                        .Select(match => match.Groups[1].Value)
                        .ToArray();
             String[] pre4 = Regex.Matches(total, prepattren3)
                          .Cast<Match>()
                          .Select(match => match.Groups[1].Value)
                          .ToArray();
             String[] post4 = Regex.Matches(total, postpattern3)
                        .Cast<Match>()
                        .Select(match => match.Groups[1].Value)
                        .ToArray();
             pre = ConvertStringArrayToString(pre1) + "\r\n" + ConvertStringArrayToString(pre2) + "\r\n" + ConvertStringArrayToString(pre3) + "\r\n" + ConvertStringArrayToString(pre4);
             post = ConvertStringArrayToString(post1) + "\r\n" + ConvertStringArrayToString(post2) + "\r\n" + ConvertStringArrayToString(post3) + ConvertStringArrayToString(post4);

             mykeys = keywordd + "\r\n" + key1 + "\r\n" + key2 + "\r\n" + key3;

            //for (int i = 0; i < number; i++)
            //    {
            //        try
            //        {
            //            int ind = Array.IndexOf(neww, keyword);
            //            string a = neww[ind - 1];
            //            string b = neww[ind + 1];
            //            pre += a + "\r\n";
            //            post += b + "\r\n";
            //            mergedd += mergedd + "\r\n" + pre + " " + keyword + " " + post;
            //            neww[ind] = "";
            //        }
            //        catch(Exception ex)
            //        {
            //            //System.Windows.Forms.MessageBox.Show(ex.Message);

            //        }

                
            //}
        
            prefix = pre;
            postfix = post;

        }
        static string ConvertStringArrayToString(string[] array)
        {
            //
            // Concatenate all the elements into a StringBuilder.
            //
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append("\r\n");
            }
            return builder.ToString();
        }

    }
}
