// Class
/*
 - Class
    - 사용목적: 동일한 형식의 객체를 다룰 때, 다수생성과 유지보수가 용이함
        - ex: 다양한(많은) 강아지와 동일 기능을 생성
 - public
    - 클래스 외부에서 접근 가능함
 - private
    - 클래스 내부에서만 접근 가능
 - this
    - 내부의 변수를 의미함
    - 동일변수명이 하나인 경우 불필요
    - python에서는 self와 동일
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_14_Class
{
    class Dog
    {
        //멤버변수
        private string dogName;
        private int dogLife = 50;

        //생성자
        public Dog()
        {
            
        }

        //메소드
        public void SetDogName(string dogName)
        {
            this.dogName = dogName;
        }

        public int GetDogLife()
        {
            return dogLife;
        }
        public void Play()
        {
            dogLife += 5;
            if (dogLife >= 100) { dogLife = 100; }
        }

        public void Feed()
        {
            dogLife += 8;
            if (dogLife >= 100) { dogLife = 100; }
        }

        public void LifeDec()
        {
            dogLife -= 1;
            if (dogLife <= 0) { dogLife = 0; }
        }

        public string Message()
        {
            string msg;
            if (dogLife > 70) { msg = dogName + "는(가) 행복해요~"; }
            else if (dogLife > 50) { msg = dogName + "랑 놀아주세요"; }
            else if (dogLife > 30) { msg = dogName + "는 배고파요"; }
            else if (dogLife > 0) { msg = dogName + "가 힘들어해요"; }
            else { msg = "게임이 끝났어요 ㅜㅜ"; }
            return msg;
        }


    }
}
