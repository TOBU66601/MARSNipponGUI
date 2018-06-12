using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marsnippongui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "BVE日本線　マルスプログラム";
            Label selectmessege = new Label();
            selectmessege.Text = "業務選択";
            

            //フォントサイズのみ拡大させる

            selectmessege.Height = 30;
            selectmessege.Width = 300;


            //出札業務ボタン
            Button button1 = new Button();
            button1.Text = "出札業務";

            //ボタンのサイズは再度確認
            button1.Height = 50;
            button1.Width= 70;
            button1.Top = 60;

            this.Controls.Add(selectmessege);
            this.Controls.Add(button1);


        }


    }
}
