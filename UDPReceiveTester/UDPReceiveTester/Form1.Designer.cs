
namespace UDPReceiveTester
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPortOpen = new System.Windows.Forms.Button();
            this.btnPortClose = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port : ";
            // 
            // btnPortOpen
            // 
            this.btnPortOpen.Location = new System.Drawing.Point(171, 12);
            this.btnPortOpen.Name = "btnPortOpen";
            this.btnPortOpen.Size = new System.Drawing.Size(75, 23);
            this.btnPortOpen.TabIndex = 1;
            this.btnPortOpen.Text = "Open";
            this.btnPortOpen.UseVisualStyleBackColor = true;
            this.btnPortOpen.Click += new System.EventHandler(this.btnPortOpen_Click);
            // 
            // btnPortClose
            // 
            this.btnPortClose.Enabled = false;
            this.btnPortClose.Location = new System.Drawing.Point(252, 13);
            this.btnPortClose.Name = "btnPortClose";
            this.btnPortClose.Size = new System.Drawing.Size(75, 23);
            this.btnPortClose.TabIndex = 2;
            this.btnPortClose.Text = "Close";
            this.btnPortClose.UseVisualStyleBackColor = true;
            this.btnPortClose.Click += new System.EventHandler(this.btnPortClose_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(65, 13);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 21);
            this.tbPort.TabIndex = 3;
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(22, 49);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(305, 181);
            this.rtbResult.TabIndex = 4;
            this.rtbResult.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "salut-monde.tistory.com";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.btnPortClose);
            this.Controls.Add(this.btnPortOpen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "UDP Rx Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPortOpen;
        private System.Windows.Forms.Button btnPortClose;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label label2;
    }
}

