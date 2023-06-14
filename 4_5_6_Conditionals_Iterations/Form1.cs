// 조건문과 반복문
// if-else 링크 :     https://www.youtube.com/watch?v=APWxuIrhqBE&list=PLznxAZVxcYDIZ_6LvePK1xrgeq_GkD6Mn&index=4
// switch-case 링크 : https://www.youtube.com/watch?v=TFTbGgPQXbI&list=PLznxAZVxcYDIZ_6LvePK1xrgeq_GkD6Mn&index=5
// 반복문 링크 :       https://www.youtube.com/watch?v=VWAi-Tnh4yQ&list=PLznxAZVxcYDIZ_6LvePK1xrgeq_GkD6Mn&index=6
/*
 - 조건문
    - if
    - else if : 파이썬의 elif와 동일
    - else
 - 예외처리
    - try
    - catch : 파이썬의 except와 동일
    - finally
 - 스위치
    - switch
    - case
 - 반복문
    - while: 내부에 종료조건 포함
    - do-while: 하단의 while 옆에 종료조건
    - for: for문 선언 시에 모든 조건 작성
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

namespace _4_if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int kor = 0;
            int math = 0;
            int eng = 0;
            try
            {
                kor = int.Parse(tbKor.Text);
            }
            catch { }
            try
            {
                math = int.Parse(tbMath.Text);
            }
            catch { }
            try
            {
                eng = int.Parse(tbEng.Text);
            }
            catch { }

            int total = kor + math + eng;
            int cut = int.Parse(tbCut.Text);

            if (total > cut)
            {
                lblTotal.Text = "총합: " + total + "점 입니다. " + "합격입니다!";
            }
            else if (total > cut/2)
            {
                lblTotal.Text = "총합: " + total + "점 입니다. " + "노력하세요!";
            }
            else
            {
                lblTotal.Text = "총합: " + total + "점 입니다. " + "불합격입니다!";
            }
            double avg = total / 3;
            lblAvg.Text = "평균: " + avg.ToString();

            switch (avg / 10)
            {
                case 10:
                case 9:
                    lblGrade.Text = "학점: A";
                    break;
                case 8:
                case 7:
                case 6:
                    lblGrade.Text = "학점: B";
                    break;
                default:
                    lblGrade.Text = "학점: F";
                    break;
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            lblRepeat.Text = "";
            //int i = 0;
            //while(i<5)
            //{
            //    lblRepeat.Text += i + "번, " + "C# Programming\n";
            //    i++;
            //}
            //for (int i=0; i<5; i++)
            //{
            //    lblRepeat.Text += i + "번, " + "C# Programming\n";
            //}
            int i = 0;
            do
            {
                lblRepeat.Text += i + "번, " + "C# Programming\n";
                i++;
            }
            while (i < 5);
        }
    }
}
