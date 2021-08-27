using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MySolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetID_Click(object sender, EventArgs e)
        {
            MyModules.SingleTon.UserInfoSingleton.Instance.Userid = "ID";            
            //MyModules.SingleTon.UserInfoSingleton.GetInstance().Userid = "PCK";

        }

        private void btnSetName_Click(object sender, EventArgs e)
        {
            MyModules.SingleTon.UserInfoSingleton.Instance.UserName = "Name";
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID: " + MyModules.SingleTon.UserInfoSingleton.Instance.Userid + ", Name: " + MyModules.SingleTon.UserInfoSingleton.Instance.UserName);
        }
    }
}
