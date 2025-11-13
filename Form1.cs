using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Fifteen_Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global varaibles (i.e., modular)
        string TempStr;
        Color tempColor;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void swap(ref Button firstButton, ref Button secondButton)
        {
            TempStr = firstButton.Text;
            firstButton.Text = secondButton.Text;
            secondButton.Text = TempStr;

            tempColor = firstButton.BackColor;
            firstButton.BackColor = secondButton.BackColor;
            secondButton.BackColor = tempColor;
        }

        void resetPuzzle()
        {
            //declarations
            int counter;
            int num = 0;
            Random randGen = new Random();
            const int NUMOFSHUFFLES = 100;

            //shuffle button values and colors
            for(counter = 1; counter < NUMOFSHUFFLES; counter++)
            {
                num = randGen.Next(1,16);

                if (num == 1)
                    swap(ref btn0, ref btn1);
                else if (num == 2)
                    swap(ref btn0, ref btn2);
                else if (num == 3)
                    swap(ref btn0, ref btn3);
                else if (num == 4)
                    swap(ref btn0, ref btn4);
                else if (num == 5)
                    swap(ref btn0, ref btn5);
                else if (num == 6)
                    swap(ref btn0, ref btn6);
                else if (num == 7)
                    swap(ref btn0, ref btn7);
                else if (num == 8)
                    swap(ref btn0, ref btn8);
                else if (num == 9)
                    swap(ref btn0, ref btn9);
                else if (num == 10)
                    swap(ref btn0, ref btn10);
                else if (num == 11)
                    swap(ref btn0, ref btn11);
                else if (num == 12)
                    swap(ref btn0, ref btn12);
                else if (num == 13)
                    swap(ref btn0, ref btn13);
                else if (num == 14)
                    swap(ref btn0, ref btn14);
                else if (num == 15)
                    swap(ref btn0, ref btn15);
              
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetPuzzle();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //1,4
            if (btn1.Text == "0")
                swap(ref btn0, ref btn1);
            else if (btn4.Text == "0")
                swap(ref btn0, ref btn4);
            

           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //0,2,5
            if (btn0.Text == "0")
                swap(ref btn1, ref btn0);
            else if (btn2.Text == "0")
                swap(ref btn1, ref btn2);
            else if (btn5.Text == "0")
                swap(ref btn1, ref btn5);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //2, 7
            if (btn2.Text == "0")
                swap(ref btn3, ref btn2);
            else if (btn7.Text == "0")
                swap(ref btn3, ref btn7);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //1,3,6
            if (btn1.Text == "0")
                swap(ref btn2, ref btn1);
            else if (btn3.Text == "0")
                swap(ref btn2, ref btn3);
            else if (btn6.Text == "0")
                swap(ref btn2, ref btn6);
            

            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //0,5,8
            if (btn0.Text == "0")
                swap(ref btn4, ref btn0);
            else if (btn5.Text == "0")
                swap(ref btn4, ref btn5);
            else if (btn8.Text == "0")
                swap(ref btn4, ref btn8);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //1,4,6,9
            if (btn1.Text == "0")
                swap(ref btn5, ref btn1);
            else if (btn4.Text == "0")
                swap(ref btn5, ref btn4);
            else if (btn6.Text == "0")
                swap(ref btn5, ref btn6);
            else if (btn6.Text == "0")
                swap(ref btn5, ref btn9);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //2,5,7,10
            if (btn2.Text == "0")
                swap(ref btn6, ref btn2);
            else if (btn5.Text == "0")
                swap(ref btn6, ref btn5);
            else if (btn7.Text == "0")
                swap(ref btn6, ref btn7);
            else if (btn10.Text == "0")
                swap(ref btn6, ref btn10);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //3,6,11
            if (btn3.Text == "0")
                swap(ref btn7, ref btn3);
            else if (btn6.Text == "0")
                swap(ref btn7, ref btn6);
            else if (btn11.Text == "0")
                swap(ref btn7, ref btn11);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //4,9,12
            if (btn4.Text == "0")
                swap(ref btn8, ref btn4);
            else if (btn9.Text == "0")
                swap(ref btn8, ref btn9);
            else if (btn12.Text == "0")
                swap(ref btn8, ref btn12);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //5,8,10,13
            if (btn5.Text == "0")
                swap(ref btn9, ref btn5);
            else if (btn8.Text == "0")
                swap(ref btn9, ref btn8);
            else if (btn10.Text == "0")
                swap(ref btn9, ref btn10);
            else if (btn13.Text == "0")
                swap(ref btn9, ref btn13);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            //6,9,11,14
            if (btn6.Text == "0")
                swap(ref btn10, ref btn6);
            else if (btn9.Text == "0")
                swap(ref btn10, ref btn9);
            else if (btn11.Text == "0")
                swap(ref btn10, ref btn11);
            else if (btn14.Text == "0")
                swap(ref btn10, ref btn14);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            //7,10,15
            if (btn7.Text == "0")
                swap(ref btn11, ref btn7);
            else if (btn10.Text == "0")
                swap(ref btn11, ref btn10);
            else if (btn15.Text == "0")
                swap(ref btn11, ref btn15);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            //8,13
            if (btn8.Text == "0")
                swap(ref btn12, ref btn8);
            else if (btn13.Text == "0")
                swap(ref btn12, ref btn13);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            //9,12,14
            if (btn9.Text == "0")
                swap(ref btn13, ref btn9);
            else if (btn12.Text == "0")
                swap(ref btn13, ref btn12);
            else if (btn14.Text == "0")
                swap(ref btn13, ref btn14);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            //10,13,15
            if (btn10.Text == "0")
                swap(ref btn14, ref btn10);
            else if (btn13.Text == "0")
                swap(ref btn14, ref btn13);
            else if (btn15.Text == "0")
                swap(ref btn14, ref btn15);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            //11,14
            if (btn11.Text == "0")
                swap(ref btn15, ref btn11);
            else if (btn14.Text == "0")
                swap(ref btn15, ref btn14);
        }
    }
}
