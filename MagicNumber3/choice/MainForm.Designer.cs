namespace MagicNumber3
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.text = new System.Windows.Forms.Label();
            this.btnDecision = new System.Windows.Forms.Button();
            this.lblEnterNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNum = new System.Windows.Forms.TextBox();
            this.enterNum = new System.Windows.Forms.MaskedTextBox();
            this.btnPointOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(100, 72);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(289, 12);
            this.text.TabIndex = 2;
            this.text.Text = "好きな数字を1つ入力してください";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDecision
            // 
            this.btnDecision.Location = new System.Drawing.Point(258, 225);
            this.btnDecision.Name = "btnDecision";
            this.btnDecision.Size = new System.Drawing.Size(96, 23);
            this.btnDecision.TabIndex = 3;
            this.btnDecision.Text = "決定";
            this.btnDecision.UseVisualStyleBackColor = true;
            this.btnDecision.Click += new System.EventHandler(this.BtnDecisionClicked);
            // 
            // lblEnterNum
            // 
            this.lblEnterNum.AutoSize = true;
            this.lblEnterNum.Location = new System.Drawing.Point(240, 129);
            this.lblEnterNum.Name = "lblEnterNum";
            this.lblEnterNum.Size = new System.Drawing.Size(0, 12);
            this.lblEnterNum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "最初の数字";
            // 
            // firstNum
            // 
            this.firstNum.Enabled = false;
            this.firstNum.Location = new System.Drawing.Point(141, 229);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(75, 19);
            this.firstNum.TabIndex = 6;
            // 
            // enterNum
            // 
            this.enterNum.Location = new System.Drawing.Point(141, 140);
            this.enterNum.Mask = "99999";
            this.enterNum.Name = "enterNum";
            this.enterNum.Size = new System.Drawing.Size(192, 19);
            this.enterNum.TabIndex = 7;
            this.enterNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enterNum.ValidatingType = typeof(int);
            // 
            // btnPointOut
            // 
            this.btnPointOut.Location = new System.Drawing.Point(258, 282);
            this.btnPointOut.Name = "btnPointOut";
            this.btnPointOut.Size = new System.Drawing.Size(96, 40);
            this.btnPointOut.TabIndex = 8;
            this.btnPointOut.Text = "トリックを指摘する";
            this.btnPointOut.UseVisualStyleBackColor = true;
            this.btnPointOut.Click += new System.EventHandler(this.BtnPointOutClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 363);
            this.Controls.Add(this.btnPointOut);
            this.Controls.Add(this.enterNum);
            this.Controls.Add(this.firstNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnterNum);
            this.Controls.Add(this.btnDecision);
            this.Controls.Add(this.text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MagicNumber3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button btnDecision;
        private System.Windows.Forms.Label lblEnterNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNum;
        private System.Windows.Forms.MaskedTextBox enterNum;
        private System.Windows.Forms.Button btnPointOut;
    }
}

