namespace UMLTrabalho_Lucas_
{
	partial class FrmMain
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnMedico = new System.Windows.Forms.Button();
			this.btnResidente = new System.Windows.Forms.Button();
			this.btnDocente = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnPaciente = new System.Windows.Forms.Button();
			this.btnExame = new System.Windows.Forms.Button();
			this.btnLaudo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnMedico
			// 
			this.btnMedico.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMedico.Location = new System.Drawing.Point(29, 28);
			this.btnMedico.Name = "btnMedico";
			this.btnMedico.Size = new System.Drawing.Size(186, 62);
			this.btnMedico.TabIndex = 0;
			this.btnMedico.Text = "MÉDICO";
			this.btnMedico.UseVisualStyleBackColor = false;
			this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
			// 
			// btnResidente
			// 
			this.btnResidente.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnResidente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnResidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResidente.Location = new System.Drawing.Point(29, 215);
			this.btnResidente.Name = "btnResidente";
			this.btnResidente.Size = new System.Drawing.Size(186, 62);
			this.btnResidente.TabIndex = 1;
			this.btnResidente.Text = "RESIDENTE";
			this.btnResidente.UseVisualStyleBackColor = false;
			this.btnResidente.Click += new System.EventHandler(this.btnResidente_Click);
			// 
			// btnDocente
			// 
			this.btnDocente.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDocente.Location = new System.Drawing.Point(29, 310);
			this.btnDocente.Name = "btnDocente";
			this.btnDocente.Size = new System.Drawing.Size(186, 62);
			this.btnDocente.TabIndex = 2;
			this.btnDocente.Text = "DOCENTE";
			this.btnDocente.UseVisualStyleBackColor = false;
			this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.LightCoral;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(29, 596);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(186, 62);
			this.btnSair.TabIndex = 3;
			this.btnSair.Text = "SAIR";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnPaciente
			// 
			this.btnPaciente.BackColor = System.Drawing.Color.SkyBlue;
			this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPaciente.Location = new System.Drawing.Point(29, 122);
			this.btnPaciente.Name = "btnPaciente";
			this.btnPaciente.Size = new System.Drawing.Size(186, 62);
			this.btnPaciente.TabIndex = 4;
			this.btnPaciente.Text = "PACIENTE";
			this.btnPaciente.UseVisualStyleBackColor = false;
			this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
			// 
			// btnExame
			// 
			this.btnExame.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExame.ForeColor = System.Drawing.Color.White;
			this.btnExame.Location = new System.Drawing.Point(29, 409);
			this.btnExame.Name = "btnExame";
			this.btnExame.Size = new System.Drawing.Size(186, 62);
			this.btnExame.TabIndex = 5;
			this.btnExame.Text = "EXAME";
			this.btnExame.UseVisualStyleBackColor = false;
			this.btnExame.Click += new System.EventHandler(this.btnExame_Click);
			// 
			// btnLaudo
			// 
			this.btnLaudo.BackColor = System.Drawing.Color.Black;
			this.btnLaudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLaudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLaudo.ForeColor = System.Drawing.Color.White;
			this.btnLaudo.Location = new System.Drawing.Point(29, 501);
			this.btnLaudo.Name = "btnLaudo";
			this.btnLaudo.Size = new System.Drawing.Size(186, 62);
			this.btnLaudo.TabIndex = 6;
			this.btnLaudo.Text = "DOCENTE";
			this.btnLaudo.UseVisualStyleBackColor = false;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(243, 679);
			this.Controls.Add(this.btnLaudo);
			this.Controls.Add(this.btnExame);
			this.Controls.Add(this.btnPaciente);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnDocente);
			this.Controls.Add(this.btnResidente);
			this.Controls.Add(this.btnMedico);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmMain";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMedico;
		private System.Windows.Forms.Button btnResidente;
		private System.Windows.Forms.Button btnDocente;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnPaciente;
		private System.Windows.Forms.Button btnExame;
		private System.Windows.Forms.Button btnLaudo;
	}
}

