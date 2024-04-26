namespace UMLTrabalho_Lucas_
{
	partial class FrmMedico
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtCrm = new System.Windows.Forms.TextBox();
			this.btnFechar = new System.Windows.Forms.Button();
			this.txtMedico = new System.Windows.Forms.TextBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnLocalizar = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvMedico = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "MEDICO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "CRM";
			// 
			// txtCrm
			// 
			this.txtCrm.Location = new System.Drawing.Point(26, 120);
			this.txtCrm.Name = "txtCrm";
			this.txtCrm.Size = new System.Drawing.Size(100, 20);
			this.txtCrm.TabIndex = 4;
			// 
			// btnFechar
			// 
			this.btnFechar.BackColor = System.Drawing.Color.LightCoral;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.Location = new System.Drawing.Point(26, 379);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(358, 65);
			this.btnFechar.TabIndex = 9;
			this.btnFechar.Text = "FECHAR";
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// txtMedico
			// 
			this.txtMedico.Location = new System.Drawing.Point(26, 74);
			this.txtMedico.Name = "txtMedico";
			this.txtMedico.Size = new System.Drawing.Size(263, 20);
			this.txtMedico.TabIndex = 10;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.Location = new System.Drawing.Point(26, 166);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(358, 65);
			this.btnCadastrar.TabIndex = 11;
			this.btnCadastrar.Text = "CADASTRAR";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackColor = System.Drawing.Color.SkyBlue;
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Location = new System.Drawing.Point(26, 237);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(358, 65);
			this.btnAlterar.TabIndex = 12;
			this.btnAlterar.Text = "ALTERAR";
			this.btnAlterar.UseVisualStyleBackColor = false;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(26, 308);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(358, 65);
			this.btnExcluir.TabIndex = 13;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.BackColor = System.Drawing.Color.White;
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLocalizar.Location = new System.Drawing.Point(305, 29);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(89, 65);
			this.btnLocalizar.TabIndex = 14;
			this.btnLocalizar.Text = "LOCALIZAR";
			this.btnLocalizar.UseVisualStyleBackColor = false;
			this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(26, 32);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(62, 20);
			this.txtId.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "ID";
			// 
			// dgvMedico
			// 
			this.dgvMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMedico.Location = new System.Drawing.Point(407, 32);
			this.dgvMedico.Name = "dgvMedico";
			this.dgvMedico.Size = new System.Drawing.Size(240, 412);
			this.dgvMedico.TabIndex = 17;
			// 
			// FrmMedico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(667, 472);
			this.Controls.Add(this.dgvMedico);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnLocalizar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtMedico);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.txtCrm);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmMedico";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA";
			this.Load += new System.EventHandler(this.FrmMedico_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCrm;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.TextBox txtMedico;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnLocalizar;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvMedico;
	}
}