﻿using System;
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
    public partial class Form2 : Form
    {
        string prefix, postfix, keyword,mykeys;
        
        
        public Form2()
        {
            InitializeComponent();
            
        }
        public Form2(string pre,string post,string key,string keys)
        {
            InitializeComponent();
            prefix = pre;
            postfix = post;
            keyword = key;
            mykeys = keys;
            //mergee = merge;
        }
      
 

        private void button1_Click(object sender, EventArgs e)
        {
            pre.Text = prefix;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            key.Text = keyword;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            post.Text = postfix;
            
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    mergebox.Text = mergee;

        //}
    }
}
