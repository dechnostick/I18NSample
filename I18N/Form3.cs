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
             * 3 つのカルチャを一度に表示する
             * (ラベルの位置を揃えてあることに注意)
             * 
             * */

            CultureInfo ci = null;

            // 日本語(日本)
            ci = new CultureInfo("ja-JP");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            this.label1.Text = Properties.Resource.Hello;
            this.label2.Text = Properties.Resource.ThankYou;

            // 英語(アメリカ合衆国)
            ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            this.label3.Text = Properties.Resource.Hello;
            this.label4.Text = Properties.Resource.ThankYou;

            // タイ
            ci = new CultureInfo("th");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            this.label5.Text = Properties.Resource.Hello;
            this.label6.Text = Properties.Resource.ThankYou;
        }
    }
}