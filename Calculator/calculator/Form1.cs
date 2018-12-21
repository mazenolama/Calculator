using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class calculator : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))  
                result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text="0";
            value = 0;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value =Double.Parse( result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation; 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            try {
                switch (operation)
                {
                    case "+":
                        result.Text = (value + Double.Parse(result.Text)).ToString();
                        break;
                    case "-":
                        result.Text = (value - Double.Parse(result.Text)).ToString();
                        break;
                    case "*":
                        result.Text = (value * Double.Parse(result.Text)).ToString();
                        break;
                    case "/":
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                        break;
                    //case "^":
                    //    result.Text = Convert.ToString((Math.Pow(value, Double.Parse(result.Text)))
                    //    break;
                    case "^":
                        result.Text = Math.Pow(value, Double.Parse(result.Text)).ToString();
                       
                        break;
                }//end switch
            }
            catch
            {
                result.Text = "Math error";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (result.Text[result.Text.Length-1]!='.')
                {
                    result.Text = result.Text + ".";
                }
            }
            catch
            {
                result.Text = " Math Error";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (result.Text[0] == '-')
                {

                    result.Text = result.Text.Remove(0,1);
                }
                else
                {
                    result.Text = result.Text.Insert(0, "-");
                   
                }
            }
            catch
            {
                result.Text =  result.Text + "-";
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            result.Text = result.Text.Remove(0,1);
        }
    }
}
