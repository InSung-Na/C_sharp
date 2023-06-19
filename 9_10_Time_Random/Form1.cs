// Time_Random
/*
 - DateTime 클래스
    - 시간 출력
 - Timer 도구
    - 사용가능(Enable)설정 후 Interval 설정
    - 이벤트에 매 1 Tick 당 이벤트 실행 가능
 - Random.Next(MIN, MAX)
    - 최소 최대 범위로 난수 생성
 - Form
    - 다른 Form도 클래스로 선언 후 제어가능
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

namespace _9_10_Time_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();     // 년-월-일 오전/오후 시:분:초
            lblDT2.Text = DateTime.Now.ToLongDateString();  // 년 월 일 요일
            lblDT3.Text = DateTime.Now.ToShortDateString(); // 년-월-일
            lblDT4.Text = DateTime.Now.ToLongTimeString();  // 오전/오후 시:분"초
            lblDT5.Text = DateTime.Now.ToShortTimeString(); // 오전/오후 시:분
            lblDT6.Text = "현재시간은 " + DateTime.Now.Hour + "시" + DateTime.Now.Minute + "분 입니다.";

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ledRun.BackColor = Color.Lime;
            ledRun.Text = "ON";
            // 기동버튼이 눌렸을 때 Timer2 실행
            timer2.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ledRun.BackColor = Color.White;
            ledRun.Text = "OFF";
            // 정지버튼이 눌렸을 때 Timer2 실행
            timer2.Stop();
        }

        // Timer당 랜덤값 출력
        Random rdNum = new Random();    // 랜덤값 생성
        private void timer2_Tick(object sender, EventArgs e)
        {
            int num = rdNum.Next(0, 100);
            tbCh1.Text = num.ToString();
            if (num >= 50)
            {
                ledCh1.BackColor = Color.Orange;
                ledCh1.Text = "ON";
            }
            else
            {
                ledCh1.BackColor= Color.White;
                ledCh1.Text = "OFF";
            }
        }
        // 새로운 창 열고 닫기
        private void btnOpen_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            // f2.Show(); // 팝업: 별도의 창 생성
            f2.ShowDialog();    // 모달: 종속된 창 생성
        }
    }
}
