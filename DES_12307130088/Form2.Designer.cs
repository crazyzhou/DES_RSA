namespace DES_12307130088
{
    partial class Form2
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
            this.button_file = new System.Windows.Forms.Button();
            this.button_RSA = new System.Windows.Forms.Button();
            this.button_randKEY = new System.Windows.Forms.Button();
            this.button_confKEY = new System.Windows.Forms.Button();
            this.button_transKEY = new System.Windows.Forms.Button();
            this.button_DES = new System.Windows.Forms.Button();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label_filename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_e = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_KEY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_IV = new System.Windows.Forms.TextBox();
            this.label_IV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.textBox_KEY = new System.Windows.Forms.TextBox();
            this.textBox_transKEY = new System.Windows.Forms.TextBox();
            this.label_RSA = new System.Windows.Forms.Label();
            this.button_randIV = new System.Windows.Forms.Button();
            this.button_confIV = new System.Windows.Forms.Button();
            this.label_transKEY = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_copy_transKEY = new System.Windows.Forms.Button();
            this.button_copy_IV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_file
            // 
            this.button_file.Location = new System.Drawing.Point(464, 17);
            this.button_file.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(139, 41);
            this.button_file.TabIndex = 0;
            this.button_file.Text = "打开待加密文件";
            this.button_file.UseVisualStyleBackColor = true;
            this.button_file.Click += new System.EventHandler(this.button_file_Click);
            // 
            // button_RSA
            // 
            this.button_RSA.Location = new System.Drawing.Point(839, 115);
            this.button_RSA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_RSA.Name = "button_RSA";
            this.button_RSA.Size = new System.Drawing.Size(146, 33);
            this.button_RSA.TabIndex = 1;
            this.button_RSA.Text = "RSA公钥输入确认";
            this.button_RSA.UseVisualStyleBackColor = true;
            this.button_RSA.Click += new System.EventHandler(this.button_RSA_Click);
            // 
            // button_randKEY
            // 
            this.button_randKEY.Location = new System.Drawing.Point(730, 201);
            this.button_randKEY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_randKEY.Name = "button_randKEY";
            this.button_randKEY.Size = new System.Drawing.Size(87, 33);
            this.button_randKEY.TabIndex = 2;
            this.button_randKEY.Text = "随机生成KEY";
            this.button_randKEY.UseVisualStyleBackColor = true;
            this.button_randKEY.Click += new System.EventHandler(this.button_randKEY_Click);
            // 
            // button_confKEY
            // 
            this.button_confKEY.Location = new System.Drawing.Point(827, 201);
            this.button_confKEY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_confKEY.Name = "button_confKEY";
            this.button_confKEY.Size = new System.Drawing.Size(158, 33);
            this.button_confKEY.TabIndex = 3;
            this.button_confKEY.Text = "主密钥确认并进行加密";
            this.button_confKEY.UseVisualStyleBackColor = true;
            this.button_confKEY.Click += new System.EventHandler(this.button_confKEY_Click);
            // 
            // button_transKEY
            // 
            this.button_transKEY.Location = new System.Drawing.Point(694, 314);
            this.button_transKEY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_transKEY.Name = "button_transKEY";
            this.button_transKEY.Size = new System.Drawing.Size(138, 33);
            this.button_transKEY.TabIndex = 4;
            this.button_transKEY.Text = "传送主密钥确认";
            this.button_transKEY.UseVisualStyleBackColor = true;
            this.button_transKEY.Click += new System.EventHandler(this.button_transKEY_Click);
            // 
            // button_DES
            // 
            this.button_DES.Location = new System.Drawing.Point(463, 451);
            this.button_DES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_DES.Name = "button_DES";
            this.button_DES.Size = new System.Drawing.Size(186, 52);
            this.button_DES.TabIndex = 5;
            this.button_DES.Text = "对文件进行DES加密";
            this.button_DES.UseVisualStyleBackColor = true;
            this.button_DES.Click += new System.EventHandler(this.button_DES_Click);
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(194, 120);
            this.textBox_e.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(477, 23);
            this.textBox_e.TabIndex = 6;
            this.textBox_e.TextChanged += new System.EventHandler(this.textBox_e_TextChanged);
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(56, 161);
            this.textBox_n.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(929, 23);
            this.textBox_n.TabIndex = 7;
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.ForeColor = System.Drawing.Color.Red;
            this.label_filename.Location = new System.Drawing.Point(120, 75);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(68, 17);
            this.label_filename.TabIndex = 8;
            this.label_filename.Text = "文件未读取";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "接收方RSA加密算法公钥：";
            // 
            // label_e
            // 
            this.label_e.AutoSize = true;
            this.label_e.Location = new System.Drawing.Point(160, 123);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(28, 17);
            this.label_e.TabIndex = 10;
            this.label_e.Text = "e =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "主密钥KEY：";
            // 
            // label_KEY
            // 
            this.label_KEY.AutoSize = true;
            this.label_KEY.Location = new System.Drawing.Point(617, 209);
            this.label_KEY.Name = "label_KEY";
            this.label_KEY.Size = new System.Drawing.Size(15, 17);
            this.label_KEY.TabIndex = 13;
            this.label_KEY.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "传送主秘钥KEY\'：";
            // 
            // textBox_IV
            // 
            this.textBox_IV.Location = new System.Drawing.Point(107, 381);
            this.textBox_IV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_IV.Name = "textBox_IV";
            this.textBox_IV.Size = new System.Drawing.Size(476, 23);
            this.textBox_IV.TabIndex = 15;
            this.textBox_IV.Text = "0000000000000000000000000000000000000000000000000000000000000000";
            this.textBox_IV.TextChanged += new System.EventHandler(this.textBox_IV_TextChanged);
            // 
            // label_IV
            // 
            this.label_IV.AutoSize = true;
            this.label_IV.Location = new System.Drawing.Point(589, 384);
            this.label_IV.Name = "label_IV";
            this.label_IV.Size = new System.Drawing.Size(22, 17);
            this.label_IV.TabIndex = 16;
            this.label_IV.Text = "64";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "初始向量IV：";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(22, 164);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(28, 17);
            this.label_n.TabIndex = 20;
            this.label_n.Text = "n =";
            // 
            // textBox_KEY
            // 
            this.textBox_KEY.Location = new System.Drawing.Point(132, 206);
            this.textBox_KEY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_KEY.Name = "textBox_KEY";
            this.textBox_KEY.Size = new System.Drawing.Size(479, 23);
            this.textBox_KEY.TabIndex = 21;
            this.textBox_KEY.TextChanged += new System.EventHandler(this.textBox_KEY_TextChanged);
            // 
            // textBox_transKEY
            // 
            this.textBox_transKEY.Enabled = false;
            this.textBox_transKEY.Location = new System.Drawing.Point(44, 281);
            this.textBox_transKEY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_transKEY.Name = "textBox_transKEY";
            this.textBox_transKEY.Size = new System.Drawing.Size(941, 23);
            this.textBox_transKEY.TabIndex = 22;
            // 
            // label_RSA
            // 
            this.label_RSA.AutoSize = true;
            this.label_RSA.ForeColor = System.Drawing.Color.Red;
            this.label_RSA.Location = new System.Drawing.Point(691, 123);
            this.label_RSA.Name = "label_RSA";
            this.label_RSA.Size = new System.Drawing.Size(91, 17);
            this.label_RSA.TabIndex = 23;
            this.label_RSA.Text = "RSA公钥未确认";
            // 
            // button_randIV
            // 
            this.button_randIV.Location = new System.Drawing.Point(694, 376);
            this.button_randIV.Name = "button_randIV";
            this.button_randIV.Size = new System.Drawing.Size(86, 33);
            this.button_randIV.TabIndex = 24;
            this.button_randIV.Text = "随机生成IV";
            this.button_randIV.UseVisualStyleBackColor = true;
            this.button_randIV.Click += new System.EventHandler(this.button_randIV_Click);
            // 
            // button_confIV
            // 
            this.button_confIV.Location = new System.Drawing.Point(786, 376);
            this.button_confIV.Name = "button_confIV";
            this.button_confIV.Size = new System.Drawing.Size(99, 33);
            this.button_confIV.TabIndex = 25;
            this.button_confIV.Text = "初始向量确认";
            this.button_confIV.UseVisualStyleBackColor = true;
            this.button_confIV.Click += new System.EventHandler(this.button_confIV_Click);
            // 
            // label_transKEY
            // 
            this.label_transKEY.AutoSize = true;
            this.label_transKEY.ForeColor = System.Drawing.Color.Red;
            this.label_transKEY.Location = new System.Drawing.Point(567, 322);
            this.label_transKEY.Name = "label_transKEY";
            this.label_transKEY.Size = new System.Drawing.Size(104, 17);
            this.label_transKEY.TabIndex = 26;
            this.label_transKEY.Text = "传送主秘钥未生成";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_copy_transKEY
            // 
            this.button_copy_transKEY.Location = new System.Drawing.Point(850, 314);
            this.button_copy_transKEY.Name = "button_copy_transKEY";
            this.button_copy_transKEY.Size = new System.Drawing.Size(135, 33);
            this.button_copy_transKEY.TabIndex = 27;
            this.button_copy_transKEY.Text = "拷贝传送主密钥";
            this.button_copy_transKEY.UseVisualStyleBackColor = true;
            this.button_copy_transKEY.Click += new System.EventHandler(this.button_copy_transKEY_Click);
            // 
            // button_copy_IV
            // 
            this.button_copy_IV.Location = new System.Drawing.Point(891, 376);
            this.button_copy_IV.Name = "button_copy_IV";
            this.button_copy_IV.Size = new System.Drawing.Size(98, 33);
            this.button_copy_IV.TabIndex = 28;
            this.button_copy_IV.Text = "拷贝初始向量";
            this.button_copy_IV.UseVisualStyleBackColor = true;
            this.button_copy_IV.Click += new System.EventHandler(this.button_copy_IV_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 521);
            this.Controls.Add(this.button_copy_IV);
            this.Controls.Add(this.button_copy_transKEY);
            this.Controls.Add(this.label_transKEY);
            this.Controls.Add(this.button_confIV);
            this.Controls.Add(this.button_randIV);
            this.Controls.Add(this.label_RSA);
            this.Controls.Add(this.textBox_transKEY);
            this.Controls.Add(this.textBox_KEY);
            this.Controls.Add(this.label_n);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_IV);
            this.Controls.Add(this.textBox_IV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_KEY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_e);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_filename);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.button_DES);
            this.Controls.Add(this.button_transKEY);
            this.Controls.Add(this.button_confKEY);
            this.Controls.Add(this.button_randKEY);
            this.Controls.Add(this.button_RSA);
            this.Controls.Add(this.button_file);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 200);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "发送方";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_file;
        private System.Windows.Forms.Button button_RSA;
        private System.Windows.Forms.Button button_randKEY;
        private System.Windows.Forms.Button button_confKEY;
        private System.Windows.Forms.Button button_transKEY;
        private System.Windows.Forms.Button button_DES;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label_filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_KEY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_IV;
        private System.Windows.Forms.Label label_IV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.TextBox textBox_KEY;
        private System.Windows.Forms.TextBox textBox_transKEY;
        private System.Windows.Forms.Label label_RSA;
        private System.Windows.Forms.Button button_randIV;
        private System.Windows.Forms.Button button_confIV;
        private System.Windows.Forms.Label label_transKEY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_copy_transKEY;
        private System.Windows.Forms.Button button_copy_IV;
    }
}