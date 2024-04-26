namespace UMLTrabalho_Lucas_
{
	partial class FrmDocente
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
			this.btnFechar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitulacao = new System.Windows.Forms.TextBox();
			this.dgvDocente = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).BeginInit();
			this.SuspendLayout();
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(38, 47);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(61, 20);
			this.txtId.TabIndex = 40;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(35, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 16);
			this.label3.TabIndex = 39;
			this.label3.Text = "ID";
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.BackColor = System.Drawing.Color.White;
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLocalizar.Location = new System.Drawing.Point(292, 28);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(88, 65);
			this.btnLocalizar.TabIndex = 38;
			this.btnLocalizar.Text = "LOCALIZAR";
			this.btnLocalizar.UseVisualStyleBackColor = false;
			this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(23, 296);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(357, 65);
			this.btnExcluir.TabIndex = 37;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackColor = System.Drawing.Color.SkyBlue;
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Location = new System.Drawing.Point(23, 225);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(357, 65);
			this.btnAlterar.TabIndex = 36;
			this.btnAlterar.Text = "ALTERAR";
			this.btnAlterar.UseVisualStyleBackColor = false;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.Location = new System.Drawing.Point(23, 154);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(357, 65);
			this.btnCadastrar.TabIndex = 35;
			this.btnCadastrar.Text = "CADASTRAR";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.BackColor = System.Drawing.Color.LightCoral;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.Location = new System.Drawing.Point(23, 367);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(357, 65);
			this.btnFechar.TabIndex = 34;
			this.btnFechar.Text = "FECHAR";
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "TITULAÇÃO";
			// 
			// txtTitulacao
			// 
			this.txtTitulacao.Location = new System.Drawing.Point(37, 112);
			this.txtTitulacao.Name = "txtTitulacao";
			this.txtTitulacao.Size = new System.Drawing.Size(198, 20);
			this.txtTitulacao.TabIndex = 41;
			// 
			// dgvDocente
			// 
			this.dgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDocente.Location = new System.Drawing.Point(395, 28);
			this.dgvDocente.Name = "dgvDocente";
			this.dgvDocente.Size = new System.Drawing.Size(340, 404);
			this.dgvDocente.TabIndex = 42;
			// 
			// FrmDocente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(747, 457);
			this.Controls.Add(this.dgvDocente);
			this.Controls.Add(this.txtTitulacao);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnLocalizar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmDocente";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA";
			this.Load += new System.EventHandler(this.FrmDocente_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).EndInit();
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
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitulacao;
		private System.Windows.Forms.DataGridView dgvDocente;
	}
}