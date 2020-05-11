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
            /*public Form1 이라는 창 화면을 
              InitializeComponent();함수를 적용해
              디자인한 화면으로적용*/
            InitializeComponent();

            /*button1이 클릭되었을 때 button_Click() 함수 적용 */
            this.button1.Click += new System.EventHandler(this.button1_Click_1);

           

        }

        /*private (클래스 내에서만 접근 가능 )로 button1_Click 함수 생성*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*MessageBox의 Show 사용해 Hello World 출력 */
            MessageBox.Show("Hello World");
        }

        private void Form1_Load_1( object sender, EventArgs e)
        {
            //TextBox에 초기값 할당
            textBox1.Text = "서울특별시 영등포구 신길동 123번지";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("이름 : 홍길동");
            sb.AppendLine("나이 : 27세");
            sb.AppendLine("국적 : 한국");
            textBox2.Text = sb.ToString();

            /*최대 길이 지정*/
            textBox3.MaxLength = 10;
            /*읽기만 가능 */
            textBox4.ReadOnly = true;
            /* PasswordChar 는 비밀번호를 받는다*/
            textBox5.PasswordChar = '*'; 

            textBox3.Text = "서울특별시 영등포구 신길동 123번지";
            textBox4.Text = "서울특별시 영등포구 신길동 123번지";
            textBox5.Text = "서울특별시 영등포구 신길동 123번지";
        }
    }
}
