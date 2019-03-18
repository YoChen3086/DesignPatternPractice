namespace Strategy
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
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelCount = new System.Windows.Forms.Label();
            this.LabelMethod = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.LabelTotalPrice = new System.Windows.Forms.Label();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.ComboBoxMethod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(26, 30);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(29, 12);
            this.LabelPrice.TabIndex = 0;
            this.LabelPrice.Text = "單價";
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Location = new System.Drawing.Point(26, 66);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(29, 12);
            this.LabelCount.TabIndex = 1;
            this.LabelCount.Text = "數量";
            // 
            // LabelMethod
            // 
            this.LabelMethod.AutoSize = true;
            this.LabelMethod.Location = new System.Drawing.Point(26, 110);
            this.LabelMethod.Name = "LabelMethod";
            this.LabelMethod.Size = new System.Drawing.Size(53, 12);
            this.LabelMethod.TabIndex = 2;
            this.LabelMethod.Text = "計算方式";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 12;
            this.ListBox.Location = new System.Drawing.Point(28, 155);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(372, 124);
            this.ListBox.TabIndex = 3;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(28, 315);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(29, 12);
            this.LabelTotal.TabIndex = 4;
            this.LabelTotal.Text = "總計";
            // 
            // LabelTotalPrice
            // 
            this.LabelTotalPrice.AutoSize = true;
            this.LabelTotalPrice.Location = new System.Drawing.Point(199, 315);
            this.LabelTotalPrice.Name = "LabelTotalPrice";
            this.LabelTotalPrice.Size = new System.Drawing.Size(11, 12);
            this.LabelTotalPrice.TabIndex = 5;
            this.LabelTotalPrice.Text = "0";
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(325, 61);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 23);
            this.BtnEnter.TabIndex = 6;
            this.BtnEnter.Text = "確定";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(325, 105);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "重設";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(157, 19);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 22);
            this.TxtPrice.TabIndex = 8;
            this.TxtPrice.Text = "0";
            this.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCount
            // 
            this.TxtCount.Location = new System.Drawing.Point(157, 61);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(100, 22);
            this.TxtCount.TabIndex = 9;
            this.TxtCount.Text = "1";
            this.TxtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComboBoxMethod
            // 
            this.ComboBoxMethod.FormattingEnabled = true;
            this.ComboBoxMethod.Location = new System.Drawing.Point(157, 107);
            this.ComboBoxMethod.Name = "ComboBoxMethod";
            this.ComboBoxMethod.Size = new System.Drawing.Size(100, 20);
            this.ComboBoxMethod.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 363);
            this.Controls.Add(this.ComboBoxMethod);
            this.Controls.Add(this.TxtCount);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.LabelTotalPrice);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.LabelMethod);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.LabelPrice);
            this.Name = "Form1";
            this.Text = "商場收銀軟體";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.Label LabelMethod;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelTotalPrice;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtCount;
        private System.Windows.Forms.ComboBox ComboBoxMethod;
    }
}

