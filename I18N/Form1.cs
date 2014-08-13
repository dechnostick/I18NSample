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
             * ����m�F�̂��߁A�J���`���̕ύX���s��
             * 
             * �ʏ�̓v���O�����ŃJ���`����ύX�����A
             * OS �Őݒ肳�ꂽ�J���`�������̂܂܎g���B
             * */

            if (this.radioButton1.Checked)
            {
                // �K��̃J���`��
                new Form2().Show();
                return;
            }

            CultureInfo ci = null;
            if (this.radioButton2.Checked)
            {
                // ���{-���{��(�n�� - ����)
                ci = new CultureInfo("ja-JP");
            }

            if (this.radioButton3.Checked)
            {
                // �č�-�p��
                ci = new CultureInfo("en-US");
            }
            if (this.radioButton4.Checked)
            {
                // �^�C-�^�C��
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