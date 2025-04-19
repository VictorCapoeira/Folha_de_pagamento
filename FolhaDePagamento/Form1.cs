using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FolhaDePagamento_Parametros;

namespace FolhaDePagamento
{
    
    public partial class Form1 : Form
    {
        public int yOffset = 0;
        public int yOffset2 = 0;
        public string nome;
        public string matricula;
        public string cargo;
        public decimal salarioBase;
        public decimal pensaoPorcetagem;
        public decimal valeRefeicaoPorcetagem;
        public decimal valeTranportePorcetagem;
        public decimal horaExtra50Tempo;
        public decimal horaExtra100Tempo;
        public decimal falta1SemanaTempo;
        public decimal falta2SemanaTempo;
        public decimal falta3SemanaTempo;
        public decimal falta4SemanaTempo;
        public int anoSelecionado;
        public decimal salarioBruto;
        public decimal salarioLiquido;
        public decimal horaExtraValores;
        public decimal faltasvalores;
        public decimal inssValor;
        public decimal fgtsValor;
        public decimal irrfValor;
        public decimal valeTransporteValor;
        public decimal valeAlimentacaoValor;
        public decimal pensaoValor;
        public decimal periculosidadeValor;
        public decimal insalubridadeValor;

        BaseDeParametros parametros = new BaseDeParametros();
        public Form1()
        {
            InitializeComponent();
            cmbInsalubridade.Items.Add("Não");
            cmbInsalubridade.Items.Add(10);
            cmbInsalubridade.Items.Add(20);
            cmbInsalubridade.Items.Add(40);
            cmbInsalubridade.SelectedItem = "Não";

            cmbPericulosidade.Items.Add("Sim");
            cmbPericulosidade.Items.Add("Não");
            cmbPericulosidade.SelectedItem = "Não";

            cmbValeReifeicao.Items.Add("Sim");
            cmbValeReifeicao.Items.Add("Não");
            cmbValeReifeicao.SelectedItem = "Não";

            cmbHora50.Items.Add("Sim");
            cmbHora50.Items.Add("Não");
            cmbHora50.SelectedItem = "Não";

            cmbHora100.Items.Add("Sim");
            cmbHora100.Items.Add("Não");
            cmbHora100.SelectedItem = "Não";

            cmbValetransporte.Items.Add("Sim");
            cmbValetransporte.Items.Add("Não");
            cmbValetransporte.SelectedItem = "Não";

            cmbFalta1.Items.Add("Sim");
            cmbFalta1.Items.Add("Não");
            cmbFalta1.SelectedItem = "Não";

            cmbFalta2.Items.Add("Sim");
            cmbFalta2.Items.Add("Não");
            cmbFalta2.SelectedItem = "Não";

            cmbFalta3.Items.Add("Sim");
            cmbFalta3.Items.Add("Não");
            cmbFalta3.SelectedItem = "Não";

            cmbFalta4.Items.Add("Sim");
            cmbFalta4.Items.Add("Não");
            cmbFalta4.SelectedItem = "Não";

            cmbAno.Items.Add(2025);
            cmbAno.Items.Add(2024);
            cmbAno.Items.Add(2023);
            cmbAno.Items.Add(2022);
            cmbAno.Items.Add(2021);
            cmbAno.Items.Add(2020);
            cmbAno.SelectedItem = 2025;

            cmbPensao.Items.Add("Não");
            cmbPensao.Items.Add("Sobre provento liquido");
            cmbPensao.Items.Add("Sobre provento bruto");
            cmbPensao.SelectedItem = "Não";
            

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
            pensaoValor = 0;
            salarioLiquido = 0;
            salarioBruto = 0;
            valeAlimentacaoValor = 0;
            valeTransporteValor = 0;
            horaExtraValores = 0;
            insalubridadeValor = 0;
            periculosidadeValor = 0;
            faltasvalores = 0;
            inssValor = 0;
            irrfValor = 0;
            fgtsValor = 0;

            nome = txtNome.Text != "" ? txtNome.Text : "Dado não informado!";
            cargo = txtCargo.Text != "" ? txtCargo.Text : "Dado não informado!";
            matricula = txtMatricula.Text != "" ? txtMatricula.Text : "Dado não informado!";
            if (!decimal.TryParse(txtSalarioBase.Text, out salarioBase)){
                MessageBox.Show("Valor de salário inválido ou campo está vazio!","Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
                txtSalarioBase.Focus();
                return;
            }
            if (cmbPensao.Text != "Não" && !decimal.TryParse(txtPensao.Text, out pensaoPorcetagem))
            {
                MessageBox.Show("Valor de pensão alimenticia é inválido ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPensao.Focus();
                return;
            }
            if (cmbValeReifeicao.Text == "Sim" && !decimal.TryParse(txtValerefeicao.Text, out valeRefeicaoPorcetagem))
            {
                MessageBox.Show("Valor de vale refeição é inválido ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValerefeicao.Focus();
                return;
            }
            if (cmbHora50.Text == "Sim" && !decimal.TryParse(txtHora50.Text, out horaExtra50Tempo))
            {
                MessageBox.Show("Valor de hora extra a 50% é inválido ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHora50.Focus();
                return;
            }
            if (cmbHora100.Text == "Sim" && !decimal.TryParse(txtHora100.Text, out horaExtra100Tempo))
            {
                MessageBox.Show("Valor de hora extra a 100% é inválido ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHora100.Focus();
                return;
            }
            if (cmbFalta1.Text == "Sim" && !decimal.TryParse(txtFalta1.Text, out falta1SemanaTempo))
            {
                MessageBox.Show("Valor da falta 1° semana é inválida ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFalta1.Focus();
                return;
            }
            if (cmbFalta2.Text == "Sim" && !decimal.TryParse(txtFalta2.Text, out falta2SemanaTempo))
            {
                MessageBox.Show("Valor da falta 2° semana é inválida ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFalta2.Focus();
                return;
            }
            if (cmbFalta3.Text == "Sim" && !decimal.TryParse(txtFalta3.Text, out falta3SemanaTempo))
            {
                MessageBox.Show("Valor da falta 3° semana é inválida ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFalta3.Focus();
                return;
            }
            if (cmbFalta4.Text == "Sim" && !decimal.TryParse(txtFalta4.Text, out falta4SemanaTempo))
            {
                MessageBox.Show("Valor da falta 4° semana é inválida ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFalta4.Focus();
                return;
            }
            if (cmbValetransporte.Text == "Sim" && !decimal.TryParse(txtValetransporte.Text, out valeTranportePorcetagem))
            {
                MessageBox.Show("Valor do vale transporte é inválido ou campo está vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValetransporte.Focus();
                return;
            }
            if (!int.TryParse(cmbAno.Text, out anoSelecionado))
            {
                MessageBox.Show("Selecione o ano!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach(Control controle in panelAdicionais.Controls)
            {
                if(controle is TextBox txt && string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos de benefícios adicionais.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Focus();
                    return;
                }
            }
            foreach (Control controle in panelDescontos.Controls)
            {
                if (controle is TextBox txt && string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos de descontos adicionais.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Focus();
                    return;
                }
            }
            Parametros parametrosbase = parametros.CarregarParametrosPorAno(anoSelecionado.ToString());
            if (horaExtra100Tempo != 0)
            {
                horaExtraValores += (salarioBase / 220) * 2 * horaExtra100Tempo;
            }
            if (horaExtra50Tempo != 0)
            {
                horaExtraValores += (salarioBase / 220) * 1.5m * horaExtra50Tempo;
            }
            if (falta1SemanaTempo != 0)
            {
                faltasvalores += (salarioBase / 220) * falta1SemanaTempo;
            }
            if (falta2SemanaTempo != 0)
            {
                faltasvalores += (salarioBase / 220) * falta2SemanaTempo;
            }
            if (falta3SemanaTempo != 0)
            {
                faltasvalores += (salarioBase / 220) * falta3SemanaTempo;
            }
            if (falta4SemanaTempo != 0)
            {
                faltasvalores += (salarioBase / 220) * falta4SemanaTempo;
            }
            if (valeTranportePorcetagem != 0)
            {
                valeTransporteValor += (salarioBase * valeTranportePorcetagem) / 100 ;
            }
            if (valeRefeicaoPorcetagem != 0)
            {
                valeAlimentacaoValor += (salarioBase * valeRefeicaoPorcetagem) / 100;
            }
            if (cmbInsalubridade.Text != "Não")
            {
                insalubridadeValor += (parametrosbase.SalarioMinimo * decimal.Parse(cmbInsalubridade.Text)) / 100;
            }
            if (cmbPericulosidade.Text == "Sim")
            {
                periculosidadeValor += (salarioBase * 30) / 100;
            }

            salarioBruto = salarioBase + horaExtraValores + SomarAdicionais() + insalubridadeValor + periculosidadeValor;

            if (pensaoPorcetagem != 0 && cmbPensao.Text == "Sobre provento bruto")
            {
                pensaoValor = (salarioBruto * pensaoPorcetagem) / 100;
            }
            inssValor = parametros.CalcularINSS(salarioBruto, anoSelecionado.ToString());
            irrfValor = parametros.CalcularIRRF((salarioBruto - inssValor), anoSelecionado.ToString());
            fgtsValor = salarioBruto * parametrosbase.Fgts;
            salarioLiquido = salarioBruto - inssValor - irrfValor - SomarDescontos() - faltasvalores - valeTransporteValor - valeAlimentacaoValor - pensaoValor;
            if (pensaoPorcetagem != 0 && cmbPensao.Text == "Sobre provento liquido")
            {
                pensaoValor = (salarioLiquido * pensaoPorcetagem) / 100;
                salarioLiquido -= pensaoValor;
            }
            MessageBox.Show(salarioLiquido.ToString());
            



        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormParametros frm = new FormParametros();
            frm.ShowDialog();

        }
     


       
        private decimal SomarAdicionais()
        {
            decimal total = 0;

            for (int i = 0; i < panelAdicionais.Controls.Count; i++)
            {
                Control c = panelAdicionais.Controls[i];

                if (c is TextBox txt && txt.Name.Contains("Valor"))
                {
                    if (decimal.TryParse(txt.Text.Replace("R$", "").Trim(), out decimal valor))
                    {
                        total += valor;
                    }
                }
            }

            return total;
        }
        private decimal SomarDescontos()
        {
            decimal total = 0;

            for (int i = 0; i < panelDescontos.Controls.Count; i++)
            {
                Control c = panelDescontos.Controls[i];

                if (c is TextBox txt && txt.Name.Contains("Valor"))
                {
                    if (decimal.TryParse(txt.Text.Replace("R$", "").Trim(), out decimal valor))
                    {
                        total += valor;
                    }
                }
            }

            return total;
        }

        private void txtValerefeicao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
