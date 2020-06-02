using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Calc C;
        int k;
        Memory M;
        public Form1()
        {
            InitializeComponent();

            C = new Calc();

            labelNumber.Text = "0";

        }

        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (labelNumber.Text.IndexOf("∞") != -1)
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (labelNumber.Text[0] == '0' && (labelNumber.Text.IndexOf(",") != 1))
                labelNumber.Text = labelNumber.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (labelNumber.Text[0] == '-')
                if (labelNumber.Text[1] == '0' && (labelNumber.Text.IndexOf(",") != 2))
                    labelNumber.Text = labelNumber.Text.Remove(1, 1);
        }

        private bool CanPress()
        {
            if (!buttonMult.Enabled)
                return false;

            if (!buttonDiv.Enabled)
                return false;

            if (!buttonPlus.Enabled)
                return false;

            if (!buttonMinnum.Enabled)
                return false;

            if (!buttonSqrt.Enabled)
                return false;

            if (!buttonDegreeY.Enabled)
                return false;

            return true;
        }
        private void FreeButtons()
        {
            buttonMult.Enabled = true;
            buttonDiv.Enabled = true;
            buttonPlus.Enabled = true;
            buttonMMinus.Enabled = true;
            buttonSqrt.Enabled = true;
            buttonDegreeY.Enabled = true;
            buttonSqrtX.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";
            C.Clear_A();
            FreeButtons();
            k = 0;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text[0] == '-')
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            else
                labelNumber.Text = "-" + labelNumber.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if ((labelNumber.Text.IndexOf(",") == -1) && (labelNumber.Text.IndexOf("∞") == -1))
                labelNumber.Text += ",";
        }
        private void buttonNum0_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "0";
            CorrectNumber();
        }
        private void buttonNum1_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "1";
            CorrectNumber();
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "2";
            CorrectNumber();
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "3";
            CorrectNumber();
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "4";
            CorrectNumber();
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "5";
            CorrectNumber();
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "6";
            CorrectNumber();
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "7";
            CorrectNumber();
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "8";
            CorrectNumber();
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "9";
            CorrectNumber();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (!buttonMult.Enabled)
                labelNumber.Text = C.Multiplication(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonDiv.Enabled)
                labelNumber.Text = C.Division(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonPlus.Enabled)
                labelNumber.Text = C.Sum(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonMMinus.Enabled)
                labelNumber.Text = C.Subtraction(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonSqrt.Enabled)
                labelNumber.Text = C.SqrtX(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonDegreeY.Enabled)
                labelNumber.Text = C.DegreeY(Convert.ToDouble(labelNumber.Text)).ToString();

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMult.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonDiv.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonPlus.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonMinnum_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMinnum.Enabled = false;

                labelNumber.Text = "0";
            }
        }


        private void buttonDegreeY_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonDegreeY.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonSqrtX_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));
                buttonSqrtX.Enabled = false;
                labelNumber.Text = "0";
                FreeButtons();
            }
        }
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = C.Sqrt().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = C.Square().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }
        private void buttonFact_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if ((Convert.ToDouble(labelNumber.Text) == (int)(Convert.ToDouble(labelNumber.Text))) &&
                    ((Convert.ToDouble(labelNumber.Text) >= 0.0)))
                {
                    C.Put_A(Convert.ToDouble(labelNumber.Text));
                    labelNumber.Text = C.Fact().ToString();
                    C.Clear_A();
                    FreeButtons();
                }
                else
                    MessageBox.Show("Число должно быть >= 0 и целым!");
            }
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            M.M_Sum(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            M.M_Subtraction(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMMult_Click(object sender, EventArgs e)
        {
            M.M_Multiplication(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMDiv_Click(object sender, EventArgs e)
        {
            M.M_Division(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMRC_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                k++;

                if (k == 1)
                    labelNumber.Text = M.MemoryShow().ToString();

                if (k == 2)
                {
                    M.MemoryClear();
                    labelNumber.Text = "0";

                    k = 0;
                }
            }
        }
    }

    //Интерфейс для основных функций калькулятора
    interface ICalc
    {
        void Put_A(double a); //сохранить а
        void Clear_A();
        double Division(double b);
        double Sum(double b);
        double SqrtX(double b);
        double DegreeY(double b);
        double Subtraction(double b);
        double Sqrt();
        double Square();
        double Fact();   
    }

    //Интерфейс для MRC
    interface ICalcm
    {
        double MemoryShow();
        void MemoryClear();
        void M_Multiplication(double b);
        void M_Division(double b);
        void M_Sum(double b);
        void M_Subtraction(double b);
    }



    public class Memory : ICalcm
    {
        private double memory = 0;
        //показать содержимое регистра мамяти
        public double MemoryShow()
        {
            return memory;
        }

        //стереть содержимое регистра мамяти
        public void MemoryClear()
        {
            memory = 0.0;
        }

        //* / + - к регистру памяти
        public void M_Multiplication(double b)
        {
            memory *= b;
        }

        public void M_Division(double b)
        {
            memory /= b;
        }

        public void M_Sum(double b)
        {
            memory += b;
        }

        public void M_Subtraction(double b)
        {
            memory -= b;
        }

    }

        public class Calc : ICalc
        {
        private double a = 0;
        public void Put_A(double a)
        {
            this.a = a;
        }
        public void Clear_A()
        {
            a = 0;
        }

        public double Division(double b)
        {
            return a / b;
        }
        public double Sum(double b)
        {
            return a + b;
        }
        public double Subtraction(double b)
        {
            return a - b;
        }
        public double Multiplication(double b)
        {
            return a * b;
        }
        public double SqrtX(double b)
        {
            return Math.Pow(a, 1 / b);
        }
        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt()
        {
            return Math.Sqrt(a);
        }

        public double Square()
        {
            return Math.Pow(a, 2);
        }

        public double Fact()
        {
            double f = 1;
            for (int i = 1; i <= a; i++)
                f *= (double)i;
            return f;
        }
    }
}


