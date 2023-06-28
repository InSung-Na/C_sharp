namespace _13_14_Class
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFeed = new System.Windows.Forms.Button();
            this.prsBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrLife = new System.Windows.Forms.Timer(this.components);
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(39, 37);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(98, 59);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "놀아주기";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.BackColor = System.Drawing.Color.White;
            this.btnFeed.Location = new System.Drawing.Point(39, 102);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(98, 59);
            this.btnFeed.TabIndex = 0;
            this.btnFeed.Text = "먹이주기";
            this.btnFeed.UseVisualStyleBackColor = false;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // prsBar
            // 
            this.prsBar.Location = new System.Drawing.Point(183, 37);
            this.prsBar.Name = "prsBar";
            this.prsBar.Size = new System.Drawing.Size(492, 23);
            this.prsBar.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(183, 102);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 12);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "상태메세지";
            // 
            // tmrLife
            // 
            this.tmrLife.Tick += new System.EventHandler(this.tmrLife_Tick);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(183, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.Location = new System.Drawing.Point(300, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "게임시작";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.prsBar);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "강아지 키우기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.ProgressBar prsBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrLife;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnStart;
    }
}

