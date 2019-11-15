using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculation obj = new Calculation();
        double operand1 = 0;
        double operand2 = 0;
        string operation = "";
        bool comma = false;    //priznak , - no
        double dec = 1; // dlya veshestv chisla
        double decNum = 0;   // dly decyatichnoy cictemi schsleniya
        double result = 0;
        public double memory;
    
        public MainWindow()
        {
            InitializeComponent();
        }

      
        public void number(ref double op1, ref double op2, ref string oper, int numeral, ref bool fl, ref double dec1)
        {
            if (fl)
            {
                {
                    dec1 *= 10;
                    if (oper == "")
                    {
                        op1 = obj.sumReal(op1,numeral,dec1);     
                        textBox.Text = op1.ToString();
                    }
                    else
                    {
                        op2 = obj.sumReal(op2, numeral, dec1);                 //op2 + (double)numeral / dec1;
                        textBox.Text = op2.ToString();

                    }
                }
            }
            else
            {
                if (oper == "")
                {
                    operand1 = obj.sumRealPoint(op1, numeral, dec1);            //(op1 * 10) + (double)numeral / dec1;
                    textBox.Text = op1.ToString();
                }
                else
                {
                    op2 = obj.sumRealPoint(op2, numeral, dec1);                 //(op2 * 10) + numeral / dec1;
                    textBox.Text = op2.ToString();
                }
            }
        }
        //----------------------------------------------------------------------------------------------
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            number(ref operand1, ref operand2, ref operation, 1, ref comma, ref dec);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            number(ref operand1, ref operand2, ref operation, 2, ref comma, ref dec);

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            number(ref operand1, ref operand2, ref operation, 3, ref comma, ref dec);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            number(ref operand1, ref operand2, ref operation, 4, ref comma, ref dec);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            number(ref operand1, ref operand2, ref operation, 5, ref comma, ref dec);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            number(ref operand1, ref operand2, ref operation, 6, ref comma, ref dec);
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            number(ref operand1, ref operand2, ref operation, 7, ref comma, ref dec);
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            number(ref operand1, ref operand2, ref operation, 8, ref comma, ref dec);
        }

        private void Button0_Click_1(object sender, RoutedEventArgs e)
        {
            number(ref operand1, ref operand2, ref operation, 0, ref comma, ref dec);
        }

        private void Button9_Click_1(object sender, RoutedEventArgs e)
        {
            number(ref operand1, ref operand2, ref operation, 9, ref comma, ref dec);
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                comma = false;
                operation = "/";
                dec = 1;
            }
            else
            {
                if (operand2 == 0)
                {
                    operand1 = Convert.ToDouble(textBox.Text);
                    operation = "/";
                }
                else
                {

                    Equally_my(ref operand1, ref operand2, ref result, ref operation);
                    operand1 = result;
                    operand2 = 0;
                    comma = false;
                    dec = 1;
                    operation = "/";
                }
            }
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                comma = false;
                operation = "+";
                dec = 1;
            }
            else
            {
                if (operand2 == 0)
                {
                    operand1 = Convert.ToDouble(textBox.Text);
                    operation = "+";
                }
                else
                {

                    Equally_my(ref operand1, ref operand2, ref result, ref operation);
                    operand1 = result;
                    operand2 = 0;
                    comma = false;
                    dec = 1;
                    operation = "+";
                }
            }
        }

        private void ButtonMult_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                comma = false;
                operation = "*";
                dec = 1;
            }
            else
            {
                if (operand2 == 0)
                {
                    operand1 = Convert.ToDouble(textBox.Text);
                    operation = "*";
                }
                else
                {

                    Equally_my(ref operand1, ref operand2, ref result, ref operation);
                    operand1 = result;
                    operand2 = 0;
                    comma = false;
                    dec = 1;
                    operation = "*";
                }
            }
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                comma = false;
                operation = "-";
                dec = 1;
            }
            else
            {
                if (operand2 == 0)
                {
                    operand1 = Convert.ToDouble(textBox.Text);
                    operation = "-";
                }
                else
                {

                    Equally_my(ref operand1, ref operand2, ref result, ref operation);
                    operand1 = result;



                    operand2 = 0;
                    comma = false;
                    dec = 1;
                    operation = "-";
                }
            }

        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            operand1 = 0;
            operand2 = 0;
            operation = "";
            textBox.Text = "0";
            dec = 1;
            comma = false;
        }

        private void ButtonBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (textBox.Text.Length != 1)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    operand1 = Convert.ToDouble(textBox.Text);
                }
                else
                {
                    operand1 = 0;
                    textBox.Text = "0";
                }
            }
            else
            {
                if (textBox.Text.Length != 1)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    operand2 = Convert.ToDouble(textBox.Text);
                }
                else
                {
                    operand2 = 0;
                    textBox.Text = "0";
                }
            }
           
        }
        private void ButtonPlMn_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                operand1 *= -1;
                textBox.Text = operand1.ToString();
            }
            else
            {
                operand2 *= -1;
                textBox.Text = operand2.ToString();
            }
        }

        //------------------------------------------------------------------------
        public void Equally_my(ref double op1, ref double op2, ref double result, ref string oper)
        {
            switch (oper)
            {
                case "+":
                    {
                        result = op1 + op2;
                        this.textBox.Text = result.ToString();
                        break;
                    }
                case "-":
                    {
                        result = op1 - op2;
                        this.textBox.Text = result.ToString();
                        break;
                    }
                case "*":
                    {
                        result = op1 * op2;
                        this.textBox.Text = result.ToString();
                        break;
                    }
                case "/":
                    {
                        result = op1 / op2;
                        this.textBox.Text = result.ToString();
                        break;

                    }
                case "%":
                    {
                        this.textBox.Text = (op1 % op2).ToString();
                        break;

                    }
                case "√":
                    {
                        int indexOfRoot = this.textBox.Text.IndexOf('√');
                        int exponent = (int)op1;

                        string piece = this.textBox.Text.Substring(indexOfRoot + 1);

                        if (double.TryParse(piece, out op2))
                        {
                            double SqrtN = Math.Pow(op2, 1.0 / exponent);
                            this.textBox.Text = SqrtN.ToString();
                        }
                        else
                        {
                            this.textBox.Text = "Error";
                        }
                        break;
                    }
                case "^":
                    {
                        this.textBox.Text = Math.Pow(op1, op2).ToString();
                        break;

                    }
            }
        }
        private void ButtonEqually_Click(object sender, RoutedEventArgs e)
        {
            Equally_my(ref operand1, ref operand2, ref result, ref operation);
            operand1 = result;
            operand2 = 0;
            comma = false;
            dec = 1;
        }

        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "" && !comma)
            {
                textBox.Text = operand1.ToString() + ',';
                comma = true;
            }
            else
            {
                if (!comma)
                {
                    textBox.Text = operand2.ToString() + ',';
                    comma = true;
                }
            }
        }
        private void ButtonBin_Click(object sender, RoutedEventArgs e)
        {
            decNum = operand1;
            if (operation == "")
            {
                comma = false;
                dec = 1;
                if (Math.Abs(operand1 - (int)operand1) < 0.0000001)
                {
                    binary((int)operand1);
                }
                else
                    textBox.Text = "Error";
            }
        }
     
      
        public void binary(int n)
        {
            obj.strF = "";
            textBox.Clear();
            textBox.Text = obj.binaryFunction(n);

        }
        public void oct(int n)
        {
            obj.strF = "";
            textBox.Clear();
            textBox.Text = obj.octFunction(n);

        }
        public bool getHex(int num)
        {
            if (num > 9 && num < 16)
                return true;
            else
                return false;
        }
      
        public void hex(int n)
        {
            obj.strF = "";
            textBox.Clear();
            textBox.Text = obj.hexFunction(n);
        }

        private void ButtonOct_Click(object sender, RoutedEventArgs e)
        {
            decNum = operand1;
            if (operation == "")
            {
                comma = false;
                dec = 1;
                if (Math.Abs(operand1 - (int)operand1) < 0.0000001)
                {
                    oct((int)operand1);
                }
                else
                    textBox.Text = "Error";
            }
        }

        private void ButtonDec_Click(object sender, RoutedEventArgs e)
        {
            decNum = operand1;
            if (operation == "")
            {
                comma = false;
                dec = 1;
                if (Math.Abs(operand1 - (int)operand1) < 0.0000001)
                {
                    textBox.Text = decNum.ToString();
                }
                else
                    textBox.Text = "Error";
            }
        }

        private void ButtonHec_Click(object sender, RoutedEventArgs e)
        {
            decNum = operand1;
            textBox.Text = "";
            if (operation == "")
            {
                comma = false;
                dec = 1;
                if (Math.Abs(operand1 - (int)operand1) < 0.0000001)
                {
                    hex((int)operand1);
                }
                else
                    textBox.Text = "Error";
            }
        }

        private void ButtonMplus_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
                memory += 0;
            else
            {
                memory += double.Parse(textBox.Text);
            }
            buttonMR.IsEnabled = true;
            buttonMC.IsEnabled = true;
        }

        private void ButtonMminus_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
                memory -= 0;
            else
            {
                memory -= double.Parse(textBox.Text);
            }
            buttonMR.IsEnabled = true;
            buttonMC.IsEnabled = true;
        }

        private void ButtonMC_Click(object sender, RoutedEventArgs e)
        {
            memory = 0;
            buttonMC.IsEnabled = false;
            buttonMR.IsEnabled = false;
        }

        private void ButtonMR_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
                operand1 = memory;
            else
                operand2 = memory;
            textBox.Text = Convert.ToString(memory);
        }

        public void ButtonPi_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                operand1 = Math.PI;
                textBox.Text = operand1.ToString();
            }
            else
            {
                operand2 = Math.PI;
                textBox.Text = operand2.ToString();
            }
        }

        private void ButtonCos_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            if (operation == "")
            {
                operand1 = Math.Cos(operand1);
                textBox.Text = operand1.ToString();
            }
            else
            {
                operand2 = Math.Cos(operand2);
                textBox.Text = operand2.ToString();
            }
        }

        private void ButtonMod_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                comma = false;
                operation = "%";
                dec = 1;
            }
            else
            {
                operand1 = Convert.ToDouble(textBox.Text);
                operation = "%";
            }
        }

        private void ButtonFact_Click(object sender, RoutedEventArgs e)
        {
            double fact = 1;
            textBox.Text = "";
            if (operand1 >= 0)
            {
                for (int i = 1; i <= operand1; i++)
                {
                    fact *= i;
                }

                if (operation == "")
                {
                    operand1 = fact;
                    textBox.Text = operand1.ToString();
                }
                else
                {
                    operand2 = fact;
                    textBox.Text = operand2.ToString();
                }
            }
            else textBox.Text = "Error";
        }


        private void Buttonlog_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                operand1 = Math.Log(operand1);
                textBox.Text = operand1.ToString();
            }
            else
            {
                operand2 = Math.Log(operand2);
                textBox.Text = operand2.ToString();
            }


        }

        private void ButtonExp_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            if (operation == "")
            {
                operand1 = Math.Tan(operand1);
                textBox.Text = operand1.ToString();
            }
            else
            {
                operand2 = Math.Tan(operand2);
                textBox.Text = operand2.ToString();
            }

        }

        private void ButtonDivX_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            if (operand1 > 0)
            {

                if (operation == "")
                {
                    operand1 = 1 / operand1;
                    textBox.Text = operand1.ToString();
                }
                else
                {
                    operand2 = 1 / operand2;
                    textBox.Text = operand2.ToString();
                }
            }
            else textBox.Text = "Error";
        }

        private void ButtonXY_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                comma = false;
                operation = "^";
                dec = 1;
            }
            else
            {
                operand1 = Convert.ToDouble(textBox.Text);
                operation = "^";
            }
        }

        private void ButtonX3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                operand1 = Math.Pow(operand1, 3);
                textBox.Text = operand1.ToString();
            }
            else
            {
                operand2 = Math.Pow(operand2, 3);
                textBox.Text = operand2.ToString();
            }
        }

        private void ButtonX2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                operand1 = Math.Pow(operand1, 2);
                textBox.Text = operand1.ToString();
            }
            else
            {
                operand2 = Math.Pow(operand2, 2);
                textBox.Text = operand2.ToString();
            }
        }

        private void ButtonSin_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                operand1 = Math.Sin(operand1);
                textBox.Text = operand1.ToString();
            }
            else
            {
                operand2 = Math.Sin(operand2);
                textBox.Text = operand2.ToString();
            }
        }

        private void ButtonMLn_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                operand1 = Math.Log10(operand1);
                textBox.Text = operand1.ToString();
            }
            else
            {
                operand2 = Math.Log10(operand2);
                textBox.Text = operand2.ToString();
            }
        }

        private void ButtonSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBox.Text, out operand1))
            {
                if (operation == "")
                {
                    operand1 = Math.Sqrt(operand1);
                    textBox.Text = operand1.ToString();
                }
                else
                {
                    operand2 = Math.Sqrt(operand2);
                    textBox.Text = operand2.ToString();
                }
            }
            else
            {
                textBox.Text = "Error";
            }
        }

        private void ButtonsqrtN_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBox.Text, out operand1))
            {
                operation = "√";
                textBox.Text += "√";
            }
            else
            {
                textBox.Text = "Error";
            }
        }

        private void Buttonsgrt3_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBox.Text, out operand1))
            {
                if (operation == "")
                {
                    operand1 = Math.Pow(operand1, 1.0 / 3.0);
                    textBox.Text = operand1.ToString();
                }
                else
                {
                    operand2 = Math.Pow(operand1, 1.0 / 3.0);
                    textBox.Text = operand2.ToString();
                }
            }
            else
            {
                textBox.Text = "Error";
            }
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            if (operand1 != 0 && operand2 != 0)
            {
                operand1 = operand2 = 0;
                textBox.Text = "0";
                comma = false;
                dec = 1;
            }
        }

        private void Button10X_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                operand1 = 10 * operand1;
                textBox.Text = operand1.ToString();
            }
            else
            {
                operand2 = 10 * operand2;
                textBox.Text = operand2.ToString();
            }

        }

        private void ButtonPr_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                operand1 = 0;
                textBox.Text = operand1.ToString();
            }
            else
            {
                operand2 = (operand2) / 100.0;
            }
        }
    }
} 

