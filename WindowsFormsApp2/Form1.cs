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

        private void Form1_Load(object sender, EventArgs e)
        {
            // 콤보박스에 사용할 데이터 선언 
            string[] data = {"사과", "토마토", "포도","배","복숭아" };

            //comboBox1 은 SImple
            //comboBox2 은 DropDown
            //comboBox3 은 DropDownList

            // 각 톰보 박스에 데이터 초기화
            comboBox1.Items.AddRange(data);
            comboBox2.Items.AddRange(data);
            comboBox3.Items.AddRange(data);

            // 처음 선택값 지정, 첫번째 아이템 선택  (사과)
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            // simple 콤보 박스의 목록을 초기화하고 다시 목록 추가
            /*
             * comboBox1.Items.Add("Item 1");
             * comboBox1.Items.Clear();
             * comboBox1.Items.AddRange( new String[] {"1","2","3"} );
             */


        }

        //SelectedIndexChanged 이벤트 헨들링
        // 사용자가 콤보 박스의 목록 중에서 다른 아이템을 선택시 발생

        private void comboDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex >= 0)
            {
                this.itemSelected = comboBox2.SelectedItem as string; 
            }
        }

        private string itemSelected;
    }
}

