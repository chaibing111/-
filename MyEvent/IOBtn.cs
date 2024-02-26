using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEvent
{
    public partial class IOBtn : UserControl
    {
        public IOBtn()
        {
            InitializeComponent();
        }
        private string address;
        [Category("我的自定义属性")]
        [Description("设备地址")]
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                this.lbIP.Text = value;
            }
        }
        private int name;
        [Category("我的自定义属性")]
        [Description("设备名称")]
        public int btnName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        [Category("我的自定义属性")]
      

        public event EventHandler btnOn;
        private void button2_Click(object sender, EventArgs e)
        {
            if (btnSwith.Tag.ToString() == "ON")
            {
                btnSwith.Tag = "OFF";
                btnSwith.Image = Resource1.btnOFF3;
                //封装业务。
                btnName = 0;
            }
            else
            {
                btnSwith.Tag = "ON";
                btnSwith.Image = Resource1.btnON3;
                btnName = 1;
            }
            btnOn?.Invoke(this, e);
        }
    }
}
