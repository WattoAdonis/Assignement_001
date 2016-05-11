/*
 * Author:          Anthony Mousoulis
 * E-mail:          anthony.mousoulis2015@hotmail.com
 * GitHub:          https://mousoulisanthony.visualstudio.com/
 * Date Started:    May 5th, 2016.
 * Date Completed:  May 8th, 2016.
 * Description:     Create windows form application for users to enter 
 *                  information and apply tasks and events which they 
 *                  can view in the form window.
 * Part 01:         Ask the user to enter two numbers in the textboxes.
 * Part 02:         User click events triggered when button event is 
 *                  clicked for selected mathematic calcullations.
 * Part 03:         The user picks a letter from the alphabet to 
 *                  display whether it is a vowel or a consonant.
 * Part 04:         Swap the contents in two textboxes.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignement_001
{

    //class Swap
    //{
    //    public void switchy(ref int a, ref int b)
    //    {
    //        int temp;

    //        temp = a;
    //        a    = b;
    //        b    = temp;
    //    }
    //}

    public partial class Assignment_001_2016_05_06 : Form
    {
        public Assignment_001_2016_05_06()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            // Opperation: addition from event click and two numbers have been entered
            // using floats for decimal precision due to divisions...
            float firstTxtBoxNumber = float.Parse(txtBoxFirstNumber.Text);
            float secondTxtBoxNumber = float.Parse(txtBoxSecondNumber.Text);
            float result = firstTxtBoxNumber + secondTxtBoxNumber;

            //MessageBox.Show(result.ToString());
            txtBoxResults.Text = (result.ToString());
            //result = int.Parse(txtBoxFirstNumber.Text) + int.Parse(txtBoxSecondNumber.Text);
            // txtBoxResults = int.Parse(txtBoxFirstNumber.Text) + int.Parse(txtBoxSecondNumber.Text);
            // firstTextBoxNumber = int.Parse( tbFirstNumber.Text );
            //txtBoxResults = result.ToString;
            //.ToString;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            // Opperation: subtraction from event click and two numbers have been entered
            float firstTxtBoxNumber = float.Parse(txtBoxFirstNumber.Text);
            float secondTxtBoxNumber = float.Parse(txtBoxSecondNumber.Text);
            float result = firstTxtBoxNumber - secondTxtBoxNumber;

            //MessageBox.Show(result.ToString());
            txtBoxResults.Text = (result.ToString());
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            // Opperation: multiplication from event click and two numbers have been entered
            float firstTxtBoxNumber = float.Parse(txtBoxFirstNumber.Text);
            float secondTxtBoxNumber = float.Parse(txtBoxSecondNumber.Text);
            float result = firstTxtBoxNumber * secondTxtBoxNumber;

            //MessageBox.Show(result.ToString());
            txtBoxResults.Text = (result.ToString());
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            // Opperation: division from event click and two numbers have been entered
            float firstTxtBoxNumber = float.Parse(txtBoxFirstNumber.Text);
            float secondTxtBoxNumber = float.Parse(txtBoxSecondNumber.Text);
            float result = firstTxtBoxNumber / secondTxtBoxNumber;

            //MessageBox.Show(result.ToString());
            txtBoxResults.Text = (result.ToString());
        }

        private void Assignment_001_2016_05_06_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxFirstNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxFirstNumber.Text != String.Empty)
            {
                txtBoxFirstNumber.ForeColor = Color.Purple;
                txtBoxFirstNumber.BackColor = Color.White;
                // Move the selection pointer to the end of the text of the control.
                txtBoxFirstNumber.Select(txtBoxFirstNumber.Text.Length, 0);

                if (int.Parse(txtBoxFirstNumber.Text) % 2 == 0)
                {
                    // even number
                    lblEvenNumberFirst.BackColor = Color.Yellow;
                    lblOddNumberFirst.BackColor = Color.White;
                }
                else
                {
                    lblEvenNumberFirst.BackColor = Color.White;
                    lblOddNumberFirst.BackColor = Color.Yellow;
                }

            }

            //if (int.Parse(txtBoxFirstNumber.Text) % 2 == 0)
            //{
            //    // even number
            //    lblEvenNumberFirst.BackColor = Color.Yellow;
            //}

            //if (float.Parse(txtBoxFirstNumber.Text))
        }

        private void lblOddNumberFirst_Click(object sender, EventArgs e)
        {
            //if (txtBoxFirstNumber.)
        }

        private void txtBoxSecondNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSecondNumber.Text != String.Empty)
            {
                txtBoxSecondNumber.ForeColor = Color.Purple;
                txtBoxSecondNumber.BackColor = Color.White;
                // Move the selection pointer to the end of the text of the control.
                txtBoxSecondNumber.Select(txtBoxSecondNumber.Text.Length, 0);

                if (int.Parse(txtBoxSecondNumber.Text) % 2 == 0)
                {
                    // even number
                    lblEvenNumberSecond.BackColor = Color.Yellow;
                    lblOddNumberSecond.BackColor = Color.White;
                }
                else
                {
                    lblEvenNumberSecond.BackColor = Color.White;
                    lblOddNumberSecond.BackColor = Color.Yellow;
                }
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string temp = "";
            temp = txtBoxFirstNumber.Text;
            txtBoxFirstNumber.Text = txtBoxSecondNumber.Text;
            txtBoxSecondNumber.Text = temp;
            //txtBoxFirstNumber.Text ^= txtBoxSecondNumber.Text;
            //Swap myObject = new Swap();

            //
            //myObject.switchy(ref int.Parse(txtBoxFirstNumber.Text), ref int.Parse(txtBoxSecondNumber.Text));
            //

            //myObject.switchy(ref txtBoxFirstNumber., txtBoxSecondNumber);
            //public void 
            //int tempSwap = 0;

        }

        private void txtBoxLetter_TextChanged(object sender, EventArgs e) //; == {}
        {
            //int[][] scores = new int[3][]
            //    {
            //        new int[] { 92,93, 94},
            //        new int[] { 85, 66, 87, 88},
            //        new int[] { 185, 166, 847, 858}
            //    };


            //char v = 6;
            //char c = 20;
            string[] vowels = new string[] { "A,a,E,e,I,i,O,o,U,u,Y,y" };
            //stringArray[12];
            //{ "A, a, E, e, I, i, O, o, U, u, Y, y" };

            //vowels[] = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u', 'Y', 'y' };

            //vowels.Contains('A' | 'a' | 'E' | 'e' | 'I' | 'i' | 'O' | 'o' | 'U' | 'u' | 'Y' | 'y');

            if (!txtBoxLetter.Text.Contains("") && (txtBoxLetter.Text.Contains("A,a,E,e,I,i,O,o,U,u,Y,y")))
            //if (!txtBoxLetter.Text.Contains("") && (txtBoxLetter.Text.Contains("A,a,E,e,I,i,O,o,U,u,Y,y")))
            {
                MessageBox.Show("The letter you chose " + "\"" + txtBoxLetter + "\"" + " is a vowel!!!");
                //("The letter you chose is a vowel!!!");
                //Console.WriteLine("The letter you chose is a vowel!!!");
            }
            else if (txtBoxLetter.Text.Contains("B,b,C,c,D,d,F,f,G,g,H,h,J,j,K,k,L,l,M,m,N,n,P,p,Q,q,R,r,S,s,T,t,V,v,W,w,X,x,Z,z"))
            {
                MessageBox.Show("The letter you have chosen is a consonant!!!");
            }
            else
                MessageBox.Show("Try again!!!");
        } 
    }
}
