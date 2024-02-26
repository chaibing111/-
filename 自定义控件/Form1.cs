using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自定义控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.userControl11.SwitchClick += Test;
            this.userControl12.SwitchClick += Test;
        }
            //this.userControl11.SwitchClick += Test;
            //this.userControl12.SwitchClick += Test;
        public void Test(string data1,string data2)
        {
            switch (data2)
            {
                case "btn0":
                    
                    break;
            }
            //Console.WriteLine(data1);
            //Console.WriteLine(data2);
        }

        private void ioBtn1_btnOn(object sender, EventArgs e)
        {
            ;
            if (ioBtn1.btnName == 0)
            {
                ioBtn1.Address = "OFF";

                MessageBox.Show("ioBtn1.btnName == 0 ");
            }
            if (ioBtn1.btnName == 1)
            {
                ioBtn1.Address = "ON";
                MessageBox.Show("ioBtn1.btnName == 1 ");
            }
        }
    }
}
