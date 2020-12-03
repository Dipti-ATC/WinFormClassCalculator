using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormClassCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Num1, Num2, Output;
            Num1 = Convert.ToInt32(txtFirstNum.Text);
            Num2 = Convert.ToInt32(txtSecondNum.Text);
            Output = Num1 + Num2;
            txtOutput.Text = Output.ToString();

        }

        
    }
}
