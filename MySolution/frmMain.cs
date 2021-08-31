using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *  MyModules 포함 작업
 *      1. MySolution의 참조에 MyModules 추가
 */

namespace MySolution
{
    public partial class frmMain : Form
    {
        MyModules.WebServer.WebServer ws = null;

        public frmMain()
        {
            InitializeComponent();

            //For WebServer
            ws = new MyModules.WebServer.WebServer();

            ws.AddBindingAddress("http://localhost:9999/"); // 포트 번호까지 반드시 설정합니다.

            ws.RootPath = Directory.GetCurrentDirectory() + "/WebServer/HTML Source/";
            ws.IndexHtmlFile = "index.html";
            ///////
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

        //Caus
        private void btnReadIni_Click(object sender, EventArgs e)
        {
            MyModules.IniFileTool.IniFileTool readIniFile = new MyModules.IniFileTool.IniFileTool(Directory.GetCurrentDirectory() + "/IniFileTool/Info.ini");
            MessageBox.Show(readIniFile.IniReadValue("SECTION_NAME", "TERMINAL_NAME"));
        }

        private void btnWriteIni_Click(object sender, EventArgs e)
        {
            MyModules.IniFileTool.IniFileTool readIniFile = new MyModules.IniFileTool.IniFileTool(Directory.GetCurrentDirectory() + "/IniFileTool/Info.ini");
            readIniFile.IniWriteValue("DATE", "ToDay", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void btnSymPath_Click(object sender, EventArgs e)
        {
            string filename = "C:\\Temp\\1.txt";

            MessageBox.Show("Without @: " + filename);
            // @심벌을 사용하여 보다 자연스럽게 패스 지정
            filename = @"C:\Temp\1.txt";
            MessageBox.Show("With @: " + filename);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            string str = @"
                    public string ReadFile(string filename)
                    {
                        if (!string.IsNullOrEmpty(filename))
                        {
                            return File.ReadAllText(filename);
                        }
                        return string.Empty;
                    }
                    ";
            MessageBox.Show(str);
        }

        private void btnCheckingNetworkConnectable_Click(object sender, EventArgs e)
        {
            if (MyModules.Network.Network.IsConnectedToInternet())
            {
                MessageBox.Show("Network is Connectable.");
                return;
            }
        }

        private void btnGetIP_V4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MyModules.IPconfiguration.IPconfiguration.GetIPAddressV4());
        }

        private void btnGetIP_V6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MyModules.IPconfiguration.IPconfiguration.GetIPAddressV6());
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            if (ws.IsRunning)
            {
                ws.Stop();
                btnServerStart.Text = "Stopped";
            }
            else
            {
                ws.Start();
                btnServerStart.Text = "Started";
            }
        }

        private void server_ActionRequested(object sender, MyModules.WebServer.ActionRequestedEventArgs e)
        {
            e.Server.WriteDefaultAction(e.Context);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ///For Web Server
            if (ws.IsRunning)
            {
                ws.Stop();
                ws = null;
            }
            /////
        }
    }
}