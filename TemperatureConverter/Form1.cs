using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class TemperatureConverter : Form
    {
        //Змінні
        int Temp;
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void TemperatureConverter_Load(object sender, EventArgs e)
        {
            txtConvertedTemp.Text = "0";
            txtTemp.Text = "0";

        }

        private void txtTemp_Click(object sender, EventArgs e)
        {
            txtTemp.SelectAll();
        }

        private void rbFromC_CheckedChanged(object sender, EventArgs e)
        {
            lblConvertFrom.Text = "C";
        }

        private void rbFromK_CheckedChanged(object sender, EventArgs e)
        {
            lblConvertFrom.Text = "K";
        }

        private void rbFromF_CheckedChanged(object sender, EventArgs e)
        {
            lblConvertFrom.Text = "F";
        }

        private void rbToC_CheckedChanged(object sender, EventArgs e)
        {
            lblConvertTo.Text = "C";
        }

        private void rbToK_CheckedChanged(object sender, EventArgs e)
        {
            lblConvertTo.Text = "K";
        }

        private void rbToF_CheckedChanged(object sender, EventArgs e)
        {
            lblConvertTo.Text = "F";
        }

        private void txtTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                return;
            }
            MessageBox.Show("Неправильний символ!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtTemp.SelectAll();
            e.Handled = true;
        }

        private void txtTemp_TextChanged(object sender, EventArgs e)
        {
            Temp = Convert.ToInt32(txtTemp.Text);
        }
        private void ConvertTemp(int Temp)
        {
            if(rbFromC.Checked)
            {
                if(rbToC.Checked)
                    txtConvertedTemp.Text = Convert.ToString(Temp);
                else if(rbToK.Checked)
                    txtConvertedTemp.Text = Convert.ToString(Temp + 273);
                else if (rbToF.Checked)
                    txtConvertedTemp.Text = Convert.ToString(Convert.ToInt32((Temp*9/5)+32));
            }
            else if(rbFromK.Checked)
            {
                if (rbToC.Checked)
                    txtConvertedTemp.Text = Convert.ToString(Temp-273);
                else if (rbToK.Checked)
                    txtConvertedTemp.Text = Convert.ToString(Temp);
                else if (rbToF.Checked)
                    txtConvertedTemp.Text = Convert.ToString(Convert.ToInt32(((Temp-273) * 9 / 5) + 32));
            }
            else if (rbFromF.Checked)
            {
                if (rbToC.Checked)
                    txtConvertedTemp.Text = Convert.ToString(Convert.ToInt32((Temp-32)*5/9));
                else if (rbToK.Checked)
                    txtConvertedTemp.Text = Convert.ToString(Convert.ToInt32(((Temp-32)*5/9))+273);
                else if (rbToF.Checked)
                    txtConvertedTemp.Text = Convert.ToString(Temp);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertTemp(Temp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
