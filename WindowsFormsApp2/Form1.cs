using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        // 변수 설정 
        int tasknum = 0;
        int completenum = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }
        //item 추가 
        private void Plus_Click(object sender, EventArgs e)
        {
            string str = taskinput.Text;
            checkedListBox1.Items.Add(str);
            taskinput.Text = "";
            tasknum += 1;

            textBox2.Text = tasknum + "개의 할 일이 있습니다.";
            textBox3.Text = completenum + "개의 일을 완료했습니다.";
        }


        // task 완료  
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var r in checkedListBox1.CheckedItems.OfType<string>().ToList())
            {
                listView1.Items.Add(r);
                checkedListBox1.Items.Remove(r);
                tasknum -= 1;
                completenum++;

                textBox2.Text = tasknum + "개의 할 일이 있습니다.";
                textBox3.Text = completenum + "개의 일을 완료했습니다.";
            }
        }

        // task 삭제 
        private void Delete_Click_1(object sender, EventArgs e)
        {
            for (int i = 0 ; i < listView1.Items.Count ; i++)
            {
                if(listView1.Items[i].Checked == true)
                {
                    listView1.Items.RemoveAt(i);
                    completenum--;



                    textBox3.Text = completenum + "개의 일을 완료했습니다.";
                }
            }
            
        }

    }
}


