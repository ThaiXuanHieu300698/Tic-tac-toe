using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {
        string turn = "X";
        string[,] frm = new string[3, 3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
        void convertToArray()
        {
            frm[0, 0] = btn1.Text;
            frm[0, 1] = btn2.Text;
            frm[0, 2] = btn3.Text;
            frm[1, 0] = btn4.Text;
            frm[1, 1] = btn5.Text;
            frm[1, 2] = btn6.Text;
            frm[2, 0] = btn7.Text;
            frm[2, 1] = btn8.Text;
            frm[2, 2] = btn9.Text;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            if(turn == "X")
            {
                btn.Text = turn;
                lblXORO.Text = "O";
                turn = "O";
            }
            else if(turn == "O")
            {
                btn.Text = turn;
                lblXORO.Text = "X";
                turn = "X";
            }
            else
            {
                //
            }
            checkWin();
            checkTies();
        }
        
        bool checkWin()
        {
            convertToArray();

            if (frm[0, 0] == frm[0, 1] && frm[0, 1] == frm[0, 2] && frm[0, 2] == "X")
            {
                this.btn1.BackColor = System.Drawing.Color.Yellow;
                this.btn2.BackColor = System.Drawing.Color.Yellow;
                this.btn3.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thắng";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[0, 0] == frm[0, 1] && frm[0, 1] == frm[0, 2] && frm[0, 2] == "O")
            {
                this.btn1.BackColor = System.Drawing.Color.Yellow;
                this.btn2.BackColor = System.Drawing.Color.Yellow;
                this.btn3.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thua";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[1, 0] == frm[1, 1] && frm[1, 1] == frm[1, 2] && frm[1, 2] == "X")
            {
                this.btn4.BackColor = System.Drawing.Color.Yellow;
                this.btn5.BackColor = System.Drawing.Color.Yellow;
                this.btn6.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thắng";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[1, 0] == frm[1, 1] && frm[1, 1] == frm[1, 2] && frm[1, 2] == "O")
            {
                this.btn4.BackColor = System.Drawing.Color.Yellow;
                this.btn5.BackColor = System.Drawing.Color.Yellow;
                this.btn6.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thua";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[2, 0] == frm[2, 1] && frm[2, 1] == frm[2, 2] && frm[2, 2] == "X")
            {
                this.btn7.BackColor = System.Drawing.Color.Yellow;
                this.btn8.BackColor = System.Drawing.Color.Yellow;
                this.btn9.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thắng";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[2, 0] == frm[2, 1] && frm[2, 1] == frm[2, 2] && frm[2, 2] == "O")
            {
                this.btn7.BackColor = System.Drawing.Color.Yellow;
                this.btn8.BackColor = System.Drawing.Color.Yellow;
                this.btn9.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thua";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[0, 0] == frm[1, 0] && frm[1, 0] == frm[2, 0] && frm[2, 0] == "X")
            {
                this.btn1.BackColor = System.Drawing.Color.Yellow;
                this.btn4.BackColor = System.Drawing.Color.Yellow;
                this.btn7.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thắng";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[0, 0] == frm[1, 0] && frm[1, 0] == frm[2, 0] && frm[2, 0] == "O")
            {
                this.btn1.BackColor = System.Drawing.Color.Yellow;
                this.btn4.BackColor = System.Drawing.Color.Yellow;
                this.btn7.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thua";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[0, 1] == frm[1, 1] && frm[1, 1] == frm[2, 1] && frm[2, 1] == "X")
            {
                this.btn2.BackColor = System.Drawing.Color.Yellow;
                this.btn5.BackColor = System.Drawing.Color.Yellow;
                this.btn8.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thắng";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[0, 1] == frm[1, 1] && frm[1, 1] == frm[2, 1] && frm[2, 1] == "O")
            {
                this.btn2.BackColor = System.Drawing.Color.Yellow;
                this.btn5.BackColor = System.Drawing.Color.Yellow;
                this.btn8.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thua";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[0, 2] == frm[1, 2] && frm[1, 2] == frm[2, 2] && frm[2, 2] == "X")
            {
                this.btn3.BackColor = System.Drawing.Color.Yellow;
                this.btn6.BackColor = System.Drawing.Color.Yellow;
                this.btn9.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thắng";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[0, 2] == frm[1, 2] && frm[1, 2] == frm[2, 2] && frm[2, 2] == "O")
            {
                this.btn3.BackColor = System.Drawing.Color.Yellow;
                this.btn6.BackColor = System.Drawing.Color.Yellow;
                this.btn9.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thua";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[0, 0] == frm[1, 1] && frm[1, 1] == frm[2, 2] && frm[2, 2] == "X")
            {
                this.btn1.BackColor = System.Drawing.Color.Yellow;
                this.btn5.BackColor = System.Drawing.Color.Yellow;
                this.btn9.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thắng";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[0, 0] == frm[1, 1] && frm[1, 1] == frm[2, 2] && frm[2, 2] == "O")
            {
                this.btn1.BackColor = System.Drawing.Color.Yellow;
                this.btn5.BackColor = System.Drawing.Color.Yellow;
                this.btn9.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thua";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[0, 2] == frm[1, 1] && frm[1, 1] == frm[2, 0] && frm[2, 0] == "X")
            {
                this.btn3.BackColor = System.Drawing.Color.Yellow;
                this.btn5.BackColor = System.Drawing.Color.Yellow;
                this.btn7.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thắng";
                pnlFrame.Enabled = false;
                return true;
            }
            if (frm[0, 2] == frm[1, 1] && frm[1, 1] == frm[2, 0] && frm[2, 0] == "O")
            {
                this.btn3.BackColor = System.Drawing.Color.Yellow;
                this.btn5.BackColor = System.Drawing.Color.Yellow;
                this.btn7.BackColor = System.Drawing.Color.Yellow;
                lblWin.Text = "Bạn Thua";
                pnlFrame.Enabled = false;
                return true;
            }
            return false;
        }
        void checkTies()
        {
            convertToArray();

            if ((frm[0, 0] == "X" || frm[0, 0] == "O") && (frm[0, 1] == "X" || frm[0, 1] == "O")
                && (frm[0, 2] == "X" || frm[0, 2] == "O") && (frm[1, 0] == "X" || frm[1, 0] == "O")
                && (frm[1, 1] == "X" || frm[1, 1] == "O") && (frm[1, 2] == "X" || frm[1, 2] == "O")
                && (frm[2, 0] == "X" || frm[2, 0] == "O") && (frm[2, 1] == "X" || frm[2, 1] == "O")
                && (frm[2, 2] == "X" || frm[2, 2] == "O"))
            {
                if(checkWin())
                {
                    return;
                }
                else
                {
                    lblWin.Text = "Hòa Nhau";
                }
            }
            
        }
        void enabled()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            pnlFrame.Enabled = true;
        }
        private void btnRePlay_Click(object sender, EventArgs e)
        {
            enabled(); 
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn5.BackColor = System.Drawing.Color.Silver;
            this.btn6.BackColor = System.Drawing.Color.Silver;
            this.btn7.BackColor = System.Drawing.Color.Silver;
            this.btn8.BackColor = System.Drawing.Color.Silver;
            this.btn9.BackColor = System.Drawing.Color.Silver;

            turn = "X";
            lblXORO.Text = "X";
            lblWin.Text = "";
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
