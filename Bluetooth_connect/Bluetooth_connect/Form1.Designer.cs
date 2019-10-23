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
            this.sdLabel = new System.Windows.Forms.Label();
            this.rcLabel = new System.Windows.Forms.Label();
            this.sdComboBox = new System.Windows.Forms.ComboBox();
            this.rcComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sdLabel
            // 
            this.sdLabel.AutoSize = true;
            this.sdLabel.Font = new System.Drawing.Font("굴림", 12F);
            this.sdLabel.Location = new System.Drawing.Point(22, 31);
            this.sdLabel.Name = "sdLabel";
            this.sdLabel.Size = new System.Drawing.Size(77, 16);
            this.sdLabel.TabIndex = 0;
            this.sdLabel.Text = "송신 포트";
            // 
            // rcLabel
            // 
            this.rcLabel.AutoSize = true;
            this.rcLabel.Font = new System.Drawing.Font("굴림", 12F);
            this.rcLabel.Location = new System.Drawing.Point(22, 73);
            this.rcLabel.Name = "rcLabel";
            this.rcLabel.Size = new System.Drawing.Size(77, 16);
            this.rcLabel.TabIndex = 1;
            this.rcLabel.Text = "수신 포트";
            // 
            // sdComboBox
            // 
            this.sdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sdComboBox.Font = new System.Drawing.Font("굴림", 12F);
            this.sdComboBox.FormattingEnabled = true;
            this.sdComboBox.Location = new System.Drawing.Point(109, 27);
            this.sdComboBox.Name = "sdComboBox";
            this.sdComboBox.Size = new System.Drawing.Size(121, 24);
            this.sdComboBox.TabIndex = 2;
            // 
            // rcComboBox
            // 
            this.rcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rcComboBox.Font = new System.Drawing.Font("굴림", 12F);
            this.rcComboBox.FormattingEnabled = true;
            this.rcComboBox.Location = new System.Drawing.Point(109, 70);
            this.rcComboBox.Name = "rcComboBox";
            this.rcComboBox.Size = new System.Drawing.Size(121, 24);
            this.rcComboBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F);
            this.button1.Location = new System.Drawing.Point(257, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "연결";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 12F);
            this.button2.Location = new System.Drawing.Point(257, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "미연결";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rsListBox
            // 
            this.rsListBox.FormattingEnabled = true;
            this.rsListBox.ItemHeight = 12;
            this.rsListBox.Location = new System.Drawing.Point(26, 121);
            this.rsListBox.Name = "rsListBox";
            this.rsListBox.Size = new System.Drawing.Size(322, 208);
            this.rsListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 367);
            this.Controls.Add(this.rsListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rcComboBox);
            this.Controls.Add(this.sdComboBox);
            this.Controls.Add(this.rcLabel);
            this.Controls.Add(this.sdLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sdLabel;
        private System.Windows.Forms.Label rcLabel;
        private System.Windows.Forms.ComboBox sdComboBox;
        private System.Windows.Forms.ComboBox rcComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox rsListBox;
    }
}

