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
	public partial class FrmResidente : Form
	{
		public FrmResidente()
		{
			InitializeComponent();
			CarregarDadosResidente();
		}

		private void LimparCampos()
		{
			mkDataHora.Text = "";
		}

		private void CarregarDadosResidente()
		{
			try
			{
				// Limpa os dados existentes no DataGridView
				dgvResidente.DataSource = null;

				// Instancia a classe Residente e obtém a lista de todos os residentes
				Residente residente = new Residente();
				dgvResidente.DataSource = residente.ListarResidentes();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar os dados dos residentes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o valor no masked box está no formato de data válido
				if (!DateTime.TryParseExact(mkDataHora.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime anoResidencia))
				{
					MessageBox.Show("Por favor, insira um ano de residência válido!", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Cria um novo objeto Residente com o ano de residência fornecido
				Residente novoResidente = new Residente();

				// Verifica se já existe um residente com o mesmo ano de residência
				if (novoResidente.LocalizarResidente(anoResidencia.Year) != null)
				{
					MessageBox.Show("Já existe um residente cadastrado para o ano especificado!", "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				// Chama o método InserirResidente para inserir o novo residente
				novoResidente.InserirResidente(anoResidencia);
				MessageBox.Show("Residente inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LimparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao cadastrar residente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLocalizar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o campo ID está preenchido
				if (string.IsNullOrWhiteSpace(txtId.Text))
				{
					MessageBox.Show("Por favor, informe o ID do residente!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Converte o valor do txtId para um número inteiro
				int id = Convert.ToInt32(txtId.Text.Trim());

				// Cria um novo objeto Residente
				Residente residente = new Residente();

				// Tenta localizar o residente pelo ID
				residente = residente.LocalizarResidente(id);

				// Verifica se o residente foi encontrado
				if (residente != null)
				{
					// Exibe a data de residência nos campos de texto
					mkDataHora.Text = residente.AnoResidencia.ToString("dd/MM/yyyy");
					MessageBox.Show("Residente encontrado!", "Localização", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Residente não encontrado!", "Localização", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao localizar residente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void btnAlterar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o valor no masked box está no formato de data válido
				if (!DateTime.TryParseExact(mkDataHora.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime novoAnoResidencia))
				{
					MessageBox.Show("Por favor, insira uma data de residência válida no formato DD/MM/YYYY!", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Verifica se o campo ID está preenchido
				if (string.IsNullOrWhiteSpace(txtId.Text))
				{
					MessageBox.Show("Por favor, informe o ID do residente que deseja alterar!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(txtId.Text.Trim());

				// Cria um novo objeto Residente
				Residente residente = new Residente();

				// Verifica se o residente foi encontrado
				if (residente.LocalizarResidente(id) != null)
				{
					// Atualiza a data de residência do residente com o novo valor
					residente.AtualizarResidente(novoAnoResidencia, id);
					MessageBox.Show("Residente atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}
				else
				{
					MessageBox.Show("Residente não encontrado!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao atualizar residente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o campo ID está preenchido
				if (string.IsNullOrWhiteSpace(txtId.Text))
				{
					MessageBox.Show("Por favor, informe o ID do residente que deseja excluir!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(txtId.Text.Trim());

				// Cria um novo objeto Residente
				Residente residente = new Residente();

				// Exclui o residente com o ID especificado
				residente.ExcluirResidente(id);
				LimparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir residente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
