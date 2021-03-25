namespace AngelInUs
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
            this.components = new System.ComponentModel.Container();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.SelectKeyBoardButton = new System.Windows.Forms.Button();
            this.SelectCatButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minLabel = new System.Windows.Forms.Label();
            this.timeSettingButton = new System.Windows.Forms.Button();
            this.minUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(324, 241);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(156, 63);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.LightPink;
            this.MainLabel.Font = new System.Drawing.Font("휴먼매직체", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainLabel.ForeColor = System.Drawing.Color.Green;
            this.MainLabel.Location = new System.Drawing.Point(143, 161);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(0, 56);
            this.MainLabel.TabIndex = 2;
            // 
            // SelectKeyBoardButton
            // 
            this.SelectKeyBoardButton.Location = new System.Drawing.Point(180, 24);
            this.SelectKeyBoardButton.Name = "SelectKeyBoardButton";
            this.SelectKeyBoardButton.Size = new System.Drawing.Size(144, 60);
            this.SelectKeyBoardButton.TabIndex = 3;
            this.SelectKeyBoardButton.Text = "키보드 청소";
            this.SelectKeyBoardButton.UseVisualStyleBackColor = true;
            this.SelectKeyBoardButton.Click += new System.EventHandler(this.SelectKeyBoardButton_Click);
            // 
            // SelectCatButton
            // 
            this.SelectCatButton.Location = new System.Drawing.Point(483, 24);
            this.SelectCatButton.Name = "SelectCatButton";
            this.SelectCatButton.Size = new System.Drawing.Size(144, 60);
            this.SelectCatButton.TabIndex = 4;
            this.SelectCatButton.Text = "고양이";
            this.SelectCatButton.UseVisualStyleBackColor = true;
            this.SelectCatButton.Click += new System.EventHandler(this.SelectCatButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 378);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(764, 37);
            this.progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(138, 232);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(26, 18);
            this.minLabel.TabIndex = 8;
            this.minLabel.Text = "분";
            // 
            // timeSettingButton
            // 
            this.timeSettingButton.Location = new System.Drawing.Point(170, 221);
            this.timeSettingButton.Name = "timeSettingButton";
            this.timeSettingButton.Size = new System.Drawing.Size(100, 37);
            this.timeSettingButton.TabIndex = 10;
            this.timeSettingButton.Text = "설정";
            this.timeSettingButton.UseVisualStyleBackColor = true;
            this.timeSettingButton.Click += new System.EventHandler(this.timeSettingButton_Click);
            // 
            // minUpDown
            // 
            this.minUpDown.Location = new System.Drawing.Point(12, 230);
            this.minUpDown.Name = "minUpDown";
            this.minUpDown.Size = new System.Drawing.Size(120, 28);
            this.minUpDown.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minUpDown);
            this.Controls.Add(this.timeSettingButton);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SelectCatButton);
            this.Controls.Add(this.SelectKeyBoardButton);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.CloseButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button SelectKeyBoardButton;
        private System.Windows.Forms.Button SelectCatButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Button timeSettingButton;
        private System.Windows.Forms.NumericUpDown minUpDown;
    }
}

