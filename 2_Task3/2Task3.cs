using MaterialSkin.Controls;

namespace _2_Task3
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fibTextBox_TextChanged(object sender, EventArgs e)
        {
            btnCalcFib.Enabled = true;
        }

        private void expTextBox_TextChanged(object sender, EventArgs e)
        {
            if (baseTextBox.Text != null) { 
                btnCalcPow.Enabled = true;
            }
        }

        private void btnCalcFib_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(fibTextBox.Text);
                fibResTextBox.Text = fib(n).ToString();
                fibResTextBox.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnCalcPow_Click(object sender, EventArgs e)
        {
            try
            {
                int b = int.Parse(baseTextBox.Text);
                int exponent = int.Parse(expTextBox.Text);
                powResTextBox.Text = exp(b, exponent).ToString();
                powResTextBox.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public int fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return fib(n - 1) + fib(n - 2);
        }

        public double exp(int b, int e)
        {
            if (e == 0) return 1;
            if (e < 0) return 1 / exp(b, -e);
            return b * exp(b, e - 1);
        }
    }
}
