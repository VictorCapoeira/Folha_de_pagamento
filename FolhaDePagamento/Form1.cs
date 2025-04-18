using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaDePagamento
{
    public partial class Form1 : Form
    {
        public int yOffset = 0;
        public int yOffset2 = 0;
        public double salarioBase;
        public double pensaoPorcetagem;
        public double valeRefeicaoPorcetagem;
        public double horaExtra50Tempo;
        public double horaExtra100Tempo;
        public double falta1SemanaTempo;
        public double falta2SemanaTempo;
        public double falta3SemanaTempo;
        public double falta4SemanaTempo;
        public int anoSelecionado;
        public Form1()
        {
            InitializeComponent();
            cmbInsalubridade.Items.Add(0);
            cmbInsalubridade.Items.Add(10);
            cmbInsalubridade.Items.Add(20);
            cmbInsalubridade.Items.Add(40);
            cmbPericulosidade.Items.Add("Sim");
            cmbPericulosidade.Items.Add("Não");
            cmbValeReifeicao.Items.Add("Sim");
            cmbValeReifeicao.Items.Add("Não");
            cmbPensao.Items.Add("Sim");
            cmbPensao.Items.Add("Não");
            cmbHora50.Items.Add("Sim");
            cmbHora50.Items.Add("Não");
            cmbHora100.Items.Add("Sim");
            cmbHora100.Items.Add("Não");
            cmbValetransporte.Items.Add("Sim");
            cmbValetransporte.Items.Add("Não");
            cmbFalta1.Items.Add("Sim");
            cmbFalta1.Items.Add("Não");
            cmbFalta2.Items.Add("Sim");
            cmbFalta2.Items.Add("Não");
            cmbFalta3.Items.Add("Sim");
            cmbFalta3.Items.Add("Não");
            cmbFalta4.Items.Add("Sim");
            cmbFalta4.Items.Add("Não");
            cmbAno.Items.Add(2025);
            cmbAno.Items.Add(2024);
            cmbAno.Items.Add(2023);
            cmbAno.Items.Add(2022);
            cmbAno.Items.Add(2021);
            cmbAno.Items.Add(2020);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddAdicional_Click(object sender, EventArgs e)
        {
            TextBox txtNome = new TextBox
            {
                Name = "txtAdicionalNome" + panelAdicionais.Controls.Count,
                Width = 150,
                Location = new Point(10, yOffset)
            };

            TextBox txtValor = new TextBox
            {
                Name = "txtAdicionalValor" + panelAdicionais.Controls.Count,
                Width = 80,
                Location = new Point(170, yOffset)
            };
            txtValor.KeyPress += ValidacaoNumeros;
            panelAdicionais.Controls.Add(txtNome);
            panelAdicionais.Controls.Add(txtValor);

            yOffset += 30; // Move o próximo campo para baixo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelAdicionais.Controls.Count >= 2)
            {
                // Remove os dois últimos controles adicionados
                panelAdicionais.Controls.RemoveAt(panelAdicionais.Controls.Count - 1);
                panelAdicionais.Controls.RemoveAt(panelAdicionais.Controls.Count - 1);
                yOffset -= 30;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox txtNome = new TextBox
            {
                Name = "txtDescontolNome" + panelDescontos.Controls.Count,
                Width = 150,
                Location = new Point(10, yOffset2)
            };

            TextBox txtValor = new TextBox
            {
                Name = "txtDescontoValor" + panelDescontos.Controls.Count,
                Width = 80,
                Location = new Point(170, yOffset2)
            };
            txtValor.KeyPress += ValidacaoNumeros;
            panelDescontos.Controls.Add(txtNome);
            panelDescontos.Controls.Add(txtValor);

            yOffset2 += 30; // Move o próximo campo para baixo
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panelDescontos.Controls.Count >= 2)
            {
                // Remove os dois últimos controles adicionados
                panelDescontos.Controls.RemoveAt(panelDescontos.Controls.Count - 1);
                panelDescontos.Controls.RemoveAt(panelDescontos.Controls.Count - 1);
                yOffset2 -= 30;
            }
        }

        private void panelDescontos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)){
                e.Handled = true;
            }
        }



        private void ValidacaoNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtSalarioBase.Text, out salarioBase)){
                MessageBox.Show("Valor de salário inválido ou campo está vazio!","Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }
            if (cmbPensao.Text == "Sim" && !double.TryParse(txtPensao.Text, out pensaoPorcetagem))
            {
                MessageBox.Show("Valor de pensão alimenticia é inválido ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbValeReifeicao.Text == "Sim" && !double.TryParse(txtValerefeicao.Text, out valeRefeicaoPorcetagem))
            {
                MessageBox.Show("Valor de vale refeição é inválido ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbHora50.Text == "Sim" && !double.TryParse(txtHora50.Text, out horaExtra50Tempo))
            {
                MessageBox.Show("Valor de hora extra a 50% é inválido ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbHora100.Text == "Sim" && !double.TryParse(txtHora100.Text, out horaExtra100Tempo))
            {
                MessageBox.Show("Valor de hora extra a 100% é inválido ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbFalta1.Text == "Sim" && !double.TryParse(txtFalta1.Text, out falta1SemanaTempo))
            {
                MessageBox.Show("Valor da falta 1° semana é inválida ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbFalta2.Text == "Sim" && !double.TryParse(txtFalta2.Text, out falta2SemanaTempo))
            {
                MessageBox.Show("Valor da falta 2° semana é inválida ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbFalta3.Text == "Sim" && !double.TryParse(txtFalta3.Text, out falta3SemanaTempo))
            {
                MessageBox.Show("Valor da falta 3° semana é inválida ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbFalta4.Text == "Sim" && !double.TryParse(txtFalta4.Text, out falta4SemanaTempo))
            {
                MessageBox.Show("Valor da falta 4° semana é inválida ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(cmbAno.Text, out anoSelecionado))
            {
                MessageBox.Show("Selecione o ano!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
