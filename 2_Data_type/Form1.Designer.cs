namespace _2_Data_type
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
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(91, 101);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(193, 46);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "정수형출력";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(91, 175);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(193, 46);
            this.btnDouble.TabIndex = 0;
            this.btnDouble.Text = "실수형출력";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(91, 247);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(193, 46);
            this.btnString.TabIndex = 0;
            this.btnString.Text = "문자열출력";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("에스코어 드림 3 Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(441, 192);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 29);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "결과";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Label lblResult;
    }
}

