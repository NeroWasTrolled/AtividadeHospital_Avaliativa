namespace UMLTrabalho_Lucas_
{
	partial class FrmPaciente
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
			this.txtId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnLocalizar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.btnFechar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIdade = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbxCor = new System.Windows.Forms.ComboBox();
			this.cbxSexo = new System.Windows.Forms.ComboBox();
			this.dgvPaciente = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
			this.SuspendLayout();
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(28, 38);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(62, 20);
			this.txtId.TabIndex = 27;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 16);
			this.label3.TabIndex = 26;
			this.label3.Text = "ID";
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.BackColor = System.Drawing.Color.White;
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLocalizar.Location = new System.Drawing.Point(307, 35);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(89, 65);
			this.btnLocalizar.TabIndex = 25;
			this.btnLocalizar.Text = "LOCALIZAR";
			this.btnLocalizar.UseVisualStyleBackColor = false;
			this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(28, 419);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(358, 65);
			this.btnExcluir.TabIndex = 24;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackColor = System.Drawing.Color.SkyBlue;
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Location = new System.Drawing.Point(28, 348);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(358, 65);
			this.btnAlterar.TabIndex = 23;
			this.btnAlterar.Text = "ALTERAR";
			this.btnAlterar.UseVisualStyleBackColor = false;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.Location = new System.Drawing.Point(28, 277);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(358, 65);
			this.btnCadastrar.TabIndex = 22;
			this.btnCadastrar.Text = "CADASTRAR";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(28, 80);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(263, 20);
			this.txtNome.TabIndex = 21;
			// 
			// btnFechar
			// 
			this.btnFechar.BackColor = System.Drawing.Color.LightCoral;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.Location = new System.Drawing.Point(28, 490);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(358, 65);
			this.btnFechar.TabIndex = 20;
			this.btnFechar.Text = "FECHAR";
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 16);
			this.label2.TabIndex = 18;
			this.label2.Text = "SEXO";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 16);
			this.label1.TabIndex = 17;
			this.label1.Text = "NOME";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 16);
			this.label4.TabIndex = 28;
			this.label4.Text = "COR";
			// 
			// txtIdade
			// 
			this.txtIdade.Location = new System.Drawing.Point(28, 234);
			this.txtIdade.Name = "txtIdade";
			this.txtIdade.Size = new System.Drawing.Size(100, 20);
			this.txtIdade.TabIndex = 31;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(25, 215);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 16);
			this.label5.TabIndex = 30;
			this.label5.Text = "IDADE";
			// 
			// cbxCor
			// 
			this.cbxCor.FormattingEnabled = true;
			this.cbxCor.Location = new System.Drawing.Point(28, 177);
			this.cbxCor.Name = "cbxCor";
			this.cbxCor.Size = new System.Drawing.Size(162, 21);
			this.cbxCor.TabIndex = 32;
			// 
			// cbxSexo
			// 
			this.cbxSexo.FormattingEnabled = true;
			this.cbxSexo.Location = new System.Drawing.Point(28, 126);
			this.cbxSexo.Name = "cbxSexo";
			this.cbxSexo.Size = new System.Drawing.Size(162, 21);
			this.cbxSexo.TabIndex = 33;
			// 
			// dgvPaciente
			// 
			this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPaciente.Location = new System.Drawing.Point(419, 35);
			this.dgvPaciente.Name = "dgvPaciente";
			this.dgvPaciente.Size = new System.Drawing.Size(621, 520);
			this.dgvPaciente.TabIndex = 34;
			// 
			// FrmPaciente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1075, 577);
			this.Controls.Add(this.dgvPaciente);
			this.Controls.Add(this.cbxSexo);
			this.Controls.Add(this.cbxCor);
			this.Controls.Add(this.txtIdade);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnLocalizar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmPaciente";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA";
			this.Load += new System.EventHandler(this.FrmPaciente_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnLocalizar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtIdade;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbxCor;
		private System.Windows.Forms.ComboBox cbxSexo;
		private System.Windows.Forms.DataGridView dgvPaciente;
	}
}