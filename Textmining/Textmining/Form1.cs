using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;


namespace Textmining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String file="";
            OpenFileDialog fd1 = new OpenFileDialog();
            fd1.Filter = "(*.docx) |*.docx";
            if (fd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.path.Text = fd1.FileName;
                file=this.path.Text;
                

            }
            String outfile = "D:\\file.pdf";
            MessageBox.Show("Your file has been added.");
            //Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            //Document doc = null;
            //doc = app.Documents.Open(file , Type.Missing ,false);
            //doc.ExportAsFixedFormat(outfile, WdExportFormat.wdExportFormatPDF);
            //doc.Close(false, Type.Missing, Type.Missing);
            //app.Quit(false, false, false);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            //pdf.src = outfile;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = searchbox.Text;
            int b = 0;
            
            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
            Document document = application.Documents.Open(path.Text);
            int count = document.Words.Count;
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(count);

               
                string text = document.Words[i].Text;
                Console.WriteLine(text);
                if (text == a)
                {
                    b++;

                }
            }
            string xyz = "number of words found = " + b;
            MessageBox.Show(xyz);
        }
    }
}
