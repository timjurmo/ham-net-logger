﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetHAMContactInfo
{
    public partial class PageSource : Form
    {
        public PageSource(string source)
        {
            InitializeComponent();
            richTextBox1.Text = source;
        }
    }
}
