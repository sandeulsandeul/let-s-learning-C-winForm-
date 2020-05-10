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
    }
}
