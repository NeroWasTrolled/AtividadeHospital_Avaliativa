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
	public partial class FrmDocente : Form
	{
		public FrmDocente()
		{
			InitializeComponent();
			AtualizarDataGridView();
		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o campo da titulação está preenchido
				if (string.IsNullOrWhiteSpace(txtTitulacao.Text))
				{
					MessageBox.Show("Por favor, insira a titulação do docente!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				string titulacao = txtTitulacao.Text.Trim();

				// Cria um novo objeto Docente
				Docente novoDocente = new Docente();

				// Chama o método InserirDocente para inserir o novo docente
				novoDocente.InserirDocente(titulacao);
				MessageBox.Show("Docente inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LimparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao cadastrar docente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LimparCampos()
		{
			txtTitulacao.Text = "";
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o campo ID está preenchido
				if (string.IsNullOrWhiteSpace(txtId.Text))
				{
					MessageBox.Show("Por favor, informe o ID do docente que deseja alterar!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Verifica se o campo da nova titulação está preenchido
				if (string.IsNullOrWhiteSpace(txtTitulacao.Text))
				{
					MessageBox.Show("Por favor, informe a nova titulação do docente!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(txtId.Text.Trim());
				string novaTitulacao = txtTitulacao.Text.Trim();

				// Cria um novo objeto Docente
				Docente docente = new Docente();

				// Tenta atualizar o docente com o ID especificado
				docente.AtualizarDocente(id, novaTitulacao);
				MessageBox.Show("Docente atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LimparCampos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao atualizar docente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLocalizar_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o campo ID está preenchido
				if (string.IsNullOrWhiteSpace(txtId.Text))
				{
					MessageBox.Show("Por favor, informe o ID do docente que deseja localizar!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(txtId.Text.Trim());

				// Cria um novo objeto Docente
				Docente docente = new Docente();

				// Tenta localizar o docente pelo ID
				docente = docente.LocalizarDocente(id);

				// Verifica se o docente foi encontrado
				if (docente != null)
				{
					// Exibe os valores do docente nos controles de texto
					txtTitulacao.Text = docente.Titulacao;
					MessageBox.Show("Docente encontrado!", "Localização", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Docente não encontrado!", "Localização", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao localizar docente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				// Verifica se o campo ID está preenchido
				if (string.IsNullOrWhiteSpace(txtId.Text))
				{
					MessageBox.Show("Por favor, informe o ID do docente que deseja excluir!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(txtId.Text.Trim());

				// Cria um novo objeto Docente
				Docente docente = new Docente();

				// Verifica se o docente foi encontrado
				if (docente.LocalizarDocente(id) != null)
				{
					// Exclui o docente com o ID especificado
					docente.ExcluirDocente(id);
					MessageBox.Show("Docente excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos(); // Limpa os campos após a exclusão
				}
				else
				{
					MessageBox.Show("Docente não encontrado!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir docente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FrmDocente_Load(object sender, EventArgs e)
		{

		}
		private void AtualizarDataGridView()
		{
			Docente docente = new Docente();
			List<Docente> listaDocentes = docente.ListarDocentes();
			dgvDocente.DataSource = listaDocentes;
		}

	}
}
