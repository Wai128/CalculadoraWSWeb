using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace calculadoraWSdesktop
{

   
    public partial class Form1 : Form
    {
        // global
        ServiceReference1.CalculatorSoapClient Ws = new ServiceReference1.CalculatorSoapClient();
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Lb_numero.Enabled = false;
        }

       
    

        private void txt_numero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_numero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_sumar_Click_2(object sender, EventArgs e)
        {
            if ((this.txt_numero1.Text != "") && (this.txt_numero2.Text != ""))
            {
                this.Lb_numero.Text = "";
                this.Lb_numero.Enabled = false;

                lb_resultado.Text = Ws.Add(Convert.ToInt32(txt_numero1.Text), Convert.ToInt32(this.txt_numero2.Text)).ToString();

            }
            else
            {
                this.Lb_numero.Enabled = true;
                this.Lb_numero.Text = "Por favor, ingresar un numero en los campos correspondientes para realizar la operacion";
            }
        }

        private void btn_restar_Click_1(object sender, EventArgs e)
        {
            if ((this.txt_numero1.Text != "") && (this.txt_numero2.Text != ""))
            {
                this.Lb_numero.Text = "";
                this.Lb_numero.Enabled = false;

                lb_resultado.Text = Ws.Subtract(Convert.ToInt32(txt_numero1.Text), Convert.ToInt32(this.txt_numero2.Text)).ToString();

            }
            else
            {
                this.Lb_numero.Enabled = true;
                this.Lb_numero.Text = "Por favor, ingresar un numero en los campos correspondientes para realizar la operacion";
            }

        }

        private void btn_multiplicar_Click_1(object sender, EventArgs e)
        {
            if ((this.txt_numero1.Text != "") && (this.txt_numero2.Text != ""))
            {
                this.Lb_numero.Text = "";
                this.Lb_numero.Enabled = false;

                lb_resultado.Text = Ws.Multiply(Convert.ToInt32(txt_numero1.Text), Convert.ToInt32(this.txt_numero2.Text)).ToString();

            }
            else
            {
                this.Lb_numero.Enabled = true;
                this.Lb_numero.Text = "Por favor, ingresar un numero en los campos correspondientes para realizar la operacion";
            }
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            if ((this.txt_numero1.Text != "") && (this.txt_numero2.Text != ""))
            {
                this.Lb_numero.Text = "";
                this.Lb_numero.Enabled = false;

                if (this.txt_numero2.Text == "0")
                {
                    this.lb_resultado.Text = "No se permite ingresar el numero 0 en el divisor";
                }
                else
                {
                    this.lb_resultado.Text = Ws.Divide(Convert.ToInt32(txt_numero1.Text), Convert.ToInt32(this.txt_numero2.Text)).ToString();

                }

            }
            else
            {
                this.Lb_numero.Text = "Por favor, ingresar un numero en los campos correspondientes para realizar la operacion";
            }


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
          
        }
    }
}
