using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DES_12307130088
{
    public partial class Form1 : Form
    {
        public static RSA new_rsa = new RSA();
        bool RSA_Confirm;

        public Form1()
        {
            InitializeComponent();
            RSA_Confirm = false;    //RSA确认标志
        }

        //BigintToBinstr函数功能： 将BigInteger类型数x转成长度为len的二进制字符串
        string BigintToBinstr(BigInteger x, byte len)
        {
            char[] s = new char[len];
            for (int i = len - 1; i >= 0; i--)
            {
                s[i] = (x & 1) == 1 ? '1' : '0';
                x >>= 1;
            }
            return new string(s);
        }

        //BinstrToBigint函数功能： 将二进制字符串s转成BigInteger类型数
        BigInteger BinstrToBigint(string s)
        {
            BigInteger x = 0;
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                x = x << 1 + (s[i] - '0');
            }
            return x;
        }

        //button_RSA_Click：生成RSA公钥、私钥
        private void button_RSA_Click(object sender, EventArgs e)
        {
            new_rsa.GenerateKey();  //生成
            textBox_d.Text = BigintToBinstr(new_rsa.d, 128);
            textBox_e.Text = BigintToBinstr(new_rsa.e, 64);
            textBox_n.Text = BigintToBinstr(new_rsa.n, 128);
            RSA_Confirm = true;
            label_RSA.ForeColor = Color.Blue;
            label_RSA.Text = "RSA公钥、私钥生成成功";
        }

        // button_sender_Click：发送者
        private void button_sender_Click(object sender, EventArgs e)
        {
            Form fm = Application.OpenForms["Form2"];  //查找是否打开过Form2窗体
            if (fm == null)  //没打开过
            {
                Form2 fm2 = new Form2();
                fm2.Show();   //重新new一个Show出来
            }
            else
            {
                fm.Focus();   //打开过就让其获得焦点
            }
        }

        //button_receiver_Click：接收者
        private void button_receiver_Click(object sender, EventArgs e)
        {
            if (!RSA_Confirm)   //接受者需要有本地的RSA公钥、私钥
            {
                MessageBox.Show("RSA公钥、私钥未生成");
                return;
            }
            Form fm = Application.OpenForms["Form3"];  //查找是否打开过Form1窗体
            if (fm == null)  //没打开过
            {
                Form3 fm3 = new Form3();
                fm3.Show();   //重新new一个Show出来
            }
            else
            {
                fm.Focus();   //打开过就让其获得焦点
            }
        }

        private void button_copy_e_Click(object sender, EventArgs e)
        {
            if (textBox_e.Text == "")
            {
                MessageBox.Show("请首先生成本地的RSA公钥、私钥");
                return;
            }
            Clipboard.SetDataObject(textBox_e.Text);    //将e复制到剪贴板
        }

        private void button_copy_n_Click(object sender, EventArgs e)
        {
            if (textBox_n.Text == "")
            {
                MessageBox.Show("请首先生成本地的RSA公钥、私钥");
                return;
            }
            Clipboard.SetDataObject(textBox_n.Text);    //将n复制到剪贴板
        }
    }
}    