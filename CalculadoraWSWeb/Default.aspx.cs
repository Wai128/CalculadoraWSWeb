using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraWSWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        //global
        WS_servicio_web.CalculatorSoapClient WS = new WS_servicio_web.CalculatorSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_sumar_Click(object sender, EventArgs e)
        {
            if ((this.Txt_numero1.Text != "") && (this.Txt_numero2.Text != ""))
            {
                this.Lb_numero.Text = "";

            Lb_resultado.Text = WS.Add(Convert.ToInt32(Txt_numero1.Text), Convert.ToInt32(Txt_numero2.Text)).ToString();

            }
            else
            {
             this.Lb_numero.Text = "Por favor, ingresar un numero en los campos correspondientes para realizar la operacion";
            }

         }

        protected void Btn_Restar_Click(object sender, EventArgs e)
        {
              if ((this.Txt_numero1.Text != "") && (this.Txt_numero2.Text != ""))
             {
                this.Lb_numero.Text = "";

                Lb_resultado.Text = WS.Subtract(Convert.ToInt32(Txt_numero1.Text), Convert.ToInt32(Txt_numero2.Text)).ToString();

             }
              else
              {
                  this.Lb_numero.Text = "Por favor, ingresar un numero en los campos correspondientes para realizar la operacion";
              }
        }

        protected void Btn_multiplicar_Click(object sender, EventArgs e)
        {

             if ((this.Txt_numero1.Text != "") && (this.Txt_numero2.Text != ""))
        {
            this.Lb_numero.Text = "";
            Lb_resultado.Text = WS.Multiply(Convert.ToInt32(Txt_numero1.Text), Convert.ToInt32(Txt_numero2.Text)).ToString();
        }
             else
             {
                 this.Lb_numero.Text = "Por favor, ingresar un numero en los campos correspondientes para realizar la operacion";
             }
        
        
        
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((this.Txt_numero1.Text != "") && (this.Txt_numero2.Text != ""))
        {
            this.Lb_numero.Text = "";
            
         
            
                if (this.Txt_numero2.Text == "0")
            {
                this.Lb_resultado.Text = "No se permite ingresar el numero 0 en el divisor";
            }
            else
            {
                Lb_resultado.Text = WS.Divide(Convert.ToInt32(Txt_numero1.Text), Convert.ToInt32(Txt_numero2.Text)).ToString();

            }

        }
            else
            {
                this.Lb_numero.Text = "Por favor, ingresar un numero en los campos correspondientes para realizar la operacion";
            }

        
        
        }
    }
}