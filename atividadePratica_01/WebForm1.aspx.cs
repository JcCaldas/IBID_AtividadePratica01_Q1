using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atividadePratica_01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlOperacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {

            //Sem escolha
            if(ddlOperacoes.SelectedValue == "0")
            {
                lblResultadoNaTela.Text = "Escolha uma das operações!";
            }

            //Soma
            if (ddlOperacoes.SelectedValue == "1")
            {
                double n1 = Convert.ToDouble(txtPrimeiroNumero.Text);
                double n2 = Convert.ToDouble(txtSegundoNumero.Text);
                double resultado = n1 + n2;
                lblResultadoNaTela.Text = $"{txtPrimeiroNumero.Text} + {txtSegundoNumero.Text} = {resultado}";
            }

            //Subtração
            if (ddlOperacoes.SelectedValue == "2")
            {
                double n1 = Convert.ToDouble(txtPrimeiroNumero.Text);
                double n2 = Convert.ToDouble(txtSegundoNumero.Text);
                double resultado = n1 - n2;
                lblResultadoNaTela.Text = $"{txtPrimeiroNumero.Text} - {txtSegundoNumero.Text} = {resultado}";
            }

            //Divisão
            if (ddlOperacoes.SelectedValue == "3")
            {
                double n1 = Convert.ToDouble(txtPrimeiroNumero.Text);
                double n2 = Convert.ToDouble(txtSegundoNumero.Text);
                double resultado = n1 / n2;
                lblResultadoNaTela.Text = $"{txtPrimeiroNumero.Text} / {txtSegundoNumero.Text} = {resultado}";
            }

            //Multiplicação
            if (ddlOperacoes.SelectedValue == "4")
            {
                double n1 = Convert.ToDouble(txtPrimeiroNumero.Text);
                double n2 = Convert.ToDouble(txtSegundoNumero.Text);
                double resultado = n1 * n2;
                lblResultadoNaTela.Text = $"{txtPrimeiroNumero.Text} * {txtSegundoNumero.Text} = {resultado}";
            }

        }
    }
}