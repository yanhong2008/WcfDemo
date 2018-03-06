namespace WinformClient
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
            this.btn_CurrentTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CurrentTime
            // 
            this.btn_CurrentTime.Location = new System.Drawing.Point(111, 113);
            this.btn_CurrentTime.Name = "btn_CurrentTime";
            this.btn_CurrentTime.Size = new System.Drawing.Size(138, 46);
            this.btn_CurrentTime.TabIndex = 0;
            this.btn_CurrentTime.Text = "输出当前时间";
            this.btn_CurrentTime.UseVisualStyleBackColor = true;
            this.btn_CurrentTime.Click += new System.EventHandler(this.btn_CurrentTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 327);
            this.Controls.Add(this.btn_CurrentTime);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CurrentTime;
    }
}

