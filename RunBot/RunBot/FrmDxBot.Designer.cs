
namespace RunBot
{
    partial class FrmDxBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDxBot));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnExecMore = new System.Windows.Forms.Button();
            this.btnExecNow = new System.Windows.Forms.Button();
            this.txtmnemonic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lalnum = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgasLimit = new System.Windows.Forms.TextBox();
            this.txtgasPrice = new System.Windows.Forms.TextBox();
            this.txtPresale_address = new System.Windows.Forms.TextBox();
            this.lalgasLimit = new System.Windows.Forms.Label();
            this.lalgasPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTimeExec = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblShow);
            this.groupBox1.Controls.Add(this.txtS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHours);
            this.groupBox1.Controls.Add(this.btnLock);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnTimeExec);
            this.groupBox1.Controls.Add(this.btnExecMore);
            this.groupBox1.Controls.Add(this.btnExecNow);
            this.groupBox1.Controls.Add(this.txtmnemonic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnum);
            this.groupBox1.Controls.Add(this.lalnum);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtgasLimit);
            this.groupBox1.Controls.Add(this.txtgasPrice);
            this.groupBox1.Controls.Add(this.txtPresale_address);
            this.groupBox1.Controls.Add(this.lalgasLimit);
            this.groupBox1.Controls.Add(this.lalgasPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初始设置";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.ForeColor = System.Drawing.Color.Red;
            this.lblShow.Location = new System.Drawing.Point(417, 244);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(0, 12);
            this.lblShow.TabIndex = 15;
            // 
            // txtS
            // 
            this.txtS.ForeColor = System.Drawing.Color.Red;
            this.txtS.Location = new System.Drawing.Point(471, 219);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(26, 21);
            this.txtS.TabIndex = 8;
            this.txtS.Text = "0";
            this.txtS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(473, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // txtMin
            // 
            this.txtMin.ForeColor = System.Drawing.Color.Red;
            this.txtMin.Location = new System.Drawing.Point(434, 219);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(26, 21);
            this.txtMin.TabIndex = 7;
            this.txtMin.Text = "0";
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(437, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // txtHours
            // 
            this.txtHours.ForeColor = System.Drawing.Color.Red;
            this.txtHours.Location = new System.Drawing.Point(399, 219);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(26, 21);
            this.txtHours.TabIndex = 6;
            this.txtHours.Text = "0";
            this.txtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(125, 218);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 6;
            this.btnLock.Text = "锁定";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnExecMore
            // 
            this.btnExecMore.Location = new System.Drawing.Point(298, 218);
            this.btnExecMore.Name = "btnExecMore";
            this.btnExecMore.Size = new System.Drawing.Size(75, 23);
            this.btnExecMore.TabIndex = 8;
            this.btnExecMore.Text = "并发执行";
            this.btnExecMore.UseVisualStyleBackColor = true;
            this.btnExecMore.Click += new System.EventHandler(this.btnExecMore_Click);
            // 
            // btnExecNow
            // 
            this.btnExecNow.Location = new System.Drawing.Point(210, 218);
            this.btnExecNow.Name = "btnExecNow";
            this.btnExecNow.Size = new System.Drawing.Size(75, 23);
            this.btnExecNow.TabIndex = 7;
            this.btnExecNow.Text = "立即执行";
            this.btnExecNow.UseVisualStyleBackColor = true;
            this.btnExecNow.Click += new System.EventHandler(this.btnExecNow_Click);
            // 
            // txtmnemonic
            // 
            this.txtmnemonic.Location = new System.Drawing.Point(191, 182);
            this.txtmnemonic.Name = "txtmnemonic";
            this.txtmnemonic.Size = new System.Drawing.Size(383, 21);
            this.txtmnemonic.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "钱包助记词:";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(191, 146);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(158, 21);
            this.txtnum.TabIndex = 4;
            this.txtnum.Text = "1";
            this.txtnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // lalnum
            // 
            this.lalnum.AutoSize = true;
            this.lalnum.Location = new System.Drawing.Point(126, 150);
            this.lalnum.Name = "lalnum";
            this.lalnum.Size = new System.Drawing.Size(59, 12);
            this.lalnum.TabIndex = 6;
            this.lalnum.Text = "购买次数:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(191, 109);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(158, 21);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "购买数量(bnb):";
            // 
            // txtgasLimit
            // 
            this.txtgasLimit.Location = new System.Drawing.Point(447, 72);
            this.txtgasLimit.Name = "txtgasLimit";
            this.txtgasLimit.Size = new System.Drawing.Size(124, 21);
            this.txtgasLimit.TabIndex = 2;
            this.txtgasLimit.Text = "500000";
            this.txtgasLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // txtgasPrice
            // 
            this.txtgasPrice.Location = new System.Drawing.Point(191, 72);
            this.txtgasPrice.Name = "txtgasPrice";
            this.txtgasPrice.Size = new System.Drawing.Size(105, 21);
            this.txtgasPrice.TabIndex = 1;
            this.txtgasPrice.Text = "5";
            this.txtgasPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // txtPresale_address
            // 
            this.txtPresale_address.Location = new System.Drawing.Point(191, 38);
            this.txtPresale_address.Name = "txtPresale_address";
            this.txtPresale_address.Size = new System.Drawing.Size(383, 21);
            this.txtPresale_address.TabIndex = 0;
            // 
            // lalgasLimit
            // 
            this.lalgasLimit.AutoSize = true;
            this.lalgasLimit.Location = new System.Drawing.Point(382, 76);
            this.lalgasLimit.Name = "lalgasLimit";
            this.lalgasLimit.Size = new System.Drawing.Size(59, 12);
            this.lalgasLimit.TabIndex = 2;
            this.lalgasLimit.Text = "gasLimit:";
            // 
            // lalgasPrice
            // 
            this.lalgasPrice.AutoSize = true;
            this.lalgasPrice.Location = new System.Drawing.Point(126, 76);
            this.lalgasPrice.Name = "lalgasPrice";
            this.lalgasPrice.Size = new System.Drawing.Size(59, 12);
            this.lalgasPrice.TabIndex = 2;
            this.lalgasPrice.Text = "gasPrice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dx预售地址:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "使用说明";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(727, 312);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "1.5gas 大概 0.0021b\n2.Dx预售地址为,Dx预售链接钟Token上面的地址；不是Token地址\n3.购买数量后期再解释\n4.立即执行，并发执行区别" +
    "---A.一次性撞击。B.一次操作多次撞击（会产生更多的矿工费）\n5.助记词仅存本地，不会上传，建议使用新钱包\n6.没啥描述的了";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTimeExec
            // 
            this.btnTimeExec.Location = new System.Drawing.Point(503, 218);
            this.btnTimeExec.Name = "btnTimeExec";
            this.btnTimeExec.Size = new System.Drawing.Size(38, 23);
            this.btnTimeExec.TabIndex = 8;
            this.btnTimeExec.Text = "计时";
            this.btnTimeExec.UseVisualStyleBackColor = true;
            this.btnTimeExec.Click += new System.EventHandler(this.btnTimeExec_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmDxBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDxBot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuckDx";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPresale_address;
        private System.Windows.Forms.TextBox txtgasLimit;
        private System.Windows.Forms.TextBox txtgasPrice;
        private System.Windows.Forms.Label lalgasLimit;
        private System.Windows.Forms.Label lalgasPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lalnum;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtmnemonic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExecNow;
        private System.Windows.Forms.Button btnExecMore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnTimeExec;
        private System.Windows.Forms.Button btnExit;
    }
}