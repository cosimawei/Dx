
namespace RunBot
{
    partial class FrmPcsBot
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.target_token_contract = new System.Windows.Forms.Label();
            this.txt_target_token_contract = new System.Windows.Forms.TextBox();
            this.amountIn = new System.Windows.Forms.Label();
            this.txtamountIn = new System.Windows.Forms.TextBox();
            this.txtgasPrice = new System.Windows.Forms.TextBox();
            this.gasPrice = new System.Windows.Forms.Label();
            this.txtgasLimit = new System.Windows.Forms.TextBox();
            this.gasLimit = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.Label();
            this.cmbmode = new System.Windows.Forms.ComboBox();
            this.recipientWallet = new System.Windows.Forms.Label();
            this.txtrecipientWallet = new System.Windows.Forms.TextBox();
            this.seedPhrase = new System.Windows.Forms.Label();
            this.txtseedPhrase = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnexecute = new System.Windows.Forms.Button();
            this.延迟执行 = new System.Windows.Forms.Button();
            this.ricTextStatus = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "机器人目录:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(108, 28);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(281, 21);
            this.txtFolderPath.TabIndex = 1;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(405, 27);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 2;
            this.btnOpenFolder.Text = "选择目录";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // target_token_contract
            // 
            this.target_token_contract.AutoSize = true;
            this.target_token_contract.Location = new System.Drawing.Point(31, 69);
            this.target_token_contract.Name = "target_token_contract";
            this.target_token_contract.Size = new System.Drawing.Size(107, 12);
            this.target_token_contract.TabIndex = 3;
            this.target_token_contract.Text = "需购买的合约地址:";
            // 
            // txt_target_token_contract
            // 
            this.txt_target_token_contract.Location = new System.Drawing.Point(144, 65);
            this.txt_target_token_contract.Name = "txt_target_token_contract";
            this.txt_target_token_contract.Size = new System.Drawing.Size(389, 21);
            this.txt_target_token_contract.TabIndex = 4;
            // 
            // amountIn
            // 
            this.amountIn.AutoSize = true;
            this.amountIn.Location = new System.Drawing.Point(31, 107);
            this.amountIn.Name = "amountIn";
            this.amountIn.Size = new System.Drawing.Size(59, 12);
            this.amountIn.TabIndex = 5;
            this.amountIn.Text = "购买数量:";
            // 
            // txtamountIn
            // 
            this.txtamountIn.Location = new System.Drawing.Point(96, 103);
            this.txtamountIn.Name = "txtamountIn";
            this.txtamountIn.Size = new System.Drawing.Size(89, 21);
            this.txtamountIn.TabIndex = 6;
            // 
            // txtgasPrice
            // 
            this.txtgasPrice.Location = new System.Drawing.Point(268, 103);
            this.txtgasPrice.Name = "txtgasPrice";
            this.txtgasPrice.Size = new System.Drawing.Size(89, 21);
            this.txtgasPrice.TabIndex = 8;
            this.txtgasPrice.Text = "5";
            // 
            // gasPrice
            // 
            this.gasPrice.AutoSize = true;
            this.gasPrice.Location = new System.Drawing.Point(203, 107);
            this.gasPrice.Name = "gasPrice";
            this.gasPrice.Size = new System.Drawing.Size(59, 12);
            this.gasPrice.TabIndex = 7;
            this.gasPrice.Text = "gasPrice:";
            // 
            // txtgasLimit
            // 
            this.txtgasLimit.Location = new System.Drawing.Point(439, 103);
            this.txtgasLimit.Name = "txtgasLimit";
            this.txtgasLimit.Size = new System.Drawing.Size(89, 21);
            this.txtgasLimit.TabIndex = 10;
            this.txtgasLimit.Text = "500000";
            // 
            // gasLimit
            // 
            this.gasLimit.AutoSize = true;
            this.gasLimit.Location = new System.Drawing.Point(374, 107);
            this.gasLimit.Name = "gasLimit";
            this.gasLimit.Size = new System.Drawing.Size(59, 12);
            this.gasLimit.TabIndex = 9;
            this.gasLimit.Text = "gasLimit:";
            // 
            // mode
            // 
            this.mode.AutoSize = true;
            this.mode.Location = new System.Drawing.Point(31, 147);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(35, 12);
            this.mode.TabIndex = 11;
            this.mode.Text = "模式:";
            // 
            // cmbmode
            // 
            this.cmbmode.FormattingEnabled = true;
            this.cmbmode.Items.AddRange(new object[] {
            "1_暂时没用",
            "2_暂时没用",
            "3_买入",
            "4_授权",
            "5_卖出",
            "6_买入后并且授权"});
            this.cmbmode.Location = new System.Drawing.Point(85, 143);
            this.cmbmode.Name = "cmbmode";
            this.cmbmode.Size = new System.Drawing.Size(121, 20);
            this.cmbmode.TabIndex = 12;
            // 
            // recipientWallet
            // 
            this.recipientWallet.AutoSize = true;
            this.recipientWallet.Location = new System.Drawing.Point(31, 187);
            this.recipientWallet.Name = "recipientWallet";
            this.recipientWallet.Size = new System.Drawing.Size(95, 12);
            this.recipientWallet.TabIndex = 5;
            this.recipientWallet.Text = "自己的钱包地址:";
            // 
            // txtrecipientWallet
            // 
            this.txtrecipientWallet.Location = new System.Drawing.Point(134, 184);
            this.txtrecipientWallet.Name = "txtrecipientWallet";
            this.txtrecipientWallet.Size = new System.Drawing.Size(399, 21);
            this.txtrecipientWallet.TabIndex = 6;
            // 
            // seedPhrase
            // 
            this.seedPhrase.AutoSize = true;
            this.seedPhrase.Location = new System.Drawing.Point(31, 228);
            this.seedPhrase.Name = "seedPhrase";
            this.seedPhrase.Size = new System.Drawing.Size(71, 12);
            this.seedPhrase.TabIndex = 7;
            this.seedPhrase.Text = "钱包助记词:";
            // 
            // txtseedPhrase
            // 
            this.txtseedPhrase.Location = new System.Drawing.Point(134, 224);
            this.txtseedPhrase.Name = "txtseedPhrase";
            this.txtseedPhrase.Size = new System.Drawing.Size(399, 21);
            this.txtseedPhrase.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.延迟执行);
            this.groupBox1.Controls.Add(this.btnexecute);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbmode);
            this.groupBox1.Controls.Add(this.txtFolderPath);
            this.groupBox1.Controls.Add(this.mode);
            this.groupBox1.Controls.Add(this.btnOpenFolder);
            this.groupBox1.Controls.Add(this.txtgasLimit);
            this.groupBox1.Controls.Add(this.target_token_contract);
            this.groupBox1.Controls.Add(this.gasLimit);
            this.groupBox1.Controls.Add(this.txt_target_token_contract);
            this.groupBox1.Controls.Add(this.txtseedPhrase);
            this.groupBox1.Controls.Add(this.amountIn);
            this.groupBox1.Controls.Add(this.txtgasPrice);
            this.groupBox1.Controls.Add(this.recipientWallet);
            this.groupBox1.Controls.Add(this.seedPhrase);
            this.groupBox1.Controls.Add(this.txtamountIn);
            this.groupBox1.Controls.Add(this.gasPrice);
            this.groupBox1.Controls.Add(this.txtrecipientWallet);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 279);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "机器人配置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ricTextStatus);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 461);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "执行状态";
            // 
            // btnexecute
            // 
            this.btnexecute.Location = new System.Drawing.Point(621, 223);
            this.btnexecute.Name = "btnexecute";
            this.btnexecute.Size = new System.Drawing.Size(75, 23);
            this.btnexecute.TabIndex = 13;
            this.btnexecute.Text = "立即执行";
            this.btnexecute.UseVisualStyleBackColor = true;
            this.btnexecute.Click += new System.EventHandler(this.btnexecute_Click);
            // 
            // 延迟执行
            // 
            this.延迟执行.Location = new System.Drawing.Point(621, 176);
            this.延迟执行.Name = "延迟执行";
            this.延迟执行.Size = new System.Drawing.Size(75, 23);
            this.延迟执行.TabIndex = 14;
            this.延迟执行.Text = "立即执行";
            this.延迟执行.UseVisualStyleBackColor = true;
            // 
            // ricTextStatus
            // 
            this.ricTextStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ricTextStatus.Location = new System.Drawing.Point(3, 17);
            this.ricTextStatus.Name = "ricTextStatus";
            this.ricTextStatus.Size = new System.Drawing.Size(992, 441);
            this.ricTextStatus.TabIndex = 0;
            this.ricTextStatus.Text = "";
            // 
            // FrmPcsBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 740);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPcsBot";
            this.Text = "博饼";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label target_token_contract;
        private System.Windows.Forms.TextBox txt_target_token_contract;
        private System.Windows.Forms.Label amountIn;
        private System.Windows.Forms.TextBox txtamountIn;
        private System.Windows.Forms.TextBox txtgasPrice;
        private System.Windows.Forms.Label gasPrice;
        private System.Windows.Forms.TextBox txtgasLimit;
        private System.Windows.Forms.Label gasLimit;
        private System.Windows.Forms.Label mode;
        private System.Windows.Forms.ComboBox cmbmode;
        private System.Windows.Forms.Label recipientWallet;
        private System.Windows.Forms.TextBox txtrecipientWallet;
        private System.Windows.Forms.Label seedPhrase;
        private System.Windows.Forms.TextBox txtseedPhrase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnexecute;
        private System.Windows.Forms.Button 延迟执行;
        private System.Windows.Forms.RichTextBox ricTextStatus;
    }
}