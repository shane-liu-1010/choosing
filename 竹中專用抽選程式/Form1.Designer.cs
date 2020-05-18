namespace 竹中專用抽選程式
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cn = new System.Windows.Forms.TextBox();
            this.sn = new System.Windows.Forms.TextBox();
            this.nop = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.oout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入幾班到幾班(例:1-19):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(246, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入座號(例:1-39):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(478, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "要抽取幾人:";
            // 
            // cn
            // 
            this.cn.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cn.Location = new System.Drawing.Point(26, 98);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(100, 25);
            this.cn.TabIndex = 3;
            // 
            // sn
            // 
            this.sn.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.sn.Location = new System.Drawing.Point(249, 98);
            this.sn.Name = "sn";
            this.sn.Size = new System.Drawing.Size(100, 25);
            this.sn.TabIndex = 4;
            // 
            // nop
            // 
            this.nop.Location = new System.Drawing.Point(481, 98);
            this.nop.Name = "nop";
            this.nop.Size = new System.Drawing.Size(100, 25);
            this.nop.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 89);
            this.button1.TabIndex = 7;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oout
            // 
            this.oout.BackColor = System.Drawing.SystemColors.Window;
            this.oout.Font = new System.Drawing.Font("新細明體", 15F);
            this.oout.Location = new System.Drawing.Point(12, 181);
            this.oout.Multiline = true;
            this.oout.Name = "oout";
            this.oout.ReadOnly = true;
            this.oout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.oout.Size = new System.Drawing.Size(392, 288);
            this.oout.TabIndex = 8;
            // 
            // Form1
            // 
            this.BackgroundImage = global::竹中專用抽選程式.Properties.Resources._2009HCHSlogo13;
            this.ClientSize = new System.Drawing.Size(651, 499);
            this.Controls.Add(this.oout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nop);
            this.Controls.Add(this.sn);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Form1";
            this.Text = "竹中專用抽選程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cn;
        private System.Windows.Forms.TextBox sn;
        private System.Windows.Forms.TextBox nop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox oout;
    }
}

