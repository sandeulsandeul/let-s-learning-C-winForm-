using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Check 상태로 초기화하기
            checkBox1.Checked = true;

            // UnCheked 상태로 초기화하기
            checkBox2.Checked = false;

            //Intwemediate 상태로 초기화하기 
            //Form1.cs[디자인] 에서 마우스 오른쪽 클릭 후 속성
            // 모양에서 CheckState에서 Intermediate  선택 

            // Intermediate 에 속한 4번 체크 박스 checked 로 초기화
            checkBox4.Checked = true;

            // Intermediate 에 속한 5번 체크 박스 Unchecked 로 초기화
            checkBox5.Checked = false;

            // checkBox6의 체크상태가 바뀔 때마다  checkBox6_CheckStateChanged 함수 호출
            checkBox6.CheckStateChanged += checkBox6_CheckedChanged;
        }

        int count = 0;
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            // 텍스트 박스에 변경 시마다 변경 횟수+ 변경이라고 적기
            count ++ ;
            textBox1.ReadOnly = true;
            textBox1.Text = count + "변경";
        }
    }
}
