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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*
             * 3 �̃J���`������x�ɕ\������
             * (���x���̈ʒu�𑵂��Ă��邱�Ƃɒ���)
             * 
             * */

            CultureInfo ci = null;

            // ���{��(���{)
            ci = new CultureInfo("ja-JP");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            this.label1.Text = Properties.Resource.Hello;
            this.label2.Text = Properties.Resource.ThankYou;

            // �p��(�A�����J���O��)
            ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            this.label3.Text = Properties.Resource.Hello;
            this.label4.Text = Properties.Resource.ThankYou;

            // �^�C
            ci = new CultureInfo("th");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            this.label5.Text = Properties.Resource.Hello;
            this.label6.Text = Properties.Resource.ThankYou;
        }
    }
}