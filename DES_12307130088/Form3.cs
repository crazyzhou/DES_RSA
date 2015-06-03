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
    public partial class Form3 : Form
    {
        string content;
        string result;
        string dir;
        byte[] KEY = new byte[64];
        byte[] IV = new byte[64];
        bool File_Confirm, IV_Confirm, KEY_Confirm, RSA_Confirm, transKEY_Confirm;
        DES new_des = new DES();

        public Form3()
        {
            InitializeComponent();
            File_Confirm = IV_Confirm = KEY_Confirm = RSA_Confirm = transKEY_Confirm= false;
            //文件、RSA秘钥、IV、KEY、transKEY已加载5个标志初始化为false
        }

        //binCheck函数功能：检验64位字符串是否为二进制字符串，是则返回true，否则返回false
        bool binCheck(string s)
        {
            int i;
            int len = s.Length;
            for (i = 0; i < len; i++)
            {
                if (s[i] != '0' && s[i] != '1')
                    return false;
            }
            return true;
        }

        //BigintToBinstr函数功能： 将BigInteger类型数x转成长度为len的二进制字符串
        string BigintToBinstr(BigInteger x, byte len)
        {
            char[] s = new char[len];
            for (int i = len - 1; i >= 0; i--)
            {
                s[i] = (x & 1) == 1 ? '1' : '0';
                x /= 2;
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
                x = x * 2 + (s[i] - '0');
            }
            return x;
        }

        //Depadding_PKCS5函数功能：按照PKCS#5标准方法将已解密串进行去填充化。
        string Depadding_PKCS5(string s)
        {
            int i, pd = 0;
            string str = s.Substring(s.Length - 8);
            for (i = 0; i < 8; i++)
            {
                pd = (pd << 1) + ((str[i] - '0') & 1);
            }
            if (pd > 8)
            {
                MessageBox.Show("待解密文件、主密钥或初始向量有误，无法进行正确解密，请检查后重新加载!");
                content = "";
                File_Confirm = IV_Confirm = KEY_Confirm = RSA_Confirm = transKEY_Confirm = false;
                label_filename.ForeColor = Color.Red;
                label_filename.Text = "文件未读取";
                label_RSA.ForeColor = Color.Red;
                label_RSA.Text="RSA公钥私钥未获取";
                label_KEY.ForeColor = Color.Red;
                label_KEY.Text = "主密钥未生成";
                textBox_KEY.Text = textBox_d.Text = textBox_e.Text = textBox_n.Text = "";
                return "";
            }
            return s.Substring(0, s.Length - pd * 8);
        }

        //button_file_Click：加载文件按钮
        private void button_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            file.InitialDirectory = Application.StartupPath;
            file.ShowReadOnly = true;
            DialogResult r = file.ShowDialog();
            if (r == DialogResult.OK)
            {
                string filename = file.FileName;
                dir = System.IO.Path.GetDirectoryName(filename);
                FileStream aFile = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(aFile);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                content = sr.ReadToEnd();
                sr.Close();
                aFile.Close();
                if (content.Length % 64 != 0)
                {
                    MessageBox.Show("待解密文件长度有误，应为64bit的倍数，请检查后重新加载!");
                    content = "";
                    return;
                }
                if (!binCheck(content))
                {
                    MessageBox.Show("文件不符合二进制要求，请进行修改并重新选择文件");
                    content = "";
                    return;
                }
                File_Confirm = true;
                label_filename.ForeColor = Color.Blue;
                label_filename.Text = "文件" + filename + "读取成功";
            }
        }

        //加载本地RSA公钥、私钥
        private void button_RSA_Click(object sender, EventArgs e)
        {
            textBox_d.Text = BigintToBinstr(Form1.new_rsa.d, 128);
            textBox_e.Text = BigintToBinstr(Form1.new_rsa.e, 64);
            textBox_n.Text = BigintToBinstr(Form1.new_rsa.n, 128);
            RSA_Confirm = true;
            label_RSA.ForeColor = Color.Blue;
            label_RSA.Text = "RSA公钥、私钥已获取";
            KEY_Confirm = transKEY_Confirm = false;
            label_KEY.ForeColor = Color.Red;
            label_KEY.Text = "主密钥未生成";
            textBox_KEY.Text = "";
        }

        //传送主密钥确认并进行RSA解密
        private void button_transKEY_Click(object sender, EventArgs e)
        {
            string tk = textBox_transKEY.Text;
            KEY_Confirm = false;
            if (tk.Length != 128 || !binCheck(tk))
            {
                label_KEY.ForeColor = Color.Red;
                label_KEY.Text = "主密钥未生成";
                textBox_KEY.Text = "";
                MessageBox.Show("传送主秘钥不符合规范，应为128位二进制串");
                return;
            }
            if (!RSA_Confirm)
            {
                MessageBox.Show("请先获取本地用户的RSA公钥、私钥");
                return;
            }
            textBox_KEY.Text = Form1.new_rsa.RSA_Decrypt(tk, 64);   //利用本地公钥、私钥将传送主密钥解密为64位的主密钥
            transKEY_Confirm = true;
            label_transKEY.ForeColor = Color.Blue;
            label_transKEY.Text = "传送主秘钥已确认并解密";
            label_KEY.ForeColor = Color.Green;
            label_KEY.Text = "主密钥已生成";
        }

        //主密钥确认按钮
        private void button_KEY_Click(object sender, EventArgs e)
        {
            string k = textBox_KEY.Text;
            for (int i = 0; i < 64; i++)
            {
                KEY[i] = (byte)(k[i] - '0');    //转换成二进制数组KEY
            }
            KEY_Confirm = true;
            label_KEY.ForeColor = Color.Blue;
            label_KEY.Text = "主密钥已确认";
        }

        //初始向量确认按钮
        private void button_IV_Click(object sender, EventArgs e)
        {
            string ivs = textBox_IV.Text;
            if (ivs.Length != 64 || !binCheck(ivs))
            {
                MessageBox.Show("初始向量不符合规范，应为64位二进制串");
                return;
            }
            for (int i = 0; i < 64; i++)
            {
                IV[i] = (byte)(ivs[i] - '0');   //转换成二进制数组IV
            }
            IV_Confirm = true;
            label_IV.ForeColor = Color.Blue;
            label_IV.Text = "初始向量已确认";
        }

        //button_DES_Click：逐64bit进行CBC密码分组模式的DES解密，并写入同一目录的文件SOURCE.txt
        private void button_DES_Click(object sender, EventArgs e)
        {
            if (!File_Confirm)
            {
                MessageBox.Show("文件未读取!");
                return;
            }
            if (!RSA_Confirm)
            {
                MessageBox.Show("RSA公钥私钥未获取!");
                return;
            }
            if (!transKEY_Confirm)
            {
                MessageBox.Show("传送主密钥未确认并解密!");
                return;
            }
            if (!KEY_Confirm)
            {
                MessageBox.Show("主密钥未确认!");
                return;
            }
            if (!IV_Confirm)
            {
                MessageBox.Show("初始向量未确认!");
                return;
            }
            result = new_des.DES_Decrypt(KEY, IV, content);
            result = Depadding_PKCS5(result);
            if (result != "")
            {
                if (File.Exists(dir + @"\SOURCE.txt"))
                {
                    File.Delete(dir + @"\SOURCE.txt");
                }
                FileStream bFile = new FileStream(dir + @"\SOURCE.txt", FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(bFile);
                sw.Write(result);
                sw.Close();
                bFile.Close();
                DialogResult dr;
                dr = MessageBox.Show("解密完成！！", "传送DES算法");
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    File_Confirm = IV_Confirm = KEY_Confirm = RSA_Confirm = transKEY_Confirm = false;
                    content = "";
                    label_filename.ForeColor = Color.Red;
                    label_filename.Text = "文件未读取";
                    label_RSA.ForeColor = Color.Red;
                    label_RSA.Text = "RSA公钥私钥未获取";
                    label_KEY.ForeColor = Color.Red;
                    label_KEY.Text = "主密钥未生成";
                    textBox_KEY.Text = textBox_d.Text = textBox_e.Text = textBox_n.Text = "";
                    System.Diagnostics.Process.Start("notepad.exe", dir + @"\SOURCE.txt");
                }
            }
        }

        //timer1：时钟，时刻保持label_transKEY，label_IV内容（输入的传送主密钥长度、初始向量长度）
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!transKEY_Confirm)
            {
                if (textBox_transKEY.TextLength != 128)
                    label_transKEY.ForeColor = Color.Red;
                else
                    label_transKEY.ForeColor = Color.Green;
                label_transKEY.Text = textBox_transKEY.TextLength.ToString();
            }
            if (!IV_Confirm)
            {
                if (textBox_IV.TextLength != 64)
                    label_IV.ForeColor = Color.Red;
                else
                    label_IV.ForeColor = Color.Green;
                label_IV.Text = textBox_IV.TextLength.ToString();
            }
        }

        //transKEY，IV发生变化的界面控制逻辑
        private void textBox_transKEY_TextChanged(object sender, EventArgs e)
        {
            KEY_Confirm = transKEY_Confirm = false;
            label_KEY.ForeColor = Color.Red;
            label_KEY.Text = "主密钥未生成";
            textBox_KEY.Text = "";
        }

        private void textBox_IV_TextChanged(object sender, EventArgs e)
        {
            IV_Confirm = false;
        }

    }
}
