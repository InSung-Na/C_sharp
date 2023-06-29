// 파일 입출력
/*
 - StreamWriter("FILE"): FILE에 데이터 저장하는 클래스
    - sw.WriteLine("TEXT"): 내용 저장
    - @"SAVE_PATH": 파일 경로 설정 ex. @"D:\data.txt"

 - StreamReader("FILE"): FILE의 데이터 읽는 클래스
    - sr.ReadLine();: 내용 한줄 읽기
    - while(!sr.EndOfStream){sr.ReadLine();}: 모든 내용 읽기
 */

using System;
using System.IO;    // 입출력 네임스페이스 사용선언
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_File_Write_Read
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            // 데이터 쓰기 클래스 선언
            // .rtf: 워드 확장자
            using (StreamWriter sw = new StreamWriter("data.rtf"))
            {
                sw.WriteLine("+++ 입력내용 +++");
                sw.WriteLine(rtb.Text);
                //sw.Close();
            }
            MessageBox.Show("저장되었습니다");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // 데이터 읽기 클래스 선언
            StreamReader sr = new StreamReader("data.rtf");
            // stream이 마지막이 아니면 반복 실행
            while(!sr.EndOfStream)
            {
                rtb.AppendText(sr.ReadLine() + Environment.NewLine);
            }
            MessageBox.Show("파일을 읽었습니다");
            sr.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtb.Clear();
            MessageBox.Show("출력 상자를 초기화했습니다");
        }
    }
}
