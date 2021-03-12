using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio4_a171300
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        Calculator.WebService1SoapClient calcular = new Calculator.WebService1SoapClient();

        protected void Button1_Click(object sender, EventArgs e)
        {
           // Calculator.WebService1SoapClient calcular = new Calculator.WebService1SoapClient();
            TextBox7.Text = calcular.cuadrado(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox6.Text = calcular.triangulo(Convert.ToDouble(TextBox3.Text), Convert.ToDouble(TextBox4.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox8.Text = calcular.circulo(Convert.ToDouble(TextBox5.Text)).ToString();
        }
    }
}