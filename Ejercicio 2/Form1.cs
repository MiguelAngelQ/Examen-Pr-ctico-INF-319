namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public int ope = 0, num = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                n = Convert.ToInt32(textBox1.Text);
                num = n;
                ope = 4;
                textBox1.Text = "/";
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            ope = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || textBox1.Text == "+" ||
                    textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/"){
                    textBox1.Text = "1";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "1";
                }
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || textBox1.Text == "+" ||
                    textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                {
                    textBox1.Text = "2";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";
                }
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || textBox1.Text == "+" ||
                    textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                {
                    textBox1.Text = "3";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";
                }
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || textBox1.Text == "+" ||
                    textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                {
                    textBox1.Text = "4";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";
                }
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || textBox1.Text == "+" ||
                    textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                {
                    textBox1.Text = "5";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";
                }
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || textBox1.Text == "+" ||
                    textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                {
                    textBox1.Text = "6";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";
                }
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || textBox1.Text == "+" ||
                    textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                {
                    textBox1.Text = "7";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";
                }
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || textBox1.Text == "+" ||
                    textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                {
                    textBox1.Text = "8";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";
                }
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || textBox1.Text == "+" ||
                    textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                {
                    textBox1.Text = "9";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";
                }
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || textBox1.Text == "+" ||
                    textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                {
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";
                }
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            try
            {
                int num2 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "=";
                
                if (ope == 1)
                {
                    textBox1.Text = (num + num2).ToString();
                    ope = 0;
                }
                else if (ope == 2)
                {
                    textBox1.Text = (num - num2).ToString();
                    ope = 0;
                }
                else if (ope == 3)
                {
                    textBox1.Text = (num * num2).ToString();
                    ope = 0;
                }
                else if (ope == 4)
                {
                    textBox1.Text = (num / num2).ToString();
                    ope = 0;
                }
                else
                {
                    textBox1.Text = num2.ToString();
                }
            }
            catch (Exception error)
            {
                //sw = true;
                textBox1.Text = "ERROR";
            }
            /*if (!sw) {
                textBox1.Text = num.ToString();
                
                

            }*/
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length > 1) {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                n = Convert.ToInt32(textBox1.Text);
                num = n;
                ope = 2;
                textBox1.Text = "-";
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                n = Convert.ToInt32(textBox1.Text);
                num = n;
                ope = 3;
                textBox1.Text = "*";
            }
            catch (Exception error)
            {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                n = Convert.ToInt32(textBox1.Text);
                num = n;
                ope = 1;
                textBox1.Text = "+";
            }
            catch (Exception error) {
                textBox1.Text = "ERROR";
                ope = 0;
            }
        }
    }
}