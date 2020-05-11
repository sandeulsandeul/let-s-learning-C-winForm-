using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // membership Enum 타입
        public enum MemberTyoe
        {
            VIP = 0,
            Regular,
            Associate,
            DayPass
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("VIP 회원");
            listBox1.Items.Add("정회원");
            listBox1.Items.Add("준회원");
            listBox1.Items.Add("일일 회원");

            // 정회원이 기본 선택
            listBox1.SelectedIndex = 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e, MemberTyoe memberType, MemberTyoe membertype)
        {
            // SelectedIndex 는 정수값을 반환하기 때문에
            // MemberType 변환이 필요하다. 
            memberType = (MemberTyoe)listBox1.SelectedIndex;
        }
        private MemberTyoe  memberType;
    }
}


