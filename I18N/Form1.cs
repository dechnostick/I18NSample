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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 
             * 動作確認のため、カルチャの変更を行う
             * 
             * 通常はプログラムでカルチャを変更せず、
             * OS で設定されたカルチャをそのまま使う。
             * */

            if (this.radioButton1.Checked)
            {
                // 規定のカルチャ
                new Form2().Show();
                return;
            }

            CultureInfo ci = null;
            if (this.radioButton2.Checked)
            {
                // 日本-日本語(地域 - 言語)
                ci = new CultureInfo("ja-JP");
            }

            if (this.radioButton3.Checked)
            {
                // 米国-英語
                ci = new CultureInfo("en-US");
            }
            if (this.radioButton4.Checked)
            {
                // タイ-タイ語
                ci = new CultureInfo("th");
            }
            new Form2(ci).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}