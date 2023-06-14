// 문자열 길이 측정
// 학습 링크 : https://www.youtube.com/watch?v=UkIZ8fOVX4Q&list=PLznxAZVxcYDIZ_6LvePK1xrgeq_GkD6Mn&index=7
// 학습 링크 : https://www.youtube.com/watch?v=i9RxIwgJnDM&list=PLznxAZVxcYDIZ_6LvePK1xrgeq_GkD6Mn&index=8
/*
 - str.Length
    - 문자열의 길이 반환
    - 다른 문자와 결합하는 경우, 자동으로 정수가 문자로 캐스팅됨
    - 하지만 명시적으로 지정하는 것이 좋아보인다
 - str.IndexOf(TARGET)
    - TARGET의 위치(Index) 반환
    - Index는 0번 부터 시작
 - str.SubString(Start, Length)
    - 문자열의 index=Start부터 Length만큼 검색
 - str.Replace
    - 문자열 변환

 - StringBuilder
    - 문자열을 편집기능 사용가능

    - strBuilder.Clear()
        - 문자열 초기화
    - strBuilder.Append(TARGET)
        - 문자열 추가
    - strBuilder.Remove(START, LENGTH)
        - 범위에 해당하는 문자 제거
    - strBuilder.Insert(POS, TARGET)
        - POS에 TARGET 추가

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

namespace _7_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string str = tbID.Text;
            lblID.Text = str.Length.ToString() + "글자입니다.";  // 문자 길이 반환

            int pos = str.IndexOf("-"); // 해당 문자의 위치 찾기
            
            // "-"문자가 존재하면 실행, 주민번호가 입력되었다고 가정
            if(pos >= 0)
            {
                lblID.Text = (pos + 1) + "번째에 - 문자가 있습니다.";
                string subStr = str.Substring(pos+1, 1);  // 주민번호 첫번째 뒷자리 읽기

                if ((subStr == "1")|| (subStr == "3"))  // 1과 3이면 남성
                {
                    lblGender.Text = "남성";
                }
                else if ((subStr == "2") || (subStr == "4"))    // 2와 4면 여성
                {
                    lblGender.Text = "여성";
                }
                else                       // 어디에도 속하지 않으면 실행
                {
                    lblGender.Text = "사람 맞나요?";
                }
            }
            // 폰 번호 replace
            string phone = tbPhone.Text.Replace("-", "").Replace(" ", "");
            lblShort.Text = phone;

            // 영문이름 대소문자화
            string name = tbName.Text.ToUpper();
            //string name = tbName.Text.ToLower();
            lblName.Text = name;
        }


// String Builder

        StringBuilder strBuilder = new StringBuilder();

        private void btnDefault_Click(object sender, EventArgs e)
        {
            strBuilder.Clear();
            strBuilder.Append("안녕하세요");
            lblResult.Text = strBuilder.ToString();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            strBuilder.Append(" Hello");
            lblResult.Text = strBuilder.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            strBuilder.Remove(2, 3);
            lblResult.Text = strBuilder.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            strBuilder.Insert(2, " 영어로는");
            lblResult.Text = strBuilder.ToString();
        }
    }
}
