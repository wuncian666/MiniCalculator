using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小算盤
{
    public partial class Form1 : Form
    {
        String result = "";
        private bool isCalculating = false;
        private string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberInput(object sender, EventArgs e)
        {
            if (isCalculating || display.Text == "0")
            {
                display.Clear();
                isCalculating = false;
            }

            Button button = (Button)sender;
            display.Text += button.Text;
        }

        private void Calculate(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = display.Text;
            isCalculating = true;
        }

        private void EqualsClick(object sender, EventArgs e)
        {
            //double current = double.Parse(display.Text);
            Console.WriteLine(display.Text);

            Calc calc = new Calc();
            calc.Current = display.Text;
            calc.Result = result;
            calc.Operation = operation;
            display.Text = calc.GetResult();

            Console.WriteLine("計算結果: " + result);

            isCalculating = false;

            //display.Text = result.ToString();
        }

        private void ClearClick(object sender, EventArgs e)
        {
            display.Text = "0";
            result = "0";
            isCalculating = false;
        }

        private void ZeroClick(object sender, EventArgs e)
        {
            if (display.Text == "0") 
            {
                display.Clear();
            }

            Button btn = (Button)sender;
            display.Text += btn.Text;
        }
    }
}
