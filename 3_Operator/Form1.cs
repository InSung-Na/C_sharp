// 연산자
// 학습 링크 : https://www.youtube.com/watch?v=vzvsEyPgVW8&list=PLznxAZVxcYDIZ_6LvePK1xrgeq_GkD6Mn&index=3
/*
- 산술연산자
    - +, - , * , / , %
- 대입연산자
    - =, +=, -=, *=, /=, %=
- 증감연산자
    - ++, --
- 관계연산자
    - ==, !=, >, <, >=, <=
- 논리연산자
    - !(A==B), &&, ||
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

namespace _3_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = num1 + num2;
            lblResult.Text = num3.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = num1 - num2;
            lblResult.Text = num3.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = num1 * num2;
            lblResult.Text = num3.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            float num3 = num1 / num2;
            lblResult.Text = num3.ToString();
        }
    }
}
