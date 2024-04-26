namespace UMLTrabalho_Lucas_
{
	partial class FrmExame
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
			this.dgvExame = new System.Windows.Forms.DataGridView();
			this.btnLocalizar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxPaciente = new System.Windows.Forms.ComboBox();
			this.txtTipo = new System.Windows.Forms.TextBox();
			this.cbxMedico = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cbxResidente = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.mkDataHora = new System.Windows.Forms.MaskedTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtHipoteseDiagnostica = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvExame)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvExame
			// 
			this.dgvExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvExame.Location = new System.Drawing.Point(13, 414);
			this.dgvExame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dgvExame.Name = "dgvExame";
			this.dgvExame.Size = new System.Drawing.Size(843, 310);
			this.dgvExame.TabIndex = 50;
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.BackColor = System.Drawing.Color.White;
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLocalizar.Location = new System.Drawing.Point(274, 32);
			this.btnLocalizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(122, 57);
			this.btnLocalizar.TabIndex = 42;
			this.btnLocalizar.Text = "LOCALIZAR";
			this.btnLocalizar.UseVisualStyleBackColor = false;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(456, 761);
			this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(182, 64);
			this.btnExcluir.TabIndex = 41;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackColor = System.Drawing.Color.SkyBlue;
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Location = new System.Drawing.Point(266, 761);
			this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(182, 64);
			this.btnAlterar.TabIndex = 40;
			this.btnAlterar.Text = "ALTERAR";
			this.btnAlterar.UseVisualStyleBackColor = false;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.Location = new System.Drawing.Point(76, 761);
			this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(182, 64);
			this.btnCadastrar.TabIndex = 39;
			this.btnCadastrar.Text = "CADASTRAR";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.BackColor = System.Drawing.Color.LightCoral;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.Location = new System.Drawing.Point(646, 761);
			this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(182, 64);
			this.btnFechar.TabIndex = 37;
			this.btnFechar.Text = "FECHAR";
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 274);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 16);
			this.label1.TabIndex = 35;
			this.label1.Text = "PACIENTE ID";
			// 
			// cbxPaciente
			// 
			this.cbxPaciente.FormattingEnabled = true;
			this.cbxPaciente.Location = new System.Drawing.Point(31, 293);
			this.cbxPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbxPaciente.Name = "cbxPaciente";
			this.cbxPaciente.Size = new System.Drawing.Size(261, 23);
			this.cbxPaciente.TabIndex = 56;
			// 
			// txtTipo
			// 
			this.txtTipo.Location = new System.Drawing.Point(29, 116);
			this.txtTipo.Name = "txtTipo";
			this.txtTipo.Size = new System.Drawing.Size(263, 21);
			this.txtTipo.TabIndex = 59;
			// 
			// cbxMedico
			// 
			this.cbxMedico.FormattingEnabled = true;
			this.cbxMedico.Location = new System.Drawing.Point(29, 232);
			this.cbxMedico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbxMedico.Name = "cbxMedico";
			this.cbxMedico.Size = new System.Drawing.Size(263, 23);
			this.cbxMedico.TabIndex = 66;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(26, 213);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(84, 16);
			this.label11.TabIndex = 65;
			this.label11.Text = "MEDICO ID";
			// 
			// cbxResidente
			// 
			this.cbxResidente.FormattingEnabled = true;
			this.cbxResidente.Location = new System.Drawing.Point(31, 364);
			this.cbxResidente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbxResidente.Name = "cbxResidente";
			this.cbxResidente.Size = new System.Drawing.Size(261, 23);
			this.cbxResidente.TabIndex = 68;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 345);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 16);
			this.label2.TabIndex = 67;
			this.label2.Text = "RESIDENTE ID";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(26, 32);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(22, 16);
			this.label5.TabIndex = 71;
			this.label5.Text = "ID";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(29, 51);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(76, 21);
			this.txtId.TabIndex = 72;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(26, 97);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 16);
			this.label8.TabIndex = 73;
			this.label8.Text = "TIPO";
			// 
			// mkDataHora
			// 
			this.mkDataHora.Location = new System.Drawing.Point(29, 172);
			this.mkDataHora.Mask = "00/00/0000";
			this.mkDataHora.Name = "mkDataHora";
			this.mkDataHora.Size = new System.Drawing.Size(180, 21);
			this.mkDataHora.TabIndex = 75;
			this.mkDataHora.ValidatingType = typeof(System.DateTime);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(26, 153);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(127, 16);
			this.label9.TabIndex = 76;
			this.label9.Text = "DATA PREVISTA";
			// 
			// txtHipoteseDiagnostica
			// 
			this.txtHipoteseDiagnostica.Location = new System.Drawing.Point(456, 51);
			this.txtHipoteseDiagnostica.Multiline = true;
			this.txtHipoteseDiagnostica.Name = "txtHipoteseDiagnostica";
			this.txtHipoteseDiagnostica.Size = new System.Drawing.Size(393, 324);
			this.txtHipoteseDiagnostica.TabIndex = 77;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(453, 32);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(110, 16);
			this.label10.TabIndex = 78;
			this.label10.Text = "DIAGNÓSTICO";
			// 
			// FrmExame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(882, 837);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtHipoteseDiagnostica);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.mkDataHora);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbxResidente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbxMedico);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtTipo);
			this.Controls.Add(this.cbxPaciente);
			this.Controls.Add(this.dgvExame);
			this.Controls.Add(this.btnLocalizar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmExame";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA";
			this.Load += new System.EventHandler(this.FrmExame_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvExame)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvExame;
		private System.Windows.Forms.Button btnLocalizar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxPaciente;
		private System.Windows.Forms.TextBox txtTipo;
		private System.Windows.Forms.ComboBox cbxMedico;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbxResidente;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MaskedTextBox mkDataHora;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtHipoteseDiagnostica;
		private System.Windows.Forms.Label label10;
	}
}