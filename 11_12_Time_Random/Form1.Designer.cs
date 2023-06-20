namespace _9_10_Time_Random
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblDT2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDT3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDT4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDT5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDT6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.ledRun = new System.Windows.Forms.Button();
            this.Operating = new System.Windows.Forms.GroupBox();
            this.tbCh1 = new System.Windows.Forms.TextBox();
            this.ledCh1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnOpen = new System.Windows.Forms.Button();
            this.Operating.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ToString";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDateTime.Location = new System.Drawing.Point(247, 56);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 21);
            this.lblDateTime.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "ToLongDateString";
            // 
            // lblDT2
            // 
            this.lblDT2.AutoSize = true;
            this.lblDT2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDT2.Location = new System.Drawing.Point(247, 101);
            this.lblDT2.Name = "lblDT2";
            this.lblDT2.Size = new System.Drawing.Size(0, 21);
            this.lblDT2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(29, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "ToShortDateString";
            // 
            // lblDT3
            // 
            this.lblDT3.AutoSize = true;
            this.lblDT3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDT3.Location = new System.Drawing.Point(247, 151);
            this.lblDT3.Name = "lblDT3";
            this.lblDT3.Size = new System.Drawing.Size(0, 21);
            this.lblDT3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(29, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "ToLongTimeString";
            // 
            // lblDT4
            // 
            this.lblDT4.AutoSize = true;
            this.lblDT4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDT4.Location = new System.Drawing.Point(247, 205);
            this.lblDT4.Name = "lblDT4";
            this.lblDT4.Size = new System.Drawing.Size(0, 21);
            this.lblDT4.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(29, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "ToShortTimeString";
            // 
            // lblDT5
            // 
            this.lblDT5.AutoSize = true;
            this.lblDT5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDT5.Location = new System.Drawing.Point(247, 258);
            this.lblDT5.Name = "lblDT5";
            this.lblDT5.Size = new System.Drawing.Size(0, 21);
            this.lblDT5.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(29, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "현재시간";
            // 
            // lblDT6
            // 
            this.lblDT6.AutoSize = true;
            this.lblDT6.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDT6.Location = new System.Drawing.Point(247, 302);
            this.lblDT6.Name = "lblDT6";
            this.lblDT6.Size = new System.Drawing.Size(0, 21);
            this.lblDT6.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(27, 33);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 76);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "기동";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(27, 116);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 76);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "정지";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ledRun
            // 
            this.ledRun.BackColor = System.Drawing.Color.White;
            this.ledRun.Location = new System.Drawing.Point(158, 33);
            this.ledRun.Name = "ledRun";
            this.ledRun.Size = new System.Drawing.Size(108, 76);
            this.ledRun.TabIndex = 1;
            this.ledRun.Text = "OFF";
            this.ledRun.UseVisualStyleBackColor = false;
            // 
            // Operating
            // 
            this.Operating.Controls.Add(this.ledRun);
            this.Operating.Controls.Add(this.btnStop);
            this.Operating.Controls.Add(this.btnStart);
            this.Operating.Location = new System.Drawing.Point(612, 66);
            this.Operating.Name = "Operating";
            this.Operating.Size = new System.Drawing.Size(285, 213);
            this.Operating.TabIndex = 2;
            this.Operating.TabStop = false;
            this.Operating.Text = "Operating";
            // 
            // tbCh1
            // 
            this.tbCh1.Location = new System.Drawing.Point(683, 295);
            this.tbCh1.Name = "tbCh1";
            this.tbCh1.Size = new System.Drawing.Size(100, 21);
            this.tbCh1.TabIndex = 3;
            this.tbCh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ledCh1
            // 
            this.ledCh1.BackColor = System.Drawing.Color.White;
            this.ledCh1.Location = new System.Drawing.Point(834, 286);
            this.ledCh1.Name = "ledCh1";
            this.ledCh1.Size = new System.Drawing.Size(63, 37);
            this.ledCh1.TabIndex = 1;
            this.ledCh1.Text = "OFF";
            this.ledCh1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ch1";
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(683, 372);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(140, 52);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "화면열기";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ledCh1);
            this.Controls.Add(this.tbCh1);
            this.Controls.Add(this.lblDT6);
            this.Controls.Add(this.lblDT5);
            this.Controls.Add(this.lblDT4);
            this.Controls.Add(this.lblDT3);
            this.Controls.Add(this.lblDT2);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Operating);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Operating.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDT2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDT3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDT4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDT5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDT6;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button ledRun;
        private System.Windows.Forms.GroupBox Operating;
        private System.Windows.Forms.TextBox tbCh1;
        private System.Windows.Forms.Button ledCh1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnOpen;
    }
}

