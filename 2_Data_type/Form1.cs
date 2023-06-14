// 데이터 타입
// 학습 영상 : https://www.youtube.com/watch?v=33DiEhePqiA&list=PLznxAZVxcYDIZ_6LvePK1xrgeq_GkD6Mn&index=2
/*
- 데이터 타입
    - 논리형(bool)
    - 정수형(int)
    - 실수형(float[소수점 7자리], double[소수점 16자리])
    - 문자형(char[단일], string[다수])
    - 모든형(object)
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

namespace _2_Data_type
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int iValue = 100;
            lblResult.Text = iValue.ToString();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double dValue = 3.14159;
            lblResult.Text = dValue.ToString();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string sValue = "C#을 시작합니다";
            lblResult.Text = sValue.ToString();
        }
    }
}
