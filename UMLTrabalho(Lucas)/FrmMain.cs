using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMLTrabalho_Lucas_
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			var a = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (a == DialogResult.Yes)
			{
				Environment.Exit(0);
			}
		}

		private void btnMedico_Click(object sender, EventArgs e)
		{
			FrmMedico medico = new FrmMedico();
			medico.Show();
		}

		private void btnResidente_Click(object sender, EventArgs e)
		{
			FrmResidente residente = new FrmResidente();
			residente.Show();
		}

		private void btnDocente_Click(object sender, EventArgs e)
		{
			FrmDocente docente = new FrmDocente();
			docente.Show();
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{

		}

		private void btnPaciente_Click(object sender, EventArgs e)
		{
			FrmPaciente paciente = new FrmPaciente();
			paciente.Show();
		}

		private void btnExame_Click(object sender, EventArgs e)
		{
			FrmExame exame = new FrmExame();
			exame.Show();
		}
	}
}
