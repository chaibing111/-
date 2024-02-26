using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogolButton2
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            if (this.btn_switch.Tag.ToString()=="OFF")
            {
                this.btn_switch.Tag = "ON";
                this.btn_switch.Image = Resources.btnON;
                //不同按钮执行不同的业务。。。
                SwitchClick("ON", this.Tag?.ToString());
            }
            else
            {
                this.btn_switch.Tag = "OFF";
                this.btn_switch.Image = Resources.btnOFF;
                SwitchClick("OFF", this.Tag?.ToString());
            }
        }
        public Action<string, string> SwitchClick = null;
    }
}
