namespace FolhaDePagamento
{
    partial class FormResumo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResumo));
            this.dgvGanhos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescontos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescontos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGanhos
            // 
            this.dgvGanhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Valor});
            this.dgvGanhos.Location = new System.Drawing.Point(3, 99);
            this.dgvGanhos.Name = "dgvGanhos";
            this.dgvGanhos.Size = new System.Drawing.Size(239, 150);
            this.dgvGanhos.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Valor
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle7;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // dgvDescontos
            // 
            this.dgvDescontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescontos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvDescontos.Location = new System.Drawing.Point(248, 99);
            this.dgvDescontos.Name = "dgvDescontos";
            this.dgvDescontos.Size = new System.Drawing.Size(240, 150);
            this.dgvDescontos.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "FOLHA DE PAGAMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "GANHOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "DESCONTOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-71, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1474, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-508, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1474, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-508, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1474, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLiquido
            // 
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.Location = new System.Drawing.Point(17, 313);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(0, 13);
            this.lblLiquido.TabIndex = 10;
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Location = new System.Drawing.Point(17, 276);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(0, 13);
            this.lblBruto.TabIndex = 9;
            // 
            // FormResumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLiquido);
            this.Controls.Add(this.lblBruto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDescontos);
            this.Controls.Add(this.dgvGanhos);
            this.Name = "FormResumo";
            this.Text = "FormResumo";
            this.Load += new System.EventHandler(this.FormResumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescontos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGanhos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridView dgvDescontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.Label lblBruto;
    }
}