namespace Bluetooth_connect
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
            this.rcLabel = new System.Windows.Forms.Label();
            this.rcComboBox = new System.Windows.Forms.ComboBox();
            this.cnButton = new System.Windows.Forms.Button();
            this.dcButton = new System.Windows.Forms.Button();
            this.rsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rcLabel
            // 
            this.rcLabel.AutoSize = true;
            this.rcLabel.Font = new System.Drawing.Font("굴림", 12F);
            this.rcLabel.Location = new System.Drawing.Point(22, 25);
            this.rcLabel.Name = "rcLabel";
            this.rcLabel.Size = new System.Drawing.Size(77, 16);
            this.rcLabel.TabIndex = 1;
            this.rcLabel.Text = "수신 포트";
            // 
            // rcComboBox
            // 
            this.rcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rcComboBox.Font = new System.Drawing.Font("굴림", 12F);
            this.rcComboBox.FormattingEnabled = true;
            this.rcComboBox.Location = new System.Drawing.Point(109, 22);
            this.rcComboBox.Name = "rcComboBox";
            this.rcComboBox.Size = new System.Drawing.Size(121, 24);
            this.rcComboBox.TabIndex = 3;
            // 
            // cnButton
            // 
            this.cnButton.Font = new System.Drawing.Font("굴림", 12F);
            this.cnButton.Location = new System.Drawing.Point(257, 17);
            this.cnButton.Name = "cnButton";
            this.cnButton.Size = new System.Drawing.Size(91, 32);
            this.cnButton.TabIndex = 4;
            this.cnButton.Text = "연결";
            this.cnButton.UseVisualStyleBackColor = true;
            this.cnButton.Click += new System.EventHandler(this.cnButton_Click);
            // 
            // dcButton
            // 
            this.dcButton.Font = new System.Drawing.Font("굴림", 12F);
            this.dcButton.Location = new System.Drawing.Point(361, 17);
            this.dcButton.Name = "dcButton";
            this.dcButton.Size = new System.Drawing.Size(91, 32);
            this.dcButton.TabIndex = 5;
            this.dcButton.Text = "미연결";
            this.dcButton.UseVisualStyleBackColor = true;
            this.dcButton.Click += new System.EventHandler(this.dcButton_Click);
            // 
            // rsListBox
            // 
            this.rsListBox.Font = new System.Drawing.Font("굴림", 11F);
            this.rsListBox.FormattingEnabled = true;
            this.rsListBox.ItemHeight = 15;
            this.rsListBox.Location = new System.Drawing.Point(26, 73);
            this.rsListBox.Name = "rsListBox";
            this.rsListBox.Size = new System.Drawing.Size(426, 199);
            this.rsListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 299);
            this.Controls.Add(this.rsListBox);
            this.Controls.Add(this.dcButton);
            this.Controls.Add(this.cnButton);
            this.Controls.Add(this.rcComboBox);
            this.Controls.Add(this.rcLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label rcLabel;
        private System.Windows.Forms.ComboBox rcComboBox;
        private System.Windows.Forms.Button cnButton;
        private System.Windows.Forms.Button dcButton;
        private System.Windows.Forms.ListBox rsListBox;
    }
}

