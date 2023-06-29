// C# 간단 기능 알아보기
// 학습 영상 : https://www.youtube.com/watch?v=PxkmsDu3ZTA
/*
- 준비단계
    - "도구 상자"와 "속성 창"
    - 상단의 "검색"에 검색해서 여는 법 알 수 있음

- 메인기능
    - 도구 상자에서 사용할 창("Button", "Label") 가져오기
    - "속성 창"에서 여러 속성(폰트, 크기, 기능 등) 수정가능

- 코드작성
    - 각 창을 더블클릭 또는 이벤트에서 생성
    - 자동으로 베이직코드(프레임)이 생성됨
    - private 코드 안에 내용 작성

- 불필요한 이벤트 제거법
    - 디자인 창을 옮기다가 더블클릭으로 인식되어 불필요한 이벤트가 생성될 수 있음
    - 디자인의 어떤 창과 참조되어 있다면 삭제 불가능
    - 해당 창의 속성-이벤트로 이동해서 해당하는 이벤트에 우클릭 -> "다시 설정(R)"
    - 참조가 해제되어 코드 삭제 가능
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_C__Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //버튼1 클릭 시 실행 프로그램 작성
            //label에 텍스트 입력
            label1.Text = "안녕하세요? C#을 시작합니다";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //버튼2 클릭 시 실행 프로그램 작성
            label1.Text = "";
        }
    }
}
