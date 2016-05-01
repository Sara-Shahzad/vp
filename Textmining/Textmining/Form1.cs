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
using System.Text.RegularExpressions;


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
                file = this.path.Text;
                String outfile = "D:\\file.pdf";

                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                Document doc = null;
                doc = app.Documents.Open(file, Type.Missing, false);
                doc.ExportAsFixedFormat(outfile, WdExportFormat.wdExportFormatPDF);
                doc.Close(false, Type.Missing, Type.Missing);
                app.Quit(false, false, false);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                pdf.src = outfile;
                MessageBox.Show("Your file has been added.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = searchbox.Text;
            String paths = path.Text;
            Class1 c=new Class1();

            int num = c.SearchWord(a, paths);
            if(num>0)
            {
                string xyz = "Found...\n\n" + "number of times the KeyWord Appeared in the document is " + num+"...";
                Result.Text = xyz;
            }
            else
            {
                Result.Text = "Not Found.....\n";
            }
            
        }

        private void path_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
