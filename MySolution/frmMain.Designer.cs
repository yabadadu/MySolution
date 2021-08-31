
namespace MySolution
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnServerStart = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGetIP_V6 = new System.Windows.Forms.Button();
            this.btnGetIP_V4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCheckingNetworkConnectable = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSymPath = new System.Windows.Forms.Button();
            this.btnWriteIni = new System.Windows.Forms.Button();
            this.btnReadIni = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnSetName = new System.Windows.Forms.Button();
            this.btnSetID = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(18, 20);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(95, 19);
            this.btnServerStart.TabIndex = 1;
            this.btnServerStart.Text = "Stopped";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnServerStart);
            this.groupBox6.Location = new System.Drawing.Point(355, 169);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(142, 48);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Web Servewr";
            // 
            // btnGetIP_V6
            // 
            this.btnGetIP_V6.Location = new System.Drawing.Point(113, 20);
            this.btnGetIP_V6.Name = "btnGetIP_V6";
            this.btnGetIP_V6.Size = new System.Drawing.Size(95, 19);
            this.btnGetIP_V6.TabIndex = 2;
            this.btnGetIP_V6.Text = "btnGetIP_V6";
            this.btnGetIP_V6.UseVisualStyleBackColor = true;
            this.btnGetIP_V6.Click += new System.EventHandler(this.btnGetIP_V6_Click);
            // 
            // btnGetIP_V4
            // 
            this.btnGetIP_V4.Location = new System.Drawing.Point(18, 20);
            this.btnGetIP_V4.Name = "btnGetIP_V4";
            this.btnGetIP_V4.Size = new System.Drawing.Size(95, 19);
            this.btnGetIP_V4.TabIndex = 1;
            this.btnGetIP_V4.Text = "Get IP4";
            this.btnGetIP_V4.UseVisualStyleBackColor = true;
            this.btnGetIP_V4.Click += new System.EventHandler(this.btnGetIP_V4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGetIP_V6);
            this.groupBox5.Controls.Add(this.btnGetIP_V4);
            this.groupBox5.Location = new System.Drawing.Point(23, 169);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(217, 48);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "IP Configuration";
            // 
            // btnCheckingNetworkConnectable
            // 
            this.btnCheckingNetworkConnectable.Location = new System.Drawing.Point(18, 20);
            this.btnCheckingNetworkConnectable.Name = "btnCheckingNetworkConnectable";
            this.btnCheckingNetworkConnectable.Size = new System.Drawing.Size(209, 19);
            this.btnCheckingNetworkConnectable.TabIndex = 1;
            this.btnCheckingNetworkConnectable.Text = "Checking if connectable to Internet";
            this.btnCheckingNetworkConnectable.UseVisualStyleBackColor = true;
            this.btnCheckingNetworkConnectable.Click += new System.EventHandler(this.btnCheckingNetworkConnectable_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCheckingNetworkConnectable);
            this.groupBox4.Location = new System.Drawing.Point(355, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 48);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Network";
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(113, 20);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(95, 19);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "For Multi-Line";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnSymPath
            // 
            this.btnSymPath.Location = new System.Drawing.Point(18, 20);
            this.btnSymPath.Name = "btnSymPath";
            this.btnSymPath.Size = new System.Drawing.Size(95, 19);
            this.btnSymPath.TabIndex = 1;
            this.btnSymPath.Text = "For Path";
            this.btnSymPath.UseVisualStyleBackColor = true;
            this.btnSymPath.Click += new System.EventHandler(this.btnSymPath_Click);
            // 
            // btnWriteIni
            // 
            this.btnWriteIni.Location = new System.Drawing.Point(113, 20);
            this.btnWriteIni.Name = "btnWriteIni";
            this.btnWriteIni.Size = new System.Drawing.Size(95, 19);
            this.btnWriteIni.TabIndex = 2;
            this.btnWriteIni.Text = "Write to INI";
            this.btnWriteIni.UseVisualStyleBackColor = true;
            this.btnWriteIni.Click += new System.EventHandler(this.btnWriteIni_Click);
            // 
            // btnReadIni
            // 
            this.btnReadIni.Location = new System.Drawing.Point(18, 20);
            this.btnReadIni.Name = "btnReadIni";
            this.btnReadIni.Size = new System.Drawing.Size(95, 19);
            this.btnReadIni.TabIndex = 1;
            this.btnReadIni.Text = "Read from INI";
            this.btnReadIni.UseVisualStyleBackColor = true;
            this.btnReadIni.Click += new System.EventHandler(this.btnReadIni_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWriteIni);
            this.groupBox2.Controls.Add(this.btnReadIni);
            this.groupBox2.Location = new System.Drawing.Point(23, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 48);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INI File Control";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(208, 20);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(95, 19);
            this.btnShowInfo.TabIndex = 3;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnSetName
            // 
            this.btnSetName.Location = new System.Drawing.Point(113, 20);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.Size = new System.Drawing.Size(95, 19);
            this.btnSetName.TabIndex = 2;
            this.btnSetName.Text = "Set Name";
            this.btnSetName.UseVisualStyleBackColor = true;
            this.btnSetName.Click += new System.EventHandler(this.btnSetName_Click);
            // 
            // btnSetID
            // 
            this.btnSetID.Location = new System.Drawing.Point(18, 20);
            this.btnSetID.Name = "btnSetID";
            this.btnSetID.Size = new System.Drawing.Size(95, 19);
            this.btnSetID.TabIndex = 1;
            this.btnSetID.Text = "Set ID";
            this.btnSetID.UseVisualStyleBackColor = true;
            this.btnSetID.Click += new System.EventHandler(this.btnSetID_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMulti);
            this.groupBox3.Controls.Add(this.btnSymPath);
            this.groupBox3.Location = new System.Drawing.Point(355, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 48);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "How to use @";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowInfo);
            this.groupBox1.Controls.Add(this.btnSetName);
            this.groupBox1.Controls.Add(this.btnSetID);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SingleTon";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnGetIP_V6;
        private System.Windows.Forms.Button btnGetIP_V4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCheckingNetworkConnectable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnSymPath;
        private System.Windows.Forms.Button btnWriteIni;
        private System.Windows.Forms.Button btnReadIni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnSetName;
        private System.Windows.Forms.Button btnSetID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

