using UMLTrabalho_Lucas_;
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
	public partial class FrmMedico : Form
	{
		public FrmMedico()
		{
			InitializeComponent();
		}

		
		private void LimparCampos()
		{
			// Limpa os campos de texto após a inserção
			txtMedico.Text = "";
			txtCrm.Text = "";
		}
		private void CarregarDadosMedico()
		{
			try
			{
				// Limpa o DataSource do DataGridView
				dgvMedico.DataSource = null;

				// Cria um novo objeto Medico
				Medico medico = new Medico();

				// Carrega os dados da tabela "Médico" no DataGridView
				dgvMedico.DataSource = medico.ListarMedicos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar dados do médico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void FrmMedico_Load(object sender, EventArgs e)
		{
			// Carrega os dados do médico ao carregar o formulário
			CarregarDadosMedico();
		}
		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se todos os campos estão preenchidos
				if (string.IsNullOrWhiteSpace(txtMedico.Text) || string.IsNullOrWhiteSpace(txtCrm.Text))
				{
					MessageBox.Show("Por favor, preencha todos os campos!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Cria um novo objeto Medico com os dados dos campos de texto
				Medico novoMedico = new Medico
				{
					nome = txtMedico.Text,
					crm = Convert.ToInt32(txtCrm.Text)
				};

				// Verifica se o CRM já existe na base de dados
				if (novoMedico.RegistroRepetido(novoMedico.crm))
				{
					MessageBox.Show("Erro: CRM já cadastrado para outro médico!", "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				else
				{
					// Chama o método InserirMedico para inserir o médico
					novoMedico.InserirMedico(novoMedico);
					MessageBox.Show("Médico inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLocalizar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o campo ID está preenchido
				if (string.IsNullOrWhiteSpace(txtId.Text))
				{
					MessageBox.Show("Por favor, informe o ID do médico!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(txtId.Text.Trim());

				// Cria um novo objeto Medico e busca pelo ID
				Medico medico = new Medico().BuscarMedicoPorID(id);

				// Verifica se o médico foi encontrado
				if (medico != null)
				{
					// Exibe os dados do médico nos campos de texto
					txtMedico.Text = medico.nome;
					txtCrm.Text = medico.crm.ToString();
					MessageBox.Show("Médico encontrado!", "Localização", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Médico não encontrado!", "Localização", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o campo ID está preenchido
				if (string.IsNullOrWhiteSpace(txtId.Text))
				{
					MessageBox.Show("Por favor, informe o ID do médico que deseja alterar!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(txtId.Text.Trim());

				// Cria um novo objeto Medico e busca pelo ID
				Medico medico = new Medico().BuscarMedicoPorID(id);

				// Verifica se o médico foi encontrado
				if (medico != null)
				{
					// Atualiza os dados do médico com os valores dos campos de texto
					medico.nome = txtMedico.Text;
					medico.crm = Convert.ToInt32(txtCrm.Text);

					// Chama o método para atualizar o médico
					medico.AtualizarMedico(medico);
					MessageBox.Show("Médico alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Médico não encontrado!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o campo ID está preenchido
				if (string.IsNullOrWhiteSpace(txtId.Text))
				{
					MessageBox.Show("Por favor, informe o ID do médico que deseja excluir!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(txtId.Text.Trim());

				// Cria um novo objeto Medico e busca pelo ID
				Medico medico = new Medico().BuscarMedicoPorID(id);

				// Verifica se o médico foi encontrado
				if (medico != null)
				{
					// Chama o método para excluir o médico
					medico.ExcluirMedico(id);
					MessageBox.Show("Médico excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}
				else
				{
					MessageBox.Show("Médico não encontrado!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
