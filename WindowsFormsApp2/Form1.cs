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

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * 현재 디렉토리 내의 파일리스트 얻기
             * using System.IO;가 필수로 사용된다. 
             *
             */

            // currdir에 현재 파일이 저장될 위치 
            string currdir = Environment.CurrentDirectory;
            // new DirectoryInfo(currdir) 를 통해서
            // currdir의 정보를 읽어들인다. 
            DirectoryInfo di = new DirectoryInfo(currdir);
            // di.GetFiles()를 통해 di가 가진 파일들을 
            // files에 담는다. 
            FileInfo[] files = di.GetFiles();

            //리스트 뷰 아이이템 업데이트 시작 
            // 업데이트가 종료될 때까지 ui 갱신 중지.
            listView1.BeginUpdate();

            // 뷰 모드 지정
            listView1.View = View.Details;

            // 아이콘을 위해 이미지 지정
            listView1.LargeImageList = imageList1;
            listView1.SmallImageList = imageList2;

            foreach(var fi in files)
            {
                //각 파일별로 ListViewItem 객체를 하나씩 만들기
                // 파일명, 사이즈, 날짜 정보를 추가함.

                ListViewItem lvi = new ListViewItem(fi.Name);
                lvi.SubItems.Add(fi.Length.ToString());
                lvi.SubItems.Add(fi.LastWriteTime.ToString());
                lvi.ImageIndex = 0;

                //ListViewItem 객체를 Items 속성에 추가하기
                listView1.Items.Add(lvi);

            }
            // 컬럼명과 컬럼 사이즈를 지정
            listView1.Columns.Add("파일명", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("사이즈", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("날짜", 100, HorizontalAlignment.Left);

            //리스트뷰를 새로고침하여 보여줌
            listView1.EndUpdate();
        }

        private void radioDetails_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void radioTitle_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }
        //View 모드를 지정


        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void radioList_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
    }
}


