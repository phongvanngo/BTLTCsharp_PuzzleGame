using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLTCsharp_PuzzleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn1.Focus();

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            Button a = new Button();
            a.BackColor = btn1.BackColor;
            btn1.BackColor = btn4.BackColor;
            btn4.BackColor = a.BackColor; 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            MessageBox.Show("hi");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btn1.Focus();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Focus();

        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Button a = new Button();
                a.BackColor = btn1.BackColor;
                btn1.BackColor = btn2.BackColor;
                btn2.BackColor = a.BackColor;

                btn2.Focus(); 
            }
            else if (e.KeyCode == Keys.W)
            {
                Button a = new Button();
                a.BackColor = btn1.BackColor;
                btn1.BackColor = btn4.BackColor;
                btn4.BackColor = a.BackColor;

                btn4.Focus();
            }
        }

        private void btn2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Button a = new Button();
                a.BackColor = btn2.BackColor;
                btn2.BackColor = btn3.BackColor;
                btn3.BackColor = a.BackColor;

                btn3.Focus();
            }
            else if (e.KeyCode == Keys.W)
            {
                Button a = new Button();
                a.BackColor = btn2.BackColor;
                btn2.BackColor = btn5.BackColor;
                btn5.BackColor = a.BackColor;

                btn5.Focus();
            }
            else if (e.KeyCode == Keys.D)
            {
                Button a = new Button();

                a.BackColor = btn2.BackColor;
                btn2.BackColor = btn1.BackColor;
                btn1.BackColor = a.BackColor;

                btn1.Focus();
            }
        }

        private void btn3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                Button a = new Button();
                a.BackColor = btn3.BackColor;
                btn3.BackColor = btn2.BackColor;
                btn2.BackColor = a.BackColor;

                btn2.Focus();
            }
            else if (e.KeyCode == Keys.W)
            {
                Button a = new Button();
                a.BackColor = btn3.BackColor;
                btn3.BackColor = btn6.BackColor;
                btn6.BackColor = a.BackColor;

                btn6.Focus();
            }
           
        }

        private void btn4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Button a = new Button();
                a.BackColor = btn4.BackColor;
                btn4.BackColor = btn5.BackColor;
                btn5.BackColor = a.BackColor;

                btn5.Focus();
            }
            else if (e.KeyCode == Keys.W)
            {
                Button a = new Button();
                a.BackColor = btn4.BackColor;
                btn4.BackColor = btn7.BackColor;
                btn7.BackColor = a.BackColor;

                btn7.Focus();
            }
            else if (e.KeyCode == Keys.S)
            {
                Button a = new Button();

                a.BackColor = btn4.BackColor;
                btn4.BackColor = btn1.BackColor;
                btn1.BackColor = a.BackColor;

                btn1.Focus();
            }
        }

        private void btn5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Button a = new Button();
                a.BackColor = btn5.BackColor;
                btn5.BackColor = btn6.BackColor;
                btn6.BackColor = a.BackColor;

                btn6.Focus();
            }
            else if (e.KeyCode == Keys.W)
            {
                Button a = new Button();
                a.BackColor = btn5.BackColor;
                btn5.BackColor = btn8.BackColor;
                btn8.BackColor = a.BackColor;

                btn8.Focus();
            }
            else if (e.KeyCode == Keys.D)
            {
                Button a = new Button();

                a.BackColor = btn5.BackColor;
                btn5.BackColor = btn4.BackColor;
                btn4.BackColor = a.BackColor;

                btn4.Focus();
            }
            else if (e.KeyCode == Keys.S)
            {
                Button a = new Button();

                a.BackColor = btn5.BackColor;
                btn5.BackColor = btn2.BackColor;
                btn2.BackColor = a.BackColor;

                btn2.Focus();
            }
        }

        private void btn6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                Button a = new Button();
                a.BackColor = btn6.BackColor;
                btn6.BackColor = btn3.BackColor;
                btn3.BackColor = a.BackColor;

                btn3.Focus();
            }
            else if (e.KeyCode == Keys.W)
            {
                Button a = new Button();
                a.BackColor = btn6.BackColor;
                btn6.BackColor = btn9.BackColor;
                btn9.BackColor = a.BackColor;

                btn9.Focus();
            }
            else if (e.KeyCode == Keys.D)
            {
                Button a = new Button();

                a.BackColor = btn6.BackColor;
                btn6.BackColor = btn5.BackColor;
                btn5.BackColor = a.BackColor;

                btn5.Focus();
            }
           
        }

        private void btn7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Button a = new Button();
                a.BackColor = btn7.BackColor;
                btn7.BackColor = btn8.BackColor;
                btn8.BackColor = a.BackColor;

                btn8.Focus();
            }
            else if (e.KeyCode == Keys.S)
            {
                Button a = new Button();
                a.BackColor = btn7.BackColor;
                btn7.BackColor = btn4.BackColor;
                btn4.BackColor = a.BackColor;

                btn4.Focus();
            }
          
        }

        private void btn8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Button a = new Button();
                a.BackColor = btn8.BackColor;
                btn8.BackColor = btn9.BackColor;
                btn9.BackColor = a.BackColor;

                btn9.Focus();
            }
            else if (e.KeyCode == Keys.S)
            {
                Button a = new Button();
                a.BackColor = btn8.BackColor;
                btn8.BackColor = btn5.BackColor;
                btn5.BackColor = a.BackColor;

                btn5.Focus();
            }
            else if (e.KeyCode == Keys.D)
            {
                Button a = new Button();

                a.BackColor = btn8.BackColor;
                btn8.BackColor = btn7.BackColor;
                btn7.BackColor = a.BackColor;

                btn7.Focus();
            }
          
        }

        private void btn9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                Button a = new Button();
                a.BackColor = btn9.BackColor;
                btn9.BackColor = btn8.BackColor;
                btn8.BackColor = a.BackColor;

                btn8.Focus();
            }
            else if (e.KeyCode == Keys.S)
            {
                Button a = new Button();
                a.BackColor = btn9.BackColor;
                btn9.BackColor = btn6.BackColor;
                btn6.BackColor = a.BackColor;

                btn6.Focus();
            }
          
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            
            pictureBox_Main.Image = BTLTCsharp_PuzzleGame.Properties.Resources.M20;
        }
    }
}
