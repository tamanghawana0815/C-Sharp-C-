namespace Calculator
{
    public partial class Form1 : Form
    {
        string operat = " ";
        decimal num1 = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (result.Text == "ON" || result.Text == "0" || result.Text == "+" || result.Text == "*" || result.Text == "/" || result.Text == "-" || result.Text == "%")
            {
                result.Text = "1";
            }
            else
            {
                result.Text += "1";
            }
            string data = result.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (result.Text == "ON" || result.Text == "0" || result.Text == "+" || result.Text == "*" || result.Text == "/" || result.Text == "-" || result.Text == "%")
            {
                result.Text = "2";
            }
            else
            {
                result.Text += "2";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result.Text == "ON" || result.Text == "0" || result.Text == "+" || result.Text == "*" || result.Text == "/" || result.Text == "-" || result.Text == "%")
            {
                result.Text = "3";
            }
            else
            {
                result.Text += "3";
            }
        }

       
        
        private void button5_Click(object sender, EventArgs e)
        {
            if(result.Text == "ON" || result.Text == "0" || result.Text == "+" || result.Text == "*" || result.Text == "/" || result.Text == "-" || result.Text == "%")
            {
                result.Text = "4";
            }
            else
            {
                result.Text += "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (result.Text == "ON" || result.Text == "0" || result.Text == "+" || result.Text == "*" || result.Text == "/" || result.Text == "-" || result.Text == "%")
            {
                result.Text = "5";
            }
            else
            {
                result.Text += "5";
            }
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            if (result.Text == "ON" || result.Text == "0" || result.Text == "+" || result.Text == "*" || result.Text == "/" || result.Text == "-" || result.Text == "%")
            {
                result.Text = "6";
            }
            else
            {
                result.Text += "6";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (result.Text == "ON" || result.Text == "0" || result.Text == "+" || result.Text == "*" || result.Text == "/" || result.Text == "-" || result.Text == "%")
            {
                result.Text = "7";
            }
            else
            {
                result.Text += "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (result.Text == "ON" || result.Text == "0" || result.Text == "+" || result.Text == "*" || result.Text == "/" || result.Text == "-" || result.Text == "%")
            {
                result.Text = "8";
            }
            else
            {
                result.Text += "8";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (result.Text == "ON" || result.Text == "0" || result.Text == "+" || result.Text == "*" || result.Text == "/" || result.Text == "-" || result.Text == "%")
            {
                result.Text = "9";
            }
            else
            {
                result.Text += "9";
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (result.Text == "ON" || result.Text == "0"|| result.Text == "+" || result.Text == "*" || result.Text == "/" || result.Text == "-" || result.Text == "%")
            {
                result.Text = "0";
            }
            else
            {
                result.Text += "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = ".";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            decimal n1 = num1;
            decimal n2 = Convert.ToDecimal(result.Text);
            decimal answer;
            switch(operat)
            {
                case "+":
                    answer = n1 + n2;
                    result.Text = answer.ToString();
                    break;
                case "-":
                     answer = n1 - n2;
                     result.Text = answer.ToString();
                     break;
                case "*":
                     answer = n1 * n2;
                     result.Text = answer.ToString();
                     break;
                case "/":
                     answer = n1 / n2;
                     result.Text = answer.ToString();
                     break;
                case "%":
                     answer = n1 % n2;
                     result.Text = answer.ToString();
                     break;
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (result.Text != " " && result.Text != " - " && result.Text != " * " && result.Text != " / " && result.Text != " % ")
            {
                num1 = Convert.ToDecimal(result.Text);

            }
            operat = "+";
            result.Text = "+";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (result.Text != " " && result.Text != " + " && result.Text != " * " && result.Text != " / " && result.Text != " % ")
            {
                num1 = Convert.ToDecimal(result.Text);
                

            }
            operat = "-";
            result.Text = "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (result.Text != " " && result.Text != " - " && result.Text != " * " && result.Text != " / " && result.Text != " + ")
            {
                num1 = Convert.ToDecimal(result.Text);
                
            }
            operat = "%";
            result.Text = "%";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (result.Text != " " && result.Text != " + " && result.Text != " - " && result.Text != " / " && result.Text != " % ")
            {
                num1 = Convert.ToDecimal(result.Text);
                
            }
            operat = "*";
            result.Text = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (result.Text != " " && result.Text != " - " && result.Text != " * " && result.Text != " + " && result.Text != " % ")
            {
                num1 = Convert.ToDecimal(result.Text);
                
            }
            operat = "/";
            result.Text = "/";
        }
      

        private void button21_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result.Text = "ON";
        }
    }
    
}