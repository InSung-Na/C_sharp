namespace _7_String
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
            this.btnInput1 = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.Title2 = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInput1
            // 
            this.btnInput1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInput1.Location = new System.Drawing.Point(325, 130);
            this.btnInput1.Name = "btnInput1";
            this.btnInput1.Size = new System.Drawing.Size(81, 39);
            this.btnInput1.TabIndex = 0;
            this.btnInput1.Text = "입력";
            this.btnInput1.UseVisualStyleBackColor = true;
            this.btnInput1.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(202, 130);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(101, 21);
            this.tbID.TabIndex = 1;
            this.tbID.Text = "주민번호입력";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.Location = new System.Drawing.Point(207, 163);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 19);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "결과";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 21);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "문자열 다루기";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGender.Location = new System.Drawing.Point(207, 195);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 19);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "성별";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblShort.Location = new System.Drawing.Point(198, 269);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(104, 19);
            this.lblShort.TabIndex = 2;
            this.lblShort.Text = "번호간략화";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(202, 236);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(101, 21);
            this.tbPhone.TabIndex = 1;
            this.tbPhone.Text = "핸드폰번호";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(203, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(101, 21);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "영문이름";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(209, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "이름결과";
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title2.Location = new System.Drawing.Point(437, 9);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(132, 21);
            this.Title2.TabIndex = 3;
            this.Title2.Text = "String Builder";
            // 
            // btnDefault
            // 
            this.btnDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefault.Location = new System.Drawing.Point(441, 70);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(64, 39);
            this.btnDefault.TabIndex = 6;
            this.btnDefault.Text = "기본출력";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(511, 70);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(64, 39);
            this.btnAppend.TabIndex = 6;
            this.btnAppend.Text = "추가";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(581, 70);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(64, 39);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(651, 70);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(64, 39);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "삽입";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(452, 165);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(29, 12);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "결과";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnInput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblResult;
    }
}

