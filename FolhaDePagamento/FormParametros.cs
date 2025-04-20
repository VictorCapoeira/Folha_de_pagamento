using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FolhaDePagamento_Parametros;


namespace FolhaDePagamento
{

    public partial class FormParametros : Form
    {

        BaseDeParametros baseTxt = new BaseDeParametros();
        public FormParametros()
        {
            InitializeComponent();
            cmbAnoParametro.Items.Add(2025);
            cmbAnoParametro.Items.Add(2024);
            cmbAnoParametro.Items.Add(2023);
            cmbAnoParametro.Items.Add(2022);
            cmbAnoParametro.Items.Add(2021);
            cmbAnoParametro.Items.Add(2020);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ano = cmbAnoParametro.SelectedItem.ToString();
            Parametros carregarTxt = baseTxt.CarregarParametrosPorAno(ano);

            txtInssFaixa1.Text = carregarTxt.InssFaixas1.ToString();
            txtInssFaixa2.Text = carregarTxt.InssFaixas2.ToString();
            txtInssFaixa3.Text = carregarTxt.InssFaixas3.ToString();
            txtInssFaixa4.Text = carregarTxt.InssFaixas4.ToString();
            txtInssAliquota1.Text = carregarTxt.InssAliquotas1.ToString();
            txtInssAliquota2.Text = carregarTxt.InssAliquotas2.ToString();
            txtInssAliquota3.Text = carregarTxt.InssAliquotas3.ToString();
            txtInssAliquota4.Text = carregarTxt.InssAliquotas4.ToString();
            txtIrrfFaixa1.Text = carregarTxt.IrrfFaixas1.ToString();
            txtIrrfFaixa2.Text = carregarTxt.IrrfFaixas2.ToString();
            txtIrrfFaixa3.Text = carregarTxt.IrrfFaixas3.ToString();
            txtIrrfFaixa4.Text = carregarTxt.IrrfFaixas4.ToString();
            txtIrrfAliquota1.Text = carregarTxt.IrrfAliquotas1.ToString();
            txtIrrfAliquota2.Text = carregarTxt.IrrfAliquotas2.ToString();
            txtIrrfAliquota3.Text = carregarTxt.IrrfAliquotas3.ToString();
            txtIrrfAliquota4.Text = carregarTxt.IrrfAliquotas4.ToString();
            txtIrrfDeducao1.Text = carregarTxt.IrrfDeducoes1.ToString();
            txtIrrfDeducao2.Text = carregarTxt.IrrfDeducoes2.ToString();
            txtIrrfDeducao3.Text = carregarTxt.IrrfDeducoes3.ToString();
            txtIrrfDeducao4.Text = carregarTxt.IrrfDeducoes4.ToString();
            txtFgts.Text = carregarTxt.Fgts.ToString();
            txtSalarioMinimo.Text = carregarTxt.SalarioMinimo.ToString();


        }

        private void FormParametros_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ano = cmbAnoParametro.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(ano))
            {
                MessageBox.Show("Selecione um ano válido.");
                return;
            }

            // Carrega os parâmetros existentes
            BaseDeParametros baseTxt = new BaseDeParametros();
            Parametros parametrosAntigos = baseTxt.CarregarParametrosPorAno(ano);

            // Atualiza somente os campos que foram editados
            Parametros novoParametro = new Parametros();

            try
            {
                // INSS
                novoParametro.InssFaixas1 = decimal.Parse(txtInssFaixa1.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.InssFaixas2 = decimal.Parse(txtInssFaixa2.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.InssFaixas3 = decimal.Parse(txtInssFaixa3.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.InssFaixas4 = decimal.Parse(txtInssFaixa4.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.InssAliquotas1 = decimal.Parse(txtInssAliquota1.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.InssAliquotas2 = decimal.Parse(txtInssAliquota2.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.InssAliquotas3 = decimal.Parse(txtInssAliquota3.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.InssAliquotas4 = decimal.Parse(txtInssAliquota4.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfFaixas1 = decimal.Parse(txtIrrfFaixa1.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfFaixas2 = decimal.Parse(txtIrrfFaixa2.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfFaixas3 = decimal.Parse(txtIrrfFaixa3.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfFaixas4 = decimal.Parse(txtIrrfFaixa4.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfAliquotas1 = decimal.Parse(txtIrrfAliquota1.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfAliquotas2 = decimal.Parse(txtIrrfAliquota2.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfAliquotas3 = decimal.Parse(txtIrrfAliquota3.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfAliquotas4 = decimal.Parse(txtIrrfAliquota4.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfDeducoes1 = decimal.Parse(txtIrrfDeducao1.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfDeducoes2 = decimal.Parse(txtIrrfDeducao2.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfDeducoes3 = decimal.Parse(txtIrrfDeducao3.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.IrrfDeducoes4 = decimal.Parse(txtIrrfDeducao4.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.Fgts = decimal.Parse(txtFgts.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                novoParametro.SalarioMinimo = decimal.Parse(txtSalarioMinimo.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha todos os campos com números válidos.");
                return;
            }

            // Salvar com StreamWriter (que sobrescreve corretamente)
            baseTxt.SalvarParametros(ano, novoParametro);
            MessageBox.Show("Parâmetros atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtFgts_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
