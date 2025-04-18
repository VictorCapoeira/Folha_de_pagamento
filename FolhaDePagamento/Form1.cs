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
        public Form1()
        {
            InitializeComponent();
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

        private void txtMatricula_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }

        private void txtSalarioBase_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
