namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        double result = 0;
        string operation = string.Empty;
        bool operationPending = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate()
        {
            if (operationPending)
            {
                double secondNumber = double.Parse(input);

                switch (operation)
                {
                    case "+":
                        result = result + secondNumber;
                        break;
                    case "-":
                        result = result - secondNumber;
                        break;
                    case "*":
                        result = result * secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result = result / secondNumber;
                            break;
                        }
                        else
                        {
                            textBox1.Text = "Cannot divide by zero";
                            break;
                        }
                }

                textBox1.Text = result.ToString();
                operationPending = false;
                input = string.Empty;
                input = result.ToString();
                secondNumber = 0;
                textBox1.Text = result.ToString();
            }
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void bunnotNum1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBox1.Text = input;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Calculate();
                textBox1.Text = result.ToString();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(input);
            input = string.Empty;
            operationPending = true;
            textBox1.Text = result.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Calculate();
                textBox1.Text = result.ToString();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(input);
            input = string.Empty;
            operationPending = true;
            textBox1.Text = result.ToString();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Calculate();
                textBox1.Text = result.ToString();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(input);
            input = string.Empty;
            operationPending = true;
            textBox1.Text = result.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Calculate();
                textBox1.Text = result.ToString();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(input);
            input = string.Empty;
            operationPending = true;
            textBox1.Text = result.ToString();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            result = 0;
            operation = string.Empty;
            operationPending = false;
            textBox1.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
