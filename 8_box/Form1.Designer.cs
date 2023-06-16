namespace _8_box
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.rbAgree = new System.Windows.Forms.RadioButton();
            this.rbDisagree = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPayInfo = new System.Windows.Forms.ListBox();
            this.cbPay = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(52, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "짜장면";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(164, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "짬뽕";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(270, 81);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 16);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "탕수육";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(382, 81);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(60, 16);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "볶음밥";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "메뉴를 선택하고 주문버튼을 누르세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(40, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "이벤트에 응모하려면 개인정보 동의해 주세요.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(681, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(529, 44);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(53, 12);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "주문결과";
            // 
            // rbAgree
            // 
            this.rbAgree.AutoSize = true;
            this.rbAgree.Location = new System.Drawing.Point(40, 43);
            this.rbAgree.Name = "rbAgree";
            this.rbAgree.Size = new System.Drawing.Size(47, 16);
            this.rbAgree.TabIndex = 4;
            this.rbAgree.TabStop = true;
            this.rbAgree.Text = "동의";
            this.rbAgree.UseVisualStyleBackColor = true;
            // 
            // rbDisagree
            // 
            this.rbDisagree.AutoSize = true;
            this.rbDisagree.Location = new System.Drawing.Point(127, 43);
            this.rbDisagree.Name = "rbDisagree";
            this.rbDisagree.Size = new System.Drawing.Size(71, 16);
            this.rbDisagree.TabIndex = 4;
            this.rbDisagree.TabStop = true;
            this.rbDisagree.Text = "동의안함";
            this.rbDisagree.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(302, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 61);
            this.button2.TabIndex = 5;
            this.button2.Text = "응모";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAgree);
            this.groupBox1.Controls.Add(this.rbDisagree);
            this.groupBox1.Location = new System.Drawing.Point(40, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보동의";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(50, 118);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(418, 32);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "주문";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(40, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "주문시 요구사항";
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.White;
            this.btnRequest.Location = new System.Drawing.Point(405, 220);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(74, 61);
            this.btnRequest.TabIndex = 5;
            this.btnRequest.Text = "접수";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // tbRequest
            // 
            this.tbRequest.Location = new System.Drawing.Point(44, 220);
            this.tbRequest.Multiline = true;
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(332, 112);
            this.tbRequest.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(527, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "결제방법";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(788, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "결제정보";
            // 
            // lbPayInfo
            // 
            this.lbPayInfo.FormattingEnabled = true;
            this.lbPayInfo.ItemHeight = 12;
            this.lbPayInfo.Items.AddRange(new object[] {
            "일시불",
            "3개월할부",
            "6개월할부"});
            this.lbPayInfo.Location = new System.Drawing.Point(792, 220);
            this.lbPayInfo.Name = "lbPayInfo";
            this.lbPayInfo.Size = new System.Drawing.Size(120, 88);
            this.lbPayInfo.TabIndex = 9;
            // 
            // cbPay
            // 
            this.cbPay.FormattingEnabled = true;
            this.cbPay.Items.AddRange(new object[] {
            "신용카드",
            "무통장입금",
            "포인트",
            "현금"});
            this.cbPay.Location = new System.Drawing.Point(531, 220);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(121, 20);
            this.cbPay.TabIndex = 10;
            this.cbPay.Text = "신용카드";
            this.cbPay.SelectedIndexChanged += new System.EventHandler(this.cbPay_SelectedIndexChanged);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(531, 353);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(381, 55);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "결제";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 596);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.lbPayInfo);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "주문시스템";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.RadioButton rbAgree;
        private System.Windows.Forms.RadioButton rbDisagree;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbPayInfo;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.Button btnPay;
    }
}

