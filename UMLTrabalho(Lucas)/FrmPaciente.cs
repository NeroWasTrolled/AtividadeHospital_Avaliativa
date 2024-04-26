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
	public partial class FrmPaciente : Form
	{
		public FrmPaciente()
		{
			InitializeComponent();
		}

		// Adicione esses métodos no construtor do seu formulário ou em algum método de inicialização.
		private void CarregarComboBoxes()
		{
			CarregarComboBoxSexo();
			CarregarComboBoxCor();
		}

		private void CarregarComboBoxSexo()
		{
			// Adiciona os valores de sexo biológico ao ComboBox cbxSexo
			cbxSexo.Items.Add("Masculino");
			cbxSexo.Items.Add("Feminino");
			cbxSexo.Items.Add("Outro");
			cbxSexo.Items.Add("Prefiro não dizer"); // Ou outra opção adequada
		}

		private void CarregarComboBoxCor()
		{
			// Adiciona os valores de cor de pele ao ComboBox cbxCor
			cbxCor.Items.Add("Branco");
			cbxCor.Items.Add("Negro");
			cbxCor.Items.Add("Pardo");
			cbxCor.Items.Add("Amarelo");
			cbxCor.Items.Add("Indígena");
		}


		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se todos os campos estão preenchidos
				if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtIdade.Text))
				{
					MessageBox.Show("Por favor, preencha todos os campos obrigatórios!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Cria um novo objeto Paciente com os dados dos campos de texto e ComboBoxes
				Paciente novoPaciente = new Paciente
				{
					Nome = txtNome.Text,
					Sexo = cbxSexo.SelectedItem.ToString(),
					Cor = cbxCor.SelectedItem.ToString(),
					Idade = Convert.ToInt32(txtIdade.Text)
				};

				// Chama o método InserirPaciente para inserir o paciente
				novoPaciente.InserirPaciente(novoPaciente);
				MessageBox.Show("Paciente inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LimparCampos();
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
					MessageBox.Show("Por favor, informe o ID do paciente que deseja alterar!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(txtId.Text.Trim());

				// Cria um novo objeto Paciente e busca pelo ID
				Paciente paciente = new Paciente().BuscarPacientePorId(id);

				// Verifica se o paciente foi encontrado
				if (paciente != null)
				{
					// Atualiza os dados do paciente com os valores dos campos de texto e ComboBoxes
					paciente.Nome = txtNome.Text;
					paciente.Idade = Convert.ToInt32(txtIdade.Text);
					paciente.Sexo = cbxSexo.SelectedItem.ToString();
					paciente.Cor = cbxCor.SelectedItem.ToString();

					// Chama o método para atualizar o paciente
					paciente.AtualizarPaciente(paciente);
					MessageBox.Show("Paciente alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Paciente não encontrado!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
					MessageBox.Show("Por favor, informe o ID do paciente que deseja excluir!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(txtId.Text.Trim());

				// Cria um novo objeto Paciente e busca pelo ID
				Paciente paciente = new Paciente().BuscarPacientePorId(id);

				// Verifica se o paciente foi encontrado
				if (paciente != null)
				{
					// Chama o método para excluir o paciente
					paciente.ExcluirPaciente(id);
					MessageBox.Show("Paciente excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}
				else
				{
					MessageBox.Show("Paciente não encontrado!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LimparCampos()
		{
			// Limpa os campos de texto após a inserção
			txtNome.Text = "";
			cbxSexo.Text = "";
			cbxCor.Text = "";
			txtIdade.Text = "";
		}

		private void PreencherDadosPaciente(Paciente paciente)
		{
			// Define o valor selecionado no ComboBox cbxCor
			if (!string.IsNullOrEmpty(paciente.Cor))
			{
				cbxCor.SelectedItem = paciente.Cor;
			}

			// Define o valor selecionado no ComboBox cbxSexo
			if (!string.IsNullOrEmpty(paciente.Sexo))
			{
				cbxSexo.SelectedItem = paciente.Sexo;
			}
		}

		private void btnLocalizar_Click(object sender, EventArgs e)
		{
			try
			{
				int id = Convert.ToInt32(txtId.Text.Trim());

				// Localiza o paciente pelo ID
				Paciente paciente = new Paciente().BuscarPacientePorId(id);

				if (paciente != null)
				{
					// Preenche os campos de texto com os dados do paciente
					txtNome.Text = paciente.Nome;
					txtIdade.Text = paciente.Idade.ToString();

					// Preenche os ComboBoxes com os dados do paciente
					PreencherDadosPaciente(paciente);

					MessageBox.Show("Paciente encontrado!", "Localização", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Paciente não encontrado!", "Localização", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FrmPaciente_Load(object sender, EventArgs e)
		{
			CarregarComboBoxes();
			CarregarDadosPaciente();
		}

		private void CarregarDadosPaciente()
		{
			try
			{
				// Instancia a classe Paciente e obtém a lista de todos os pacientes
				Paciente paciente = new Paciente();
				List<Paciente> pacientes = paciente.ListarPacientes();

				// Define a fonte de dados do DataGridView como a lista de pacientes
				dgvPaciente.DataSource = pacientes;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar os dados dos pacientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
