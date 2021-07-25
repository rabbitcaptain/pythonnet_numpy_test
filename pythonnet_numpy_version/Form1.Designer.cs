namespace pythonnet_numpy_version
{
    partial class Form1
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
            this.labelNumpyVersion = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumpyVersion
            // 
            this.labelNumpyVersion.AutoSize = true;
            this.labelNumpyVersion.Location = new System.Drawing.Point(20, 19);
            this.labelNumpyVersion.Name = "labelNumpyVersion";
            this.labelNumpyVersion.Size = new System.Drawing.Size(89, 12);
            this.labelNumpyVersion.TabIndex = 0;
            this.labelNumpyVersion.Text = "numpyバージョン：";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(17, 56);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(94, 12);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "np.cos(np.pi / 3)=";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(56, 76);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(188, 25);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "計算";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 108);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelNumpyVersion);
            this.Name = "Form1";
            this.Text = "pythonnetテスト";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumpyVersion;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalc;
    }
}

