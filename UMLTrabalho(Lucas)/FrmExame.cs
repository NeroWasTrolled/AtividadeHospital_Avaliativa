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
	public partial class FrmExame : Form
	{
		public FrmExame()
		{
			InitializeComponent();
		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o valor no masked box está no formato de data válido
				if (!DateTime.TryParseExact(mkDataHora.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataPrevista))
				{
					MessageBox.Show("Por favor, insira uma data prevista válida no formato DD/MM/YYYY!", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Cria um novo objeto Exame com os dados fornecidos
				Exame novoExame = new Exame
				{
					Tipo = txtTipo.Text,
					DataPrevista = dataPrevista,
					HipoteseDiagnostica = txtHipoteseDiagnostica.Text,
					MedicoID = Convert.ToInt32(cbxMedico.SelectedValue), // Supondo que cbxMedico é um ComboBox ligado aos médicos
					PacienteID = Convert.ToInt32(cbxPaciente.SelectedValue), // Supondo que cbxPaciente é um ComboBox ligado aos pacientes
					DocenteID = Convert.ToInt32(cbxResidente.SelectedValue) // Supondo que cbxDocente é um ComboBox ligado aos docentes
				};

				// Chama o método InserirExame para inserir o novo exame
				novoExame.InserirExame(novoExame);
				LimparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao cadastrar exame: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o valor no masked box está no formato de data válido
				if (!DateTime.TryParseExact(mkDataHora.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime novaDataPrevista))
				{
					MessageBox.Show("Por favor, insira uma data prevista válida no formato DD/MM/YYYY!", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Cria um novo objeto Exame com os dados fornecidos
				Exame exameAtualizado = new Exame
				{
					ID = Convert.ToInt32(txtId.Text),
					Tipo = txtTipo.Text,
					DataPrevista = novaDataPrevista,
					HipoteseDiagnostica = txtHipoteseDiagnostica.Text,
					MedicoID = Convert.ToInt32(cbxMedico.SelectedValue), // Supondo que cbxMedico é um ComboBox ligado aos médicos
					PacienteID = Convert.ToInt32(cbxPaciente.SelectedValue), // Supondo que cbxPaciente é um ComboBox ligado aos pacientes
					DocenteID = Convert.ToInt32(cbxResidente.SelectedValue) // Supondo que cbxDocente é um ComboBox ligado aos docentes
				};

				// Chama o método AtualizarExame para atualizar o exame
				exameAtualizado.AtualizarExame(exameAtualizado);
				LimparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao atualizar exame: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o campo ID está preenchido
				if (string.IsNullOrWhiteSpace(txtId.Text))
				{
					MessageBox.Show("Por favor, informe o ID do exame que deseja excluir!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(txtId.Text.Trim());

				// Cria um novo objeto Exame e chama o método ExcluirExame para excluir o exame
				new Exame().ExcluirExame(id);
				LimparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir exame: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void LimparCampos()
		{
			// Limpa os campos após as operações
			txtTipo.Text = "";
			mkDataHora.Text = "";
			txtHipoteseDiagnostica.Text = "";
			cbxMedico.SelectedIndex = -1;
			cbxPaciente.SelectedIndex = -1;
			cbxResidente.SelectedIndex = -1;
		}

		private void FrmExame_Load(object sender, EventArgs e)
		{
			cbxMedico.DataSource = new Medico().ListarMedicos(); 
			cbxMedico.DisplayMember = "Nome";
			cbxMedico.ValueMember = "ID"; 

			
			cbxPaciente.DataSource = new Paciente().ListarPacientes(); 
			cbxPaciente.DisplayMember = "Nome"; 
			cbxPaciente.ValueMember = "ID"; 

			
			cbxResidente.DataSource = new Residente().ListarResidentes(); 
			cbxResidente.DisplayMember = "AnoResidencia";
			cbxResidente.ValueMember = "ID";

			CarregarDadosExame();
		}

		private void CarregarDadosExame()
		{
			try
			{
				// Limpa os dados existentes no DataGridView
				dgvExame.DataSource = null;

				// Carrega os dados da tabela Exame do banco de dados
				List<Exame> pacientes = new Exame().ListarTodosExames();

				// Define a fonte de dados do DataGridView
				dgvExame.DataSource = pacientes;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar os dados dos exames: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}