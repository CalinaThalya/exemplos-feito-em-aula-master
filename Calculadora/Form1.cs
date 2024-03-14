using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frm_calculadora : Form
    {
        public frm_calculadora()
        {
            InitializeComponent();
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            decimal valor1 = Convert.ToDecimal(txt_numero1.Text == "" ? "0" : txt_numero1.Text);
            decimal valor2 = Convert.ToDecimal(txt_numero2.Text == "" ? "0" : txt_numero2.Text);

            string resposta = $"A Soma é: {valor1 + valor2}";

            lbl_resultado.Text = resposta;
            MessageBox.Show(resposta);
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            decimal valor1 = 0;
            decimal valor2 = 0;

            if (txt_numero1.Text != "")
                valor1 = Convert.ToDecimal(txt_numero1.Text);

            if (txt_numero2.Text != "")
                valor2 = Convert.ToDecimal(txt_numero2.Text);

            string resposta = $"A Subtracao é: {valor1 - valor2}";

            lbl_resultado.Text = resposta;
            MessageBox.Show(resposta);
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_numero1.Text = string.Empty;
            txt_numero2.Text = string.Empty;
            lbl_resultado.Text = "Resposta";
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            decimal valor1 = Convert.ToDecimal(txt_numero1.Text == "" ? "0" : txt_numero1.Text);
            decimal valor2 = Convert.ToDecimal(txt_numero2.Text == "" ? "0" : txt_numero2.Text);

            string resposta = $"A Multiplicação é: {valor1 * valor2}";

            lbl_resultado.Text = resposta;
            MessageBox.Show(resposta);
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            decimal valor1 = Convert.ToDecimal(txt_numero1.Text == "" ? "0" : txt_numero1.Text);
            decimal valor2 = Convert.ToDecimal(txt_numero2.Text == "" ? "1" : txt_numero2.Text);

            string resposta = $"A Divisao é: {valor1 / valor2}";

            lbl_resultado.Text = resposta;
            MessageBox.Show(resposta);
        }
    }
}
