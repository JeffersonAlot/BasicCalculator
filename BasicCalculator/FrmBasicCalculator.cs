using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);

            if (cbOperator.Text == "+")
            {
                lbResult.Text = BasicComputation.Addition(num1, num2).ToString();
            } 
            else if (cbOperator.Text == "-")
            {
                lbResult.Text = BasicComputation.Subtraction(num1, num2).ToString();
            }
            else if (cbOperator.Text == "*")
            {
                lbResult.Text = BasicComputation.Multiplication(num1, num2).ToString();
            }
            else if (cbOperator.Text == "/")
            {
                lbResult.Text = BasicComputation.Division(num1, num2).ToString();
            }
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }
    }
}
