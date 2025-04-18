namespace FolhaDePagamento
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInsalubridade = new System.Windows.Forms.ComboBox();
            this.cmbPericulosidade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbValetransporte = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPensao = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPensao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbValeReifeicao = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValerefeicao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbHora50 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHora50 = new System.Windows.Forms.TextBox();
            this.txtHora100 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbHora100 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFalta1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbFalta1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFalta2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbFalta2 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFalta4 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbFalta4 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtFalta3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbFalta3 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panelAdicionais = new System.Windows.Forms.Panel();
            this.btnAddAdicional = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelDescontos = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(52, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(429, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += txtNome_TextChanged;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(223, 38);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(258, 20);
            this.txtCargo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cargo: ";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(60, 38);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(116, 20);
            this.txtMatricula.TabIndex = 5;
            this.txtMatricula.KeyPress += ValidacaoNumeros;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mátricula: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - - - - - - - - - ";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(87, 81);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(125, 20);
            this.txtSalarioBase.TabIndex = 10;
            this.txtSalarioBase.KeyPress += ValidacaoNumeros;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salário Base: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Insalubridade: ";
            // 
            // cmbInsalubridade
            // 
            this.cmbInsalubridade.FormattingEnabled = true;
            this.cmbInsalubridade.Location = new System.Drawing.Point(318, 81);
            this.cmbInsalubridade.Name = "cmbInsalubridade";
            this.cmbInsalubridade.Size = new System.Drawing.Size(159, 21);
            this.cmbInsalubridade.TabIndex = 12;
            // 
            // cmbPericulosidade
            // 
            this.cmbPericulosidade.FormattingEnabled = true;
            this.cmbPericulosidade.Location = new System.Drawing.Point(93, 115);
            this.cmbPericulosidade.Name = "cmbPericulosidade";
            this.cmbPericulosidade.Size = new System.Drawing.Size(121, 21);
            this.cmbPericulosidade.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Periculosidade:";
            // 
            // cmbValetransporte
            // 
            this.cmbValetransporte.FormattingEnabled = true;
            this.cmbValetransporte.Location = new System.Drawing.Point(318, 115);
            this.cmbValetransporte.Name = "cmbValetransporte";
            this.cmbValetransporte.Size = new System.Drawing.Size(159, 21);
            this.cmbValetransporte.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Vale-Transporte:";
            // 
            // cmbPensao
            // 
            this.cmbPensao.FormattingEnabled = true;
            this.cmbPensao.Location = new System.Drawing.Point(118, 149);
            this.cmbPensao.Name = "cmbPensao";
            this.cmbPensao.Size = new System.Drawing.Size(121, 21);
            this.cmbPensao.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pensão alimenticia: ";
            // 
            // txtPensao
            // 
            this.txtPensao.Location = new System.Drawing.Point(425, 149);
            this.txtPensao.Name = "txtPensao";
            this.txtPensao.Size = new System.Drawing.Size(52, 20);
            this.txtPensao.TabIndex = 20;
            this.txtPensao.KeyPress += ValidacaoNumeros;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Porcentagem de pensão alimenticia: ";
            // 
            // cmbValeReifeicao
            // 
            this.cmbValeReifeicao.FormattingEnabled = true;
            this.cmbValeReifeicao.Location = new System.Drawing.Point(97, 176);
            this.cmbValeReifeicao.Name = "cmbValeReifeicao";
            this.cmbValeReifeicao.Size = new System.Drawing.Size(121, 21);
            this.cmbValeReifeicao.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Vale-Refeição: ";
            // 
            // txtValerefeicao
            // 
            this.txtValerefeicao.Location = new System.Drawing.Point(425, 179);
            this.txtValerefeicao.Name = "txtValerefeicao";
            this.txtValerefeicao.Size = new System.Drawing.Size(52, 20);
            this.txtValerefeicao.TabIndex = 24;
            this.txtValerefeicao.KeyPress += ValidacaoNumeros;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(245, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Porcentagem descontada do VR:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(158, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Tempo de hora extra: ";
            // 
            // cmbHora50
            // 
            this.cmbHora50.FormattingEnabled = true;
            this.cmbHora50.Location = new System.Drawing.Point(99, 213);
            this.cmbHora50.Name = "cmbHora50";
            this.cmbHora50.Size = new System.Drawing.Size(52, 21);
            this.cmbHora50.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Hora extras 50%: ";
            // 
            // txtHora50
            // 
            this.txtHora50.Location = new System.Drawing.Point(275, 216);
            this.txtHora50.Name = "txtHora50";
            this.txtHora50.Size = new System.Drawing.Size(52, 20);
            this.txtHora50.TabIndex = 28;
            this.txtHora50.KeyPress += ValidacaoNumeros;
            // 
            // txtHora100
            // 
            this.txtHora100.Location = new System.Drawing.Point(291, 244);
            this.txtHora100.Name = "txtHora100";
            this.txtHora100.Size = new System.Drawing.Size(52, 20);
            this.txtHora100.TabIndex = 32;
            this.txtHora100.KeyPress += ValidacaoNumeros;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(174, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Tempo de hora extra: ";
            // 
            // cmbHora100
            // 
            this.cmbHora100.FormattingEnabled = true;
            this.cmbHora100.Location = new System.Drawing.Point(108, 244);
            this.cmbHora100.Name = "cmbHora100";
            this.cmbHora100.Size = new System.Drawing.Size(52, 21);
            this.cmbHora100.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 247);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Hora extras 100%: ";
            // 
            // txtFalta1
            // 
            this.txtFalta1.Location = new System.Drawing.Point(260, 275);
            this.txtFalta1.Name = "txtFalta1";
            this.txtFalta1.Size = new System.Drawing.Size(52, 20);
            this.txtFalta1.TabIndex = 36;
            this.txtFalta1.KeyPress += ValidacaoNumeros;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(174, 278);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Tempo de faltas: ";
            // 
            // cmbFalta1
            // 
            this.cmbFalta1.FormattingEnabled = true;
            this.cmbFalta1.Location = new System.Drawing.Point(120, 275);
            this.cmbFalta1.Name = "cmbFalta1";
            this.cmbFalta1.Size = new System.Drawing.Size(52, 21);
            this.cmbFalta1.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 278);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Faltas na 1° semana: ";
            // 
            // txtFalta2
            // 
            this.txtFalta2.Location = new System.Drawing.Point(260, 305);
            this.txtFalta2.Name = "txtFalta2";
            this.txtFalta2.Size = new System.Drawing.Size(52, 20);
            this.txtFalta2.TabIndex = 40;
            this.txtFalta2.KeyPress += ValidacaoNumeros;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(174, 308);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Tempo de faltas: ";
            // 
            // cmbFalta2
            // 
            this.cmbFalta2.FormattingEnabled = true;
            this.cmbFalta2.Location = new System.Drawing.Point(120, 305);
            this.cmbFalta2.Name = "cmbFalta2";
            this.cmbFalta2.Size = new System.Drawing.Size(52, 21);
            this.cmbFalta2.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 308);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Faltas na 2° semana: ";
            // 
            // txtFalta4
            // 
            this.txtFalta4.Location = new System.Drawing.Point(260, 366);
            this.txtFalta4.Name = "txtFalta4";
            this.txtFalta4.Size = new System.Drawing.Size(52, 20);
            this.txtFalta4.TabIndex = 48;
            this.txtFalta4.KeyPress += ValidacaoNumeros;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(174, 369);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Tempo de faltas: ";
            // 
            // cmbFalta4
            // 
            this.cmbFalta4.FormattingEnabled = true;
            this.cmbFalta4.Location = new System.Drawing.Point(120, 366);
            this.cmbFalta4.Name = "cmbFalta4";
            this.cmbFalta4.Size = new System.Drawing.Size(52, 21);
            this.cmbFalta4.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 369);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "Faltas na 4° semana: ";
            // 
            // txtFalta3
            // 
            this.txtFalta3.Location = new System.Drawing.Point(260, 336);
            this.txtFalta3.Name = "txtFalta3";
            this.txtFalta3.Size = new System.Drawing.Size(52, 20);
            this.txtFalta3.TabIndex = 44;
            this.txtFalta3.KeyPress += ValidacaoNumeros;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(174, 339);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "Tempo de faltas: ";
            // 
            // cmbFalta3
            // 
            this.cmbFalta3.FormattingEnabled = true;
            this.cmbFalta3.Location = new System.Drawing.Point(120, 336);
            this.cmbFalta3.Name = "cmbFalta3";
            this.cmbFalta3.Size = new System.Drawing.Size(52, 21);
            this.cmbFalta3.TabIndex = 42;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 339);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 13);
            this.label24.TabIndex = 41;
            this.label24.Text = "Faltas na 3° semana: ";
            // 
            // panelAdicionais
            // 
            this.panelAdicionais.AutoScroll = true;
            this.panelAdicionais.Location = new System.Drawing.Point(15, 410);
            this.panelAdicionais.Name = "panelAdicionais";
            this.panelAdicionais.Size = new System.Drawing.Size(364, 100);
            this.panelAdicionais.TabIndex = 49;
            this.panelAdicionais.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddAdicional
            // 
            this.btnAddAdicional.Location = new System.Drawing.Point(385, 410);
            this.btnAddAdicional.Name = "btnAddAdicional";
            this.btnAddAdicional.Size = new System.Drawing.Size(96, 45);
            this.btnAddAdicional.TabIndex = 50;
            this.btnAddAdicional.Text = "Adicionar";
            this.btnAddAdicional.UseVisualStyleBackColor = true;
            this.btnAddAdicional.Click += new System.EventHandler(this.btnAddAdicional_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 45);
            this.button1.TabIndex = 51;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 391);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(112, 13);
            this.label25.TabIndex = 52;
            this.label25.Text = "Beneficios adicionais: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 519);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(114, 13);
            this.label26.TabIndex = 56;
            this.label26.Text = "Descontos adicionais: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 45);
            this.button2.TabIndex = 55;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(382, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 45);
            this.button3.TabIndex = 54;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelDescontos
            // 
            this.panelDescontos.AutoScroll = true;
            this.panelDescontos.Location = new System.Drawing.Point(12, 538);
            this.panelDescontos.Name = "panelDescontos";
            this.panelDescontos.Size = new System.Drawing.Size(364, 100);
            this.panelDescontos.TabIndex = 53;
            this.panelDescontos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDescontos_Paint);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(-56, 680);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(559, 13);
            this.label27.TabIndex = 57;
            this.label27.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - - - - - - - - - ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 659);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 13);
            this.label29.TabIndex = 58;
            this.label29.Text = "Ano: ";
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(39, 656);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(52, 21);
            this.cmbAno.TabIndex = 59;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(79, 706);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 67);
            this.button4.TabIndex = 60;
            this.button4.Text = "Calcular";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(239, 706);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 67);
            this.button5.TabIndex = 61;
            this.button5.Text = "Limpar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 790);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panelDescontos);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddAdicional);
            this.Controls.Add(this.panelAdicionais);
            this.Controls.Add(this.txtFalta4);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cmbFalta4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtFalta3);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cmbFalta3);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtFalta2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbFalta2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtFalta1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbFalta1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtHora100);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbHora100);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtHora50);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbHora50);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtValerefeicao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbValeReifeicao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPensao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbPensao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbValetransporte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbPericulosidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbInsalubridade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbInsalubridade;
        private System.Windows.Forms.ComboBox cmbPericulosidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbValetransporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPensao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPensao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbValeReifeicao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValerefeicao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbHora50;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHora50;
        private System.Windows.Forms.TextBox txtHora100;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbHora100;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFalta1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbFalta1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtFalta2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbFalta2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFalta4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbFalta4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtFalta3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbFalta3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panelAdicionais;
        private System.Windows.Forms.Button btnAddAdicional;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelDescontos;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

