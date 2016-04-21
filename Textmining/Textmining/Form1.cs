using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            OpenFileDialog fd1 = new OpenFileDialog();
            fd1.Filter = "(*.docx) |*.docx";
            if(fd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.path.Text = fd1.FileName;

            }
            MessageBox.Show("Your file has been added.");
        }
    }
}
