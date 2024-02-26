namespace MyEvent
{
    partial class IOBtn
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSwith = new System.Windows.Forms.Button();
            this.lbIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSwith
            // 
            this.btnSwith.BackgroundImage = global::MyEvent.Resource1.btnON3;
            this.btnSwith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwith.Location = new System.Drawing.Point(141, 5);
            this.btnSwith.Name = "btnSwith";
            this.btnSwith.Size = new System.Drawing.Size(102, 50);
            this.btnSwith.TabIndex = 0;
            this.btnSwith.Tag = "0";
            this.btnSwith.UseVisualStyleBackColor = true;
            this.btnSwith.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbIP.Location = new System.Drawing.Point(3, 20);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(123, 35);
            this.lbIP.TabIndex = 1;
            this.lbIP.Text = "label1";
            // 
            // IOBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.btnSwith);
            this.Name = "IOBtn";
            this.Size = new System.Drawing.Size(251, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwith;
        private System.Windows.Forms.Label lbIP;
    }
}
