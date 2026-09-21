using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_temperaturas
{
    public partial class Form1 : Form
    {
        //Agregamos un objeto TextBox
        private TextBox objTextBox = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Conversion()
        {
            try
            {
                double grados;
                //Si se escribe en la caja e texto grdos centigrados...
                if(objTextBox == txtCen)
                {
                    grados = Convert.ToDouble(txtCen.Text);
                    txtFah.Text = ((grados * 9/5) + 32).ToString();
                }
                if (objTextBox == txtFah)
                {
                    grados = (Convert.ToDouble(txtFah.Text)-32.0) * 5.0/9.0;
                    txtCen.Text = string.Format("{0:F2}", grados);
                }
            }catch(FormatException)
            {
                txtCen.Text = "0.00";
                txtFah.Text = "32.00";
            }
        }

        private void txtCen_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
            if(e.KeyChar == Convert.ToChar(13))

            {
                //Enter
                e.Handled = true;
                Conversion();
            }
        }

        private void txtFah_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(13))

            {
                //Enter
                e.Handled = true;
                Conversion();
            }
        }
    }
}
