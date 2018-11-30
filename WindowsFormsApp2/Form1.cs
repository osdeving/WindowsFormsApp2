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
        private int factor1;
        private int factor2;
        Random rnd = new Random();

        CheckBox[] checkBoxList = new CheckBox[10];
        CheckedListBox[] checkedList = new CheckedListBox[10];


        bool[] factors = new bool[] 
            { false, false, false, false, false, false, false, false, false, false
              
             };

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkAnswer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedList[0] = checkedListBox1;
            checkedList[1] = checkedListBox2;
            checkedList[2] = checkedListBox3;
            checkedList[3] = checkedListBox4;
            checkedList[4] = checkedListBox5;
            checkedList[5] = checkedListBox6;
            checkedList[6] = checkedListBox7;
            checkedList[7] = checkedListBox8;
            checkedList[8] = checkedListBox9;
            checkedList[9] = checkedListBox10;

            checkBoxList[0] = checkBox1;
            checkBoxList[1] = checkBox2;
            checkBoxList[2] = checkBox3;
            checkBoxList[3] = checkBox4;
            checkBoxList[4] = checkBox5;
            checkBoxList[5] = checkBox6;
            checkBoxList[6] = checkBox7;
            checkBoxList[7] = checkBox8;
            checkBoxList[8] = checkBox9;
            checkBoxList[9] = checkBox10;

            foreach (var item in checkedList)
                for (int i = 0; i < item.Items.Count; i++)
                    item.SetItemChecked(i, true);


            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;

            generateQuestion();

            label1.Text = factor1.ToString() + " x " + factor2.ToString();

        }

        private int generateQuestion()
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < 100; i++)
            {
                factor1 = rnd.Next(1, 9);
                if (factors[factor1 - 1])
                    break;
            }

            for (j = 0; j < 100; j++)
            {
                factor2 = rnd.Next(1, 9);

              
                if (checkedListBox1.GetItemChecked(factor2 - 1))
                    break;
            }

            if(i == 99 || j == 99)
                MessageBox.Show("Marque alguma número");


            label1.Text = factor1.ToString() + " x " + factor2.ToString();

            return factor1 * factor2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkAnswer();
            }
        }

        private void checkAnswer()
        {
            int answer = 0;

            if (Int32.TryParse(textBox1.Text, out answer))
            {
                if (answer != factor1 * factor2)
                {
                   System.Media.SystemSounds.Question.Play();
                   textBox1.ForeColor = Color.Red;
                }
                else
                {
                    generateQuestion();
                    label1.Text = factor1.ToString() + " x " + factor2.ToString();
                    textBox1.Text = "";
                }

            }
        }

        
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            factors[0] = !factors[0];

            if(!factors[0])
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            factors[1] = !factors[1];

            if (!factors[1])
            {
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                    checkedListBox2.SetItemChecked(i, false);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            factors[2] = !factors[2];

            if (!factors[2])
            {
                for (int i = 0; i < checkedListBox3.Items.Count; i++)
                    checkedListBox3.SetItemChecked(i, false);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            factors[3] = !factors[3];

            if (!factors[3])
            {
                for (int i = 0; i < checkedListBox4.Items.Count; i++)
                    checkedListBox4.SetItemChecked(i, false);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            factors[4] = !factors[4];

            if (!factors[4])
            {
                for (int i = 0; i < checkedListBox5.Items.Count; i++)
                    checkedListBox5.SetItemChecked(i, false);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            factors[5] = !factors[5];

            if (!factors[5])
            {
                for (int i = 0; i < checkedListBox6.Items.Count; i++)
                    checkedListBox6.SetItemChecked(i, false);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            factors[6] = !factors[6];

            if (!factors[6])
            {
                for (int i = 0; i < checkedListBox7.Items.Count; i++)
                    checkedListBox7.SetItemChecked(i, false);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            factors[7] = !factors[7];

            if (!factors[7])
            {
                for (int i = 0; i < checkedListBox8.Items.Count; i++)
                    checkedListBox8.SetItemChecked(i, false);
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            factors[8] = !factors[8];

            if (!factors[8])
            {
                for (int i = 0; i < checkedListBox9.Items.Count; i++)
                    checkedListBox9.SetItemChecked(i, false);
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            factors[9] = !factors[9];

            if (!factors[9])
            {
                for (int i = 0; i < checkedListBox10.Items.Count; i++)
                    checkedListBox10.SetItemChecked(i, false);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
