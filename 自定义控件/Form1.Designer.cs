namespace 自定义控件
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
            this.userControl12 = new GoogolButton2.UserControl1();
            this.userControl11 = new GoogolButton2.UserControl1();
            this.ioBtn1 = new MyEvent.IOBtn();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(167, 68);
            this.userControl12.Margin = new System.Windows.Forms.Padding(2);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(69, 69);
            this.userControl12.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(73, 68);
            this.userControl11.Margin = new System.Windows.Forms.Padding(2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(69, 69);
            this.userControl11.TabIndex = 1;
            // 
            // ioBtn1
            // 
            this.ioBtn1.Address = "nihao ";
            this.ioBtn1.btnName = 0;
            this.ioBtn1.Location = new System.Drawing.Point(73, 142);
            this.ioBtn1.Name = "ioBtn1";
            this.ioBtn1.Size = new System.Drawing.Size(257, 69);
            this.ioBtn1.TabIndex = 2;
            this.ioBtn1.Tag = "0";
            this.ioBtn1.btnOn += new System.EventHandler(this.ioBtn1_btnOn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 535);
            this.Controls.Add(this.ioBtn1);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GoogolButton2.UserControl1 userControl11;
        private GoogolButton2.UserControl1 userControl12;
        private MyEvent.IOBtn ioBtn1;
    }
}

