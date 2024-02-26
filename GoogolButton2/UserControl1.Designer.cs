namespace GoogolButton2
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.btn_switch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_switch
            // 
            this.btn_switch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_switch.BackgroundImage")));
            this.btn_switch.Location = new System.Drawing.Point(2, 2);
            this.btn_switch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(60, 60);
            this.btn_switch.TabIndex = 0;
            this.btn_switch.Tag = "OFF";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_switch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(62, 61);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_switch;
    }
}
