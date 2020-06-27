namespace MqttSubscriber
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtConnectionString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtClientId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTopic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPayload = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.RtbRecieved = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtControlTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // TxtConnectionString
            // 
            this.TxtConnectionString.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtConnectionString.Location = new System.Drawing.Point(179, 16);
            this.TxtConnectionString.Name = "TxtConnectionString";
            this.TxtConnectionString.Size = new System.Drawing.Size(391, 25);
            this.TxtConnectionString.TabIndex = 1;
            this.TxtConnectionString.Text = "192.168.0.5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client ID";
            // 
            // TxtClientId
            // 
            this.TxtClientId.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtClientId.Location = new System.Drawing.Point(179, 47);
            this.TxtClientId.Name = "TxtClientId";
            this.TxtClientId.Size = new System.Drawing.Size(391, 25);
            this.TxtClientId.TabIndex = 1;
            this.TxtClientId.Text = "HugoSubscriber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subscribe Topic";
            // 
            // TxtTopic
            // 
            this.TxtTopic.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtTopic.Location = new System.Drawing.Point(179, 78);
            this.TxtTopic.Name = "TxtTopic";
            this.TxtTopic.Size = new System.Drawing.Size(391, 25);
            this.TxtTopic.TabIndex = 1;
            this.TxtTopic.Text = "home/device/data/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(22, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Publish Topic";
            // 
            // TxtPayload
            // 
            this.TxtPayload.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtPayload.Location = new System.Drawing.Point(179, 109);
            this.TxtPayload.Name = "TxtPayload";
            this.TxtPayload.Size = new System.Drawing.Size(391, 25);
            this.TxtPayload.TabIndex = 1;
            this.TxtPayload.Text = "home/device/control/";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnConnect.Location = new System.Drawing.Point(700, 128);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(113, 37);
            this.BtnConnect.TabIndex = 2;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDisconnect.Location = new System.Drawing.Point(819, 128);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(113, 37);
            this.BtnDisconnect.TabIndex = 2;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // RtbRecieved
            // 
            this.RtbRecieved.Enabled = false;
            this.RtbRecieved.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RtbRecieved.Location = new System.Drawing.Point(12, 171);
            this.RtbRecieved.Name = "RtbRecieved";
            this.RtbRecieved.Size = new System.Drawing.Size(920, 415);
            this.RtbRecieved.TabIndex = 3;
            this.RtbRecieved.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(22, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Control Temperature";
            // 
            // TxtControlTemp
            // 
            this.TxtControlTemp.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtControlTemp.Location = new System.Drawing.Point(179, 140);
            this.TxtControlTemp.Name = "TxtControlTemp";
            this.TxtControlTemp.Size = new System.Drawing.Size(391, 25);
            this.TxtControlTemp.TabIndex = 1;
            this.TxtControlTemp.Text = "25.0, 23.0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 598);
            this.Controls.Add(this.RtbRecieved);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TxtControlTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPayload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTopic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtClientId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtConnectionString);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "MQTT Client";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtConnectionString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtClientId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTopic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPayload;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.RichTextBox RtbRecieved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtControlTemp;
    }
}

