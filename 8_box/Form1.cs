// Box
/*
 - MessageBox
    - MessageBox.Show("CONTENT", "TITLE", "MessageBoxButtons.BUTTON", "MessageBoxIcon.ICON")
 - CheckBox, radioButton
    - CheckBox/radioButton.Checked == true or false
 - ComboBox, ListBox
    - 속성창 -> 데이터 -> Items에서 내용추가
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 메세지박스 튜토리얼
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼을 클릭했습니다.", "메세지박스제목", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        // 주문 시스템
        private void btnOrder_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            lblOrder.Text = "";

            // 메뉴가 체크되어 있지 않으면 경고창 실행
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            {
                MessageBox.Show("메뉴를 선택하고 주문하세요!", "주문 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // 메뉴가 한 개 이상 체크되어 있으면 실행
            else
            {
                // 메뉴가 체크되어 있으면 strOrder에 추가
                if (checkBox1.Checked == true)
                {
                    strOrder += checkBox1.Text + "\n";
                }
                if (checkBox2.Checked == true)
                {
                    strOrder += checkBox2.Text + "\n";
                }
                if (checkBox3.Checked == true)
                {
                    strOrder += checkBox3.Text + "\n";
                }
                if (checkBox4.Checked == true)
                {
                    strOrder += checkBox4.Text + "\n";
                }

                lblOrder.Text = strOrder + "메뉴를 주문하셨습니다.";
            }
        }

        // 고객 요구사항
        // 텍스트박스는 기본적으로 한 줄 입력으로 설정되어있음
        // Multiline를 True로 설정할 것
        private void btnRequest_Click(object sender, EventArgs e)
        {
            string strText = tbRequest.Text + "\n라고 추가요구사항이 접수되었습니다.";
            MessageBox.Show(strText, "추가요구사항", MessageBoxButtons.OK);
        }

        // 이벤트 응모을 위한 개인정보 동의 메커니즘
        private void button2_Click(object sender, EventArgs e)
        {
            if (rbAgree.Checked)
            {
                MessageBox.Show("이벤트에 응모하셨습니다.", "이벤트 응모결과");
            }
            else
            {
                MessageBox.Show("개인정보 제공에 동의하지 않으셨습니다.", "이벤트 응모결과");
            }
        }

        // 결제시스템
        private void btnPay_Click(object sender, EventArgs e)
        {
            string strText = cbPay.Text + ": " + lbPayInfo.Text + "\n결제방법을 선택하셨습니다.";
            MessageBox.Show(strText, "결제정보");
        }

        // 결제방법의 인덱스에 따른 실행
        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 초기화
            lbPayInfo.Items.Clear();
            // 카드
            if (cbPay.SelectedIndex==0)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("3개월할부");
                lbPayInfo.Items.Add("6개월할부");
            }
            // 무통장입금
            else if (cbPay.SelectedIndex == 1)
            {
                lbPayInfo.Items.Add("신한은행");
                lbPayInfo.Items.Add("국민은행");
                lbPayInfo.Items.Add("기업은행");
            }
            // 포인트
            else if (cbPay.SelectedIndex == 2)
            {
                lbPayInfo.Items.Add("롯데포인트");
                lbPayInfo.Items.Add("OK캐시백");
                lbPayInfo.Items.Add("주유포인트");
            }
            // 현금
            else if (cbPay.SelectedIndex == 3)
            {
                lbPayInfo.Items.Add("카운터");
            }
            // 잘못된 입력
            else
            {
                lbPayInfo.Items.Add("잘못된 입력입니다.");
            }
        }
    }
}
