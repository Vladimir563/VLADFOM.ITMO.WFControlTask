using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class IngeneersCalc : SimpleCalculator.CalcUI
    {
        SquareEquationForm equationForm;
        public IngeneersCalc()
        {
            InitializeComponent();
        }

        private void cmdXToThePowerOfY_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePow);
        }

        private void cmdSqrtX_Click(object sender, EventArgs e)
        {
            CalcEngine.EngeneerCalcOperation(CalcEngine.Operator.eSqrt);
        }

        private void cmdGetReverseValue_Click(object sender, EventArgs e)
        {
            CalcEngine.EngeneerCalcOperation(CalcEngine.Operator.eReverse);
        }

        private void cmdSquareOfX_Click(object sender, EventArgs e)
        {
            CalcEngine.EngeneerCalcOperation(CalcEngine.Operator.eSquare);
        }

        private void cmdFactorialX_Click(object sender, EventArgs e)
        {
            CalcEngine.EngeneerCalcOperation(CalcEngine.Operator.eFactorial);
        }

        private void cmdSquareRootX_Click(object sender, EventArgs e)
        {
            CalcEngine.EngeneerCalcOperation(CalcEngine.Operator.eCubeRoot);
        }

        private void cmdSquareEquation_Click(object sender, EventArgs e)
        {
            SquareEquationForm equationForm = new SquareEquationForm();
            equationForm.Show();
        }

        private void IngeneersCalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxFactorialResult.Text = "0";

            if (!backgroundWorker1.IsBusy) 
            {
                labelFactStatus.Text = "Processing...";
                labelFactStatus.ForeColor = Color.Black;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);
            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
            }
            else 
            {
                e.Result = Factorial(int.Parse(OutputDisplay.Text));
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                labelFactStatus.Text = "Canceled";
            }
            else 
            {
                textBoxFactorialResult.Text = e.Result.ToString();
                labelFactStatus.Text = "Finished";
            }
            
        }

        private void cmdFactorialCalculationCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        public static long Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }


        private void KeyClear_Click_1(object sender, EventArgs e)
        {
            textBoxFactorialResult.Text = "0";
        }
    }
}
