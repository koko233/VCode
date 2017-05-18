namespace 验证码小程序
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbVCode = new System.Windows.Forms.PictureBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbVCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVCode
            // 
            this.pbVCode.Location = new System.Drawing.Point(232, 91);
            this.pbVCode.Name = "pbVCode";
            this.pbVCode.Size = new System.Drawing.Size(165, 42);
            this.pbVCode.TabIndex = 0;
            this.pbVCode.TabStop = false;
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbInput.Location = new System.Drawing.Point(249, 171);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(92, 34);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "12345";
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btConfirm.Location = new System.Drawing.Point(356, 171);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 34);
            this.btConfirm.TabIndex = 2;
            this.btConfirm.Text = "确定";
            this.btConfirm.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(403, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.pbVCode);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbVCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVCode;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button button1;
    }
}

