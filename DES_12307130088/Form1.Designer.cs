namespace DES_12307130088
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_RSA = new System.Windows.Forms.Button();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label_RSAprivate = new System.Windows.Forms.Label();
            this.label_d = new System.Windows.Forms.Label();
            this.button_receiver = new System.Windows.Forms.Button();
            this.button_sender = new System.Windows.Forms.Button();
            this.label_RSApublic = new System.Windows.Forms.Label();
            this.label_e = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label_RSA = new System.Windows.Forms.Label();
            this.button_copy_e = new System.Windows.Forms.Button();
            this.button_copy_n = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_RSA
            // 
            this.button_RSA.Location = new System.Drawing.Point(124, 218);
            this.button_RSA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_RSA.Name = "button_RSA";
            this.button_RSA.Size = new System.Drawing.Size(177, 44);
            this.button_RSA.TabIndex = 0;
            this.button_RSA.Text = "生成本地的RSA公钥、私钥";
            this.button_RSA.UseVisualStyleBackColor = true;
            this.button_RSA.Click += new System.EventHandler(this.button_RSA_Click);
            // 
            // textBox_d
            // 
            this.textBox_d.Enabled = false;
            this.textBox_d.Location = new System.Drawing.Point(54, 131);
            this.textBox_d.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(933, 23);
            this.textBox_d.TabIndex = 1;
            // 
            // label_RSAprivate
            // 
            this.label_RSAprivate.AutoSize = true;
            this.label_RSAprivate.Location = new System.Drawing.Point(19, 105);
            this.label_RSAprivate.Name = "label_RSAprivate";
            this.label_RSAprivate.Size = new System.Drawing.Size(115, 17);
            this.label_RSAprivate.TabIndex = 2;
            this.label_RSAprivate.Text = "RSA加密算法私钥：";
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Location = new System.Drawing.Point(19, 134);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(29, 17);
            this.label_d.TabIndex = 3;
            this.label_d.Text = "d =";
            // 
            // button_receiver
            // 
            this.button_receiver.Location = new System.Drawing.Point(759, 218);
            this.button_receiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_receiver.Name = "button_receiver";
            this.button_receiver.Size = new System.Drawing.Size(177, 44);
            this.button_receiver.TabIndex = 13;
            this.button_receiver.Text = "接收方解密文件";
            this.button_receiver.UseVisualStyleBackColor = true;
            this.button_receiver.Click += new System.EventHandler(this.button_receiver_Click);
            // 
            // button_sender
            // 
            this.button_sender.Location = new System.Drawing.Point(447, 218);
            this.button_sender.Name = "button_sender";
            this.button_sender.Size = new System.Drawing.Size(177, 44);
            this.button_sender.TabIndex = 15;
            this.button_sender.Text = "发送方加密文件";
            this.button_sender.UseVisualStyleBackColor = true;
            this.button_sender.Click += new System.EventHandler(this.button_sender_Click);
            // 
            // label_RSApublic
            // 
            this.label_RSApublic.AutoSize = true;
            this.label_RSApublic.Location = new System.Drawing.Point(19, 29);
            this.label_RSApublic.Name = "label_RSApublic";
            this.label_RSApublic.Size = new System.Drawing.Size(115, 17);
            this.label_RSApublic.TabIndex = 16;
            this.label_RSApublic.Text = "RSA加密算法公钥：";
            // 
            // label_e
            // 
            this.label_e.AutoSize = true;
            this.label_e.Location = new System.Drawing.Point(140, 29);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(28, 17);
            this.label_e.TabIndex = 17;
            this.label_e.Text = "e =";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(19, 66);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(28, 17);
            this.label_n.TabIndex = 18;
            this.label_n.Text = "n =";
            // 
            // textBox_e
            // 
            this.textBox_e.Enabled = false;
            this.textBox_e.Location = new System.Drawing.Point(174, 26);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(563, 23);
            this.textBox_e.TabIndex = 25;
            // 
            // textBox_n
            // 
            this.textBox_n.Enabled = false;
            this.textBox_n.Location = new System.Drawing.Point(53, 63);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(934, 23);
            this.textBox_n.TabIndex = 26;
            // 
            // label_RSA
            // 
            this.label_RSA.AutoSize = true;
            this.label_RSA.ForeColor = System.Drawing.Color.Red;
            this.label_RSA.Location = new System.Drawing.Point(469, 171);
            this.label_RSA.Name = "label_RSA";
            this.label_RSA.Size = new System.Drawing.Size(127, 17);
            this.label_RSA.TabIndex = 27;
            this.label_RSA.Text = "RSA公钥、私钥未生成";
            // 
            // button_copy_e
            // 
            this.button_copy_e.Location = new System.Drawing.Point(743, 21);
            this.button_copy_e.Name = "button_copy_e";
            this.button_copy_e.Size = new System.Drawing.Size(75, 33);
            this.button_copy_e.TabIndex = 28;
            this.button_copy_e.Text = "拷贝公钥e";
            this.button_copy_e.UseVisualStyleBackColor = true;
            this.button_copy_e.Click += new System.EventHandler(this.button_copy_e_Click);
            // 
            // button_copy_n
            // 
            this.button_copy_n.Location = new System.Drawing.Point(993, 58);
            this.button_copy_n.Name = "button_copy_n";
            this.button_copy_n.Size = new System.Drawing.Size(75, 33);
            this.button_copy_n.TabIndex = 30;
            this.button_copy_n.Text = "拷贝公钥n";
            this.button_copy_n.UseVisualStyleBackColor = true;
            this.button_copy_n.Click += new System.EventHandler(this.button_copy_n_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 283);
            this.Controls.Add(this.button_copy_n);
            this.Controls.Add(this.button_copy_e);
            this.Controls.Add(this.label_RSA);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.label_n);
            this.Controls.Add(this.label_e);
            this.Controls.Add(this.label_RSApublic);
            this.Controls.Add(this.button_sender);
            this.Controls.Add(this.button_receiver);
            this.Controls.Add(this.label_d);
            this.Controls.Add(this.label_RSAprivate);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.button_RSA);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(80, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "传送 DES 加密算法   版权所有©周煜敏";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_RSA;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Label label_RSAprivate;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.Button button_receiver;
        private System.Windows.Forms.Button button_sender;
        private System.Windows.Forms.Label label_RSApublic;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label_RSA;
        private System.Windows.Forms.Button button_copy_e;
        private System.Windows.Forms.Button button_copy_n;
    }
}

