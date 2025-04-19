using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Parametros baseTxt = new Parametros();
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

            txtInssFaixas.Text = string.Join(",", carregarTxt.InssFaixas);
            txtInssAliquotas.Text = string.Join(",", carregarTxt.InssAliquotas);
            txtIrrfFaixas.Text = string.Join(",", carregarTxt.IrrfFaixas);
            txtIrrfAliquotas.Text = string.Join(",", carregarTxt.IrrfAliquotas);
            txtIrrfDeducoes.Text = string.Join(",", carregarTxt.IrrfDeducoes);
            txtFgts.Text = carregarTxt.Fgts.ToString();


        }

        private void FormParametros_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ano = cmbAnoParametro.SelectedItem.ToString();
            Parametros novoParametro = new Parametros
            {
                InssFaixas = txtInssFaixas.Text.Split(',').Select(v => decimal.Parse(v)).ToList(),
                InssAliquotas = txtInssAliquotas.Text.Split(',').Select(v => decimal.Parse(v)).ToList(),
                IrrfFaixas = txtIrrfFaixas.Text.Split(',').Select(v => decimal.Parse(v)).ToList(),
                IrrfAliquotas = txtIrrfAliquotas.Text.Split(',').Select(v => decimal.Parse(v)).ToList(),
                IrrfDeducoes = txtIrrfDeducoes.Text.Split(',').Select(v => decimal.Parse(v)).ToList(),
                Fgts = decimal.Parse(txtFgts.Text)
            };
            baseTxt.SalvarParametrosNoArquivo(ano, novoParametro);

        }
    }
}
