namespace _4_if_else
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
            this.tbKor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCut = new System.Windows.Forms.Label();
            this.tbCut = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            // 
            // tbKor
            // 
            this.tbKor.Location = new System.Drawing.Point(152, 77);
            this.tbKor.Name = "tbKor";
            this.tbKor.Size = new System.Drawing.Size(100, 21);
            this.tbKor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "수학";
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(337, 77);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(100, 21);
            this.tbMath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "영어";
            // 
            // tbEng
            // 
            this.tbEng.Location = new System.Drawing.Point(506, 77);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(100, 21);
            this.tbEng.TabIndex = 1;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(294, 162);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(143, 62);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "결과출력버튼";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(298, 267);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 12);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "총합출력창";
            // 
            // lblCut
            // 
            this.lblCut.AutoSize = true;
            this.lblCut.Location = new System.Drawing.Point(78, 338);
            this.lblCut.Name = "lblCut";
            this.lblCut.Size = new System.Drawing.Size(53, 12);
            this.lblCut.TabIndex = 4;
            this.lblCut.Text = "기준점수";
            // 
            // tbCut
            // 
            this.tbCut.Location = new System.Drawing.Point(80, 361);
            this.tbCut.Name = "tbCut";
            this.tbCut.Size = new System.Drawing.Size(100, 21);
            this.tbCut.TabIndex = 5;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(298, 318);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(65, 12);
            this.lblGrade.TabIndex = 6;
            this.lblGrade.Text = "학점출력창";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(298, 292);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(65, 12);
            this.lblAvg.TabIndex = 3;
            this.lblAvg.Text = "평균출력창";
            // 
            // btnRepeat
            // 
            this.btnRepeat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRepeat.Location = new System.Drawing.Point(489, 162);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(117, 62);
            this.btnRepeat.TabIndex = 7;
            this.btnRepeat.Text = "반복문실";
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Location = new System.Drawing.Point(489, 266);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(65, 12);
            this.lblRepeat.TabIndex = 8;
            this.lblRepeat.Text = "반복문출력";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRepeat);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.tbCut);
            this.Controls.Add(this.lblCut);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCut;
        private System.Windows.Forms.TextBox tbCut;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Label lblRepeat;
    }
}

