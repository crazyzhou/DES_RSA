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
    public partial class Form2 : Form
    {
        string content;
        string result;
        string dir;
        byte[] KEY = new byte[64];
        byte[] IV = new byte[64];
        bool File_Confirm, IV_Confirm, KEY_Confirm, transKEY_Confirm, RSA_Confirm;
        DES new_des = new DES();
        BigInteger e1, n1;

        public Form2()
        {
            InitializeComponent();
            File_Confirm = IV_Confirm = KEY_Confirm = transKEY_Confirm = RSA_Confirm = false;
            //文件、RSA秘钥、IV、KEY、transKEY已加载5个标志初始化为false
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

        //Padding_PKCS5函数功能：按照PKCS#5标准方法进行待加密串填充。
        //PKCS#5标准方法：填充相同的字节，且该字节的值就是要填充的字节数，恰好8个字节需补8个字节的0x08
        string Padding_PKCS5(string s)
        {
            int i, pd, j;
            int len = s.Length;
            pd = 8 - (int)((s.Length % 64) / 8);
            string pdstr = Convert.ToString(pd, 2);
            for (i = 0; i < pd; i++)
            {
                for (j = 0; j < 8 - pdstr.Length; j++)
                {
                    s += '0';
                }
                s += pdstr;
            }
            return s;
        }

        //Random64函数功能：生成随机的64位二进制字符串
        string Random64()
        {
            int i;
            string s = "";
            Random rnd = new Random();
            for (i = 0; i < 64; i++)
            {
                s += rnd.Next(2);
            }
            return s;
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
                if (content.Length % 8 != 0)
                {
                    MessageBox.Show("二进制文件未按字节（8 bit）对齐，请进行修改并重新选择文件");
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

        // button_RSA_Click：RSA公钥确认按钮
        private void button_RSA_Click(object sender, EventArgs e)
        {
            string estr = textBox_e.Text;
            string nstr = textBox_n.Text;
            if (!binCheck(estr))
            {
                MessageBox.Show("RSA公钥e不符合二进制要求，请进行修改");
                transKEY_Confirm = RSA_Confirm = false;
                return;
            }
            if (!binCheck(nstr))
            {
                MessageBox.Show("RSA公钥n不符合二进制要求，请进行修改");
                transKEY_Confirm = RSA_Confirm = false;
                return;
            }
            if (estr == "")
            {
                MessageBox.Show("请输入RSA公钥e");
                transKEY_Confirm = RSA_Confirm = false;
                return;
            }
            if (nstr.Length !=128)
            {
                MessageBox.Show("RSA公钥n的位数不符合要求（128位），请进行修改");
                transKEY_Confirm = RSA_Confirm = false;
                return;
            }
            e1 = BinstrToBigint(estr);
            n1 = BinstrToBigint(nstr);
            RSA_Confirm = true;
            label_RSA.ForeColor = Color.Blue;
            label_RSA.Text = "RSA公钥已确认";
        }

        //随机生成主密钥KEY
        private void button_randKEY_Click(object sender, EventArgs e)
        {
            KEY_Confirm = transKEY_Confirm = false;
            textBox_KEY.Text = Random64();
        }

        //主密钥KEY确认按钮
        private void button_confKEY_Click(object sender, EventArgs e)
        {
            string k = textBox_KEY.Text;
            if (k.Length != 64 || !binCheck(k))
            {
                MessageBox.Show("主秘钥不符合规范，应为64位二进制串");
                return;
            }
            if (!RSA_Confirm)
            {
                MessageBox.Show("请先输入正确的RSA公钥并确认");
                return;
            }
            for (int i = 0; i < 64; i++)
            {
                KEY[i] = (byte)(k[i] - '0');    //转换为二进制数组KEY，以供DES加密
            }
            textBox_transKEY.Text = Form1.new_rsa.RSA_Encrypt(k, 128, e1, n1);  //RSA加密生成128位的传送主秘钥
            KEY_Confirm = true;
            label_KEY.ForeColor = Color.Blue;
            label_KEY.Text = "主密钥已确认";
            label_transKEY.ForeColor = Color.Green;
            label_transKEY.Text = "传送主秘钥已生成";
        }

        //传送主密钥确认按钮
        private void button_transKEY_Click(object sender, EventArgs e)
        {
            if (textBox_transKEY.Text == "") 
            {
                MessageBox.Show("传送主秘钥未生成");
                return;
            }
            transKEY_Confirm = true;
            label_transKEY.ForeColor = Color.Blue;
            label_transKEY.Text = "传送主密钥已确认";
        }

        //随机生成初始向量IV
        private void button_randIV_Click(object sender, EventArgs e)
        {
            IV_Confirm = false;
            textBox_IV.Text = Random64();
        }

        //初始向量IV确认按钮
        private void button_confIV_Click(object sender, EventArgs e)
        {
            string ivs = textBox_IV.Text;
            if (ivs.Length != 64 || !binCheck(ivs))
            {
                MessageBox.Show("初始向量不符合规范，应为64位二进制串");
                return;
            }
            for (int i = 0; i < 64; i++)
            {
                IV[i] = (byte)(ivs[i] - '0');
            }
            IV_Confirm = true;
            label_IV.ForeColor = Color.Blue;
            label_IV.Text = "初始向量已确认";
        }

        //button_DES_Click：逐64bit进行CBC密码分组模式的DES加密，并写入同一目录的文件CRYTOGRAM.txt
        private void button_DES_Click(object sender, EventArgs e)
        {
            if (!File_Confirm)
            {
                MessageBox.Show("文件未读取!");
                return;
            }
            if (!RSA_Confirm)
            {
                MessageBox.Show("RSA公钥未确认!");
                return;
            }
            if (!KEY_Confirm)
            {
                MessageBox.Show("主密钥未确认并加密!");
                return;
            }
            if (!transKEY_Confirm)
            {
                MessageBox.Show("传送主密钥未确认!");
                return;
            }
            if (!IV_Confirm)
            {
                MessageBox.Show("初始向量未确认!");
                return;
            }
            content = Padding_PKCS5(content);
            result = new_des.DES_Encrypt(KEY, IV, content);
            if (File.Exists(dir + @"\CRYPTOGRAM.txt"))
            {
                File.Delete(dir + @"\CRYPTOGRAM.txt");
            }
            FileStream bFile = new FileStream(dir + @"\CRYPTOGRAM.txt", FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(bFile);
            sw.Write(result);
            sw.Close();
            bFile.Close();
            DialogResult dr;
            dr = MessageBox.Show("加密完成！！", "传送DES算法");
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                File_Confirm = IV_Confirm = KEY_Confirm = RSA_Confirm = transKEY_Confirm= false;
                content = "";
                label_filename.ForeColor = Color.Red;
                label_filename.Text = "文件未读取";
                label_RSA.ForeColor = Color.Red;
                label_RSA.Text = "RSA公钥未确认";
                label_transKEY.ForeColor = Color.Red;
                label_transKEY.Text = "传送主秘钥未生成";
                System.Diagnostics.Process.Start("notepad.exe", dir + @"\CRYPTOGRAM.txt");
            }
        }

        //timer1：时钟，时刻保持label_KEY，label_IV内容（输入的主密钥长度、初始向量长度）
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!KEY_Confirm)
            {
                if (textBox_KEY.TextLength != 64)
                    label_KEY.ForeColor = Color.Red;
                else
                    label_KEY.ForeColor = Color.Green;
                label_KEY.Text = textBox_KEY.TextLength.ToString();
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

        //复制传送主密钥至剪贴板
        private void button_copy_transKEY_Click(object sender, EventArgs e)
        {
            if (textBox_transKEY.Text == "")
            {
                MessageBox.Show("请首先生成传送秘钥KEY'");
                return;
            }
            Clipboard.SetDataObject(textBox_transKEY.Text);
        }

        //复制传送初始向量至剪贴板
        private void button_copy_IV_Click(object sender, EventArgs e)
        {
            if (textBox_IV.TextLength != 64)
            {
                MessageBox.Show("请确认初始向量IV是否正确");
                return;
            }
            Clipboard.SetDataObject(textBox_IV.Text);
        }

        //e，n，KEY，IV发生变化的界面控制逻辑
        private void textBox_e_TextChanged(object sender, EventArgs e)
        {
            RSA_Confirm = KEY_Confirm = transKEY_Confirm = false;
            label_RSA.ForeColor = Color.Red;
            label_RSA.Text = "RSA公钥未确认";
            textBox_transKEY.Text = "";
            label_transKEY.ForeColor = Color.Red;
            label_transKEY.Text = "传送主密钥未生成";
        }

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {
            RSA_Confirm = KEY_Confirm = transKEY_Confirm = false;
            label_RSA.ForeColor = Color.Red;
            label_RSA.Text = "RSA公钥未确认";
            textBox_transKEY.Text = "";
            label_transKEY.ForeColor = Color.Red;
            label_transKEY.Text = "传送主密钥未生成";
        }

        private void textBox_KEY_TextChanged(object sender, EventArgs e)
        {
            KEY_Confirm = transKEY_Confirm = false;
            textBox_transKEY.Text = "";
            label_transKEY.ForeColor = Color.Red;
            label_transKEY.Text = "传送主密钥未生成";
        }

        private void textBox_IV_TextChanged(object sender, EventArgs e)
        {
            IV_Confirm = false;
        }
    }
}
