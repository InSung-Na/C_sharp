// PLC Connect
/*
 - Use Tools
    - GX-works2
    - MX-Component
 - PLC 연결방법
    - GX-works2 실행
        - Ladder도 구현
    - Communication Setup Utility(MX-Component)실행
        - Wizard -> 각종 설정 -> Logical station number = 1
    - C# 연결
        - 솔루션 탐색기 -> 참조 -> 찾아보기 -> mx-component 설치경로에서 \MELSEC\Act\Control\ActMulti.dll 추가
 - PLC 클래스
    - using ACTMULTILib;
    - ActEasyIF: PLC 객체 생성
    - PLC.ActLogicalStationNumber: 로컬연결 번호 설정
    - PLC.Open(); PLC.Close();  : 연결 설정
    - PLC.SetDevice("NAME", DATA); : Ladder의 NAME 디바이스의 값을 DATA로 입력함
    - PLC.GetDevice("NAME", out VAR);   : Ladder의 NAME 디바이스의 값을 변수 VAR에 저장함
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ACT 추가
using ACTMULTILib;

namespace _15_16_Mitsubishi_PLC_test
{
    public partial class Form1 : Form
    {
        // PLC 객체 생성
        ActEasyIF PLC1 = new ActEasyIF();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            PLC1.ActLogicalStationNumber = 1;   // 로컬 지역번호 1번 PLC에 연결
            int conErr = 0;
            conErr = PLC1.Open();               // PLC 연결시도
            if (conErr == 0)
            {
                lblStatus.Text = "Connected";  // 연결 성공시 출력
                tmrUpdate.Start();
            }
            else lblStatus.Text = "Connection error " + conErr; // 연결 실패시 오류 출력
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {

            int conErr = 0;
            conErr = PLC1.Close();
            if (conErr == 0)
            {
                lblStatus.Text = "DisConnected";
                tmrUpdate.Stop();
            }
            else lblStatus.Text = "DisConnection error " + conErr;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            PLC1.SetDevice("M100", 1);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            PLC1.SetDevice("M100", 0);
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            PLC1.GetDevice("Y20", out int Y20);
            if (Y20 == 1) lamp1.BackColor = Color.Red;
            else          lamp1.BackColor = Color.LightGray;

            PLC1.GetDevice("D0", out int D0);
            tbData1.Text = D0.ToString();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            PLC1.SetDevice("D10", int.Parse(tbData2.Text));
        }
    }
}
