namespace MagicNumber3
{
    partial class PointOutForm
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
            this.btnPointOutSelect1 = new System.Windows.Forms.Button();
            this.btnPointOutSelect2 = new System.Windows.Forms.Button();
            this.btnPointOutSelect3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPointOutSelect1
            // 
            this.btnPointOutSelect1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointOutSelect1.Location = new System.Drawing.Point(190, 95);
            this.btnPointOutSelect1.Name = "btnPointOutSelect1";
            this.btnPointOutSelect1.Size = new System.Drawing.Size(445, 31);
            this.btnPointOutSelect1.TabIndex = 0;
            this.btnPointOutSelect1.Text = "必ず5になる";
            this.btnPointOutSelect1.UseVisualStyleBackColor = true;
            this.btnPointOutSelect1.Click += new System.EventHandler(this.BtnPointOutSelect1Clicked);
            // 
            // btnPointOutSelect2
            // 
            this.btnPointOutSelect2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointOutSelect2.Location = new System.Drawing.Point(190, 203);
            this.btnPointOutSelect2.Name = "btnPointOutSelect2";
            this.btnPointOutSelect2.Size = new System.Drawing.Size(445, 31);
            this.btnPointOutSelect2.TabIndex = 1;
            this.btnPointOutSelect2.Text = "必ず10になる";
            this.btnPointOutSelect2.UseVisualStyleBackColor = true;
            this.btnPointOutSelect2.Click += new System.EventHandler(this.BtnPointOutSelect2Clicked);
            // 
            // btnPointOutSelect3
            // 
            this.btnPointOutSelect3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointOutSelect3.Location = new System.Drawing.Point(190, 312);
            this.btnPointOutSelect3.Name = "btnPointOutSelect3";
            this.btnPointOutSelect3.Size = new System.Drawing.Size(445, 31);
            this.btnPointOutSelect3.TabIndex = 2;
            this.btnPointOutSelect3.Text = "必ず0になる";
            this.btnPointOutSelect3.UseVisualStyleBackColor = true;
            this.btnPointOutSelect3.Click += new System.EventHandler(this.BtnPointOutSelect3Clicked);
            // 
            // PointOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPointOutSelect3);
            this.Controls.Add(this.btnPointOutSelect2);
            this.Controls.Add(this.btnPointOutSelect1);
            this.Name = "PointOutForm";
            this.Text = "PointOutForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPointOutSelect1;
        private System.Windows.Forms.Button btnPointOutSelect2;
        private System.Windows.Forms.Button btnPointOutSelect3;
    }
}