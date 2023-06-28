// Class
/*
 - Class
    - 사용목적: 동일한 형식의 객체를 다룰 때, 다수생성과 유지보수가 용이함
        - ex: 다양한(많은) 강아지와 동일 기능을 생성
 - public
    - 클래스 외부에서 접근 가능함
    - 클래스 기능 선언
 - private
    - 클래스 내부에서만 접근 가능
    - 멤버변수 선언
 - this
    - 내부의 변수를 의미함
    - 동일변수명이 하나인 경우 불필요
    - python에서는 self와 동일
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

namespace _13_14_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 클래스 객체 생성
        Dog myDog = new Dog();  // 클래스 생성자

        // 강아지 키우기 앱
        private void btnStart_Click(object sender, EventArgs e)
        {
            myDog.SetDogName(tbName.Text);
            tmrLife.Start(); // tmrLife.Enabled = true;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            myDog.Play();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            myDog.Feed();
        }

        private void tmrLife_Tick(object sender, EventArgs e)
        {
            //Life decrease
            myDog.LifeDec();

            // prograssBar display
            prsBar.Value = myDog.GetDogLife();

            // Message display
            lblStatus.Text = myDog.Message();
        }


    }
}
