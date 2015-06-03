namespace DES_12307130088
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_filename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_e = new System.Windows.Forms.Label();
            this.label_d = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.button_file = new System.Windows.Forms.Button();
            this.button_RSA = new System.Windows.Forms.Button();
            this.button_transKEY = new System.Windows.Forms.Button();
            this.button_KEY = new System.Windows.Forms.Button();
            this.button_DES = new System.Windows.Forms.Button();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_transKEY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_transKEY = new System.Windows.Forms.TextBox();
            this.textBox_KEY = new System.Windows.Forms.TextBox();
            this.textBox_IV = new System.Windows.Forms.TextBox();
            this.label_KEY = new System.Windows.Forms.Label();
            this.label_IV = new System.Windows.Forms.Label();
            this.button_IV = new System.Windows.Forms.Button();
            this.label_RSA = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.ForeColor = System.Drawing.Color.Red;
            this.label_filename.Location = new System.Drawing.Point(100, 83);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(68, 17);
            this.label_filename.TabIndex = 0;
            this.label_filename.Text = "文件未读取";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "RSA加密算法公钥：";
            // 
            // label_e
            // 
            this.label_e.AutoSize = true;
            this.label_e.Location = new System.Drawing.Point(135, 121);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(28, 17);
            this.label_e.TabIndex = 2;
            this.label_e.Text = "e =";
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Location = new System.Drawing.Point(39, 188);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(29, 17);
            this.label_d.TabIndex = 3;
            this.label_d.Text = "d =";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(39, 157);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(28, 17);
            this.label_n.TabIndex = 4;
            this.label_n.Text = "n =";
            // 
            // button_file
            // 
            this.button_file.Location = new System.Drawing.Point(448, 27);
            this.button_file.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(139, 42);
            this.button_file.TabIndex = 5;
            this.button_file.Text = "打开待解密文件";
            this.button_file.UseVisualStyleBackColor = true;
            this.button_file.Click += new System.EventHandler(this.button_file_Click);
            // 
            // button_RSA
            // 
            this.button_RSA.Location = new System.Drawing.Point(826, 113);
            this.button_RSA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_RSA.Name = "button_RSA";
            this.button_RSA.Size = new System.Drawing.Size(152, 33);
            this.button_RSA.TabIndex = 6;
            this.button_RSA.Text = "获取本地用户公钥、私钥";
            this.button_RSA.UseVisualStyleBackColor = true;
            this.button_RSA.Click += new System.EventHandler(this.button_RSA_Click);
            // 
            // button_transKEY
            // 
            this.button_transKEY.Location = new System.Drawing.Point(799, 282);
            this.button_transKEY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_transKEY.Name = "button_transKEY";
            this.button_transKEY.Size = new System.Drawing.Size(152, 33);
            this.button_transKEY.TabIndex = 7;
            this.button_transKEY.Text = "传送主密钥确认并解密";
            this.button_transKEY.UseVisualStyleBackColor = true;
            this.button_transKEY.Click += new System.EventHandler(this.button_transKEY_Click);
            // 
            // button_KEY
            // 
            this.button_KEY.Location = new System.Drawing.Point(799, 330);
            this.button_KEY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_KEY.Name = "button_KEY";
            this.button_KEY.Size = new System.Drawing.Size(115, 33);
            this.button_KEY.TabIndex = 8;
            this.button_KEY.Text = "主密钥确认";
            this.button_KEY.UseVisualStyleBackColor = true;
            this.button_KEY.Click += new System.EventHandler(this.button_KEY_Click);
            // 
            // button_DES
            // 
            this.button_DES.Location = new System.Drawing.Point(466, 447);
            this.button_DES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_DES.Name = "button_DES";
            this.button_DES.Size = new System.Drawing.Size(186, 52);
            this.button_DES.TabIndex = 9;
            this.button_DES.Text = "对文件进行DES解密";
            this.button_DES.UseVisualStyleBackColor = true;
            this.button_DES.Click += new System.EventHandler(this.button_DES_Click);
            // 
            // textBox_e
            // 
            this.textBox_e.Enabled = false;
            this.textBox_e.Location = new System.Drawing.Point(169, 118);
            this.textBox_e.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(467, 23);
            this.textBox_e.TabIndex = 10;
            // 
            // textBox_d
            // 
            this.textBox_d.Enabled = false;
            this.textBox_d.Location = new System.Drawing.Point(74, 185);
            this.textBox_d.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(918, 23);
            this.textBox_d.TabIndex = 11;
            // 
            // textBox_n
            // 
            this.textBox_n.Enabled = false;
            this.textBox_n.Location = new System.Drawing.Point(73, 154);
            this.textBox_n.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(919, 23);
            this.textBox_n.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "传送主密钥KEY\'：";
            // 
            // label_transKEY
            // 
            this.label_transKEY.AutoSize = true;
            this.label_transKEY.Location = new System.Drawing.Point(639, 290);
            this.label_transKEY.Name = "label_transKEY";
            this.label_transKEY.Size = new System.Drawing.Size(15, 17);
            this.label_transKEY.TabIndex = 16;
            this.label_transKEY.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "主密钥KEY：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "初始向量IV：";
            // 
            // textBox_transKEY
            // 
            this.textBox_transKEY.Location = new System.Drawing.Point(49, 250);
            this.textBox_transKEY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_transKEY.Name = "textBox_transKEY";
            this.textBox_transKEY.Size = new System.Drawing.Size(943, 23);
            this.textBox_transKEY.TabIndex = 19;
            this.textBox_transKEY.TextChanged += new System.EventHandler(this.textBox_transKEY_TextChanged);
            // 
            // textBox_KEY
            // 
            this.textBox_KEY.Enabled = false;
            this.textBox_KEY.Location = new System.Drawing.Point(141, 335);
            this.textBox_KEY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_KEY.Name = "textBox_KEY";
            this.textBox_KEY.Size = new System.Drawing.Size(479, 23);
            this.textBox_KEY.TabIndex = 20;
            // 
            // textBox_IV
            // 
            this.textBox_IV.Location = new System.Drawing.Point(141, 389);
            this.textBox_IV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_IV.Name = "textBox_IV";
            this.textBox_IV.Size = new System.Drawing.Size(479, 23);
            this.textBox_IV.TabIndex = 21;
            this.textBox_IV.Text = "0000000000000000000000000000000000000000000000000000000000000000";
            this.textBox_IV.TextChanged += new System.EventHandler(this.textBox_IV_TextChanged);
            // 
            // label_KEY
            // 
            this.label_KEY.AutoSize = true;
            this.label_KEY.ForeColor = System.Drawing.Color.Red;
            this.label_KEY.Location = new System.Drawing.Point(639, 338);
            this.label_KEY.Name = "label_KEY";
            this.label_KEY.Size = new System.Drawing.Size(80, 17);
            this.label_KEY.TabIndex = 22;
            this.label_KEY.Text = "主密钥未生成";
            // 
            // label_IV
            // 
            this.label_IV.AutoSize = true;
            this.label_IV.Location = new System.Drawing.Point(637, 392);
            this.label_IV.Name = "label_IV";
            this.label_IV.Size = new System.Drawing.Size(22, 17);
            this.label_IV.TabIndex = 23;
            this.label_IV.Text = "64";
            // 
            // button_IV
            // 
            this.button_IV.Location = new System.Drawing.Point(799, 384);
            this.button_IV.Name = "button_IV";
            this.button_IV.Size = new System.Drawing.Size(115, 33);
            this.button_IV.TabIndex = 24;
            this.button_IV.Text = "初始向量确认";
            this.button_IV.UseVisualStyleBackColor = true;
            this.button_IV.Click += new System.EventHandler(this.button_IV_Click);
            // 
            // label_RSA
            // 
            this.label_RSA.AutoSize = true;
            this.label_RSA.ForeColor = System.Drawing.Color.Red;
            this.label_RSA.Location = new System.Drawing.Point(667, 121);
            this.label_RSA.Name = "label_RSA";
            this.label_RSA.Size = new System.Drawing.Size(115, 17);
            this.label_RSA.TabIndex = 25;
            this.label_RSA.Text = "RSA公钥私钥未获取";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 521);
            this.Controls.Add(this.label_RSA);
            this.Controls.Add(this.button_IV);
            this.Controls.Add(this.label_IV);
            this.Controls.Add(this.label_KEY);
            this.Controls.Add(this.textBox_IV);
            this.Controls.Add(this.textBox_KEY);
            this.Controls.Add(this.textBox_transKEY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_transKEY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.button_DES);
            this.Controls.Add(this.button_KEY);
            this.Controls.Add(this.button_transKEY);
            this.Controls.Add(this.button_RSA);
            this.Controls.Add(this.button_file);
            this.Controls.Add(this.label_n);
            this.Controls.Add(this.label_d);
            this.Controls.Add(this.label_e);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_filename);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(240, 200);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "接收方";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Button button_file;
        private System.Windows.Forms.Button button_RSA;
        private System.Windows.Forms.Button button_transKEY;
        private System.Windows.Forms.Button button_KEY;
        private System.Windows.Forms.Button button_DES;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_transKEY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_transKEY;
        private System.Windows.Forms.TextBox textBox_KEY;
        private System.Windows.Forms.TextBox textBox_IV;
        private System.Windows.Forms.Label label_KEY;
        private System.Windows.Forms.Label label_IV;
        private System.Windows.Forms.Button button_IV;
        private System.Windows.Forms.Label label_RSA;
        private System.Windows.Forms.Timer timer1;
    }
}