namespace Basic_calcooo
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String op = "";
        bool op_pressed = false;
        bool equal_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if ((result.Text == "0") || (op_pressed) || (equal_pressed))
                result.Clear();
            equal_pressed = false;
            op_pressed = false;
            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                equal.PerformClick();
                op_pressed = true;
                op = b.Text;
                equation.Text = value + " " + op;
            }
            else if (b.Text == "exp")
            {
                op = b.Text;
                value = Double.Parse(result.Text);
                op_pressed = true;
                equation.Text = value + "^";
            }
            else if (b.Text == "root")
            {
                op = b.Text;
                value = Double.Parse(result.Text);
                op_pressed = true;
                equation.Text = value + " yroot ";
            }
            else
            {
                op = b.Text;
                value = Double.Parse(result.Text);
                op_pressed = true;
                equation.Text = value + " " + op;
            }
        }

        private void del_char(object sender, EventArgs e)
        {
            if (result.Text.Length == 1)
                result.Text = "0";
            else
                result.Text = result.Text.Remove(result.Text.Length - 1);
        }
        private void change_sign(object sender, EventArgs e)
        {
            if (result.Text == "0")
                result.Text = "0";
            else
                result.Text = (Double.Parse(result.Text) * -1).ToString();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (op)
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
                case "exp":
                    result.Text = (Math.Pow(value, Double.Parse(result.Text))).ToString();
                    break;
                case "root":
                    result.Text = (Math.Pow(value, 1.0 / Double.Parse(result.Text))).ToString();
                    break;
                default:
                    break;
            }
            equal_pressed = true;
            value = Double.Parse(result.Text);
            op = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    num1.PerformClick();
                    break;
                case "2":
                    num2.PerformClick();
                    break;
                case "3":
                    num3.PerformClick();
                    break;
                case "4":
                    num4.PerformClick();
                    break;
                case "5":
                    num5.PerformClick();
                    break;
                case "6":
                    num6.PerformClick();
                    break;
                case "7":
                    num7.PerformClick();
                    break;
                case "8":
                    num8.PerformClick();
                    break;
                case "9":
                    num9.PerformClick();
                    break;
                case "0":
                    num0.PerformClick();
                    break;
                case "+":
                    plus.PerformClick();
                    break;
                case "-":
                    minus.PerformClick();
                    break;
                case "*":
                    mult.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case ".":
                    dot.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                case "ENTER":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }

    }
}