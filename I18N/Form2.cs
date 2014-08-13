using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace I18N
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = Properties.Resource.Hello;
            this.label2.Text = Properties.Resource.ThankYou;
            this.label3.Text += Thread.CurrentThread.CurrentUICulture.DisplayName;
        }
    }
}