namespace FolhaDePagamento
{
    partial class FormParametros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAnoParametro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInssFaixas = new System.Windows.Forms.TextBox();
            this.txtInssAliquotas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIrrfFaixas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIrrfAliquotas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIrrfDeducoes = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFgts = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAnoParametro
            // 
            this.cmbAnoParametro.FormattingEnabled = true;
            this.cmbAnoParametro.Location = new System.Drawing.Point(28, 25);
            this.cmbAnoParametro.Name = "cmbAnoParametro";
            this.cmbAnoParametro.Size = new System.Drawing.Size(121, 21);
            this.cmbAnoParametro.TabIndex = 0;
            this.cmbAnoParametro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ano: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inss Faixas";
            // 
            // txtInssFaixas
            // 
            this.txtInssFaixas.Location = new System.Drawing.Point(28, 129);
            this.txtInssFaixas.Name = "txtInssFaixas";
            this.txtInssFaixas.Size = new System.Drawing.Size(121, 20);
            this.txtInssFaixas.TabIndex = 3;
            // 
            // txtInssAliquotas
            // 
            this.txtInssAliquotas.Location = new System.Drawing.Point(28, 171);
            this.txtInssAliquotas.Name = "txtInssAliquotas";
            this.txtInssAliquotas.Size = new System.Drawing.Size(121, 20);
            this.txtInssAliquotas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inss Aliquotas";
            // 
            // txtIrrfFaixas
            // 
            this.txtIrrfFaixas.Location = new System.Drawing.Point(28, 218);
            this.txtIrrfFaixas.Name = "txtIrrfFaixas";
            this.txtIrrfFaixas.Size = new System.Drawing.Size(121, 20);
            this.txtIrrfFaixas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Imposto de renda faixas";
            // 
            // txtIrrfAliquotas
            // 
            this.txtIrrfAliquotas.Location = new System.Drawing.Point(28, 260);
            this.txtIrrfAliquotas.Name = "txtIrrfAliquotas";
            this.txtIrrfAliquotas.Size = new System.Drawing.Size(121, 20);
            this.txtIrrfAliquotas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Imposto de renda aliquotas";
            // 
            // txtIrrfDeducoes
            // 
            this.txtIrrfDeducoes.Location = new System.Drawing.Point(28, 305);
            this.txtIrrfDeducoes.Name = "txtIrrfDeducoes";
            this.txtIrrfDeducoes.Size = new System.Drawing.Size(121, 20);
            this.txtIrrfDeducoes.TabIndex = 11;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 288);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(142, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Imposto de renda decuções ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Carregar Ano";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Salvar Edições";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFgts
            // 
            this.txtFgts.Location = new System.Drawing.Point(28, 350);
            this.txtFgts.Name = "txtFgts";
            this.txtFgts.Size = new System.Drawing.Size(121, 20);
            this.txtFgts.TabIndex = 15;
            this.txtFgts.TextChanged += new System.EventHandler(this.txtFgts_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fgts";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(25, 390);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(121, 20);
            this.txtSalarioMinimo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Salario minimo";
            // 
            // FormParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 465);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFgts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIrrfDeducoes);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtIrrfAliquotas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIrrfFaixas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInssAliquotas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInssFaixas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAnoParametro);
            this.Name = "FormParametros";
            this.Text = "FormParametros";
            this.Load += new System.EventHandler(this.FormParametros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnoParametro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInssFaixas;
        private System.Windows.Forms.TextBox txtInssAliquotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIrrfFaixas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIrrfAliquotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIrrfDeducoes;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFgts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.Label label7;
    }
}