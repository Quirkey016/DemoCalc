using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCalc
{

    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region buttons

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        private void button16_Click(object sender, EventArgs e)
        {
             currentInput = "";
             result = 0;
             operation = "";
             operationPending = false;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("Xpression!", string.Empty.GetType(), textBox1.Text);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            double result = double.Parse((string)row["Xpression!"]);

            textBox1.Text = result.ToString();

             currentInput = "";
             result = 0;
             operation = "";
             operationPending = false;
        }

#endregion

        void Evaluate()
        {
            if(operationPending)
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;

                    case "-":
                        result += secondNumber;
                        break;

                    case "*":
                        result += secondNumber;
                        break;

                    case "/":
                        if(secondNumber != 0) 
                        {
                            result /= secondNumber;
                        }

                        else 
                        {
                            textBox1.Text = "Error";
                        }
                        break;
                }
                textBox1.Text = result.ToString();
                currentInput = "";
                operationPending = false;
                }
            }

        
    }
    }

