using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMLTrabalho_Lucas_
{
	public class Docente
	{
		public int Id { get; set; }
		public string Titulacao { get; set; }

		private MySqlConnection connection = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm");

		public void InserirDocente(string titulacao)
		{
			try
			{
				connection.Open();
				string query = "INSERT INTO Docente (titulacao) VALUES (@Titulacao)";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@Titulacao", titulacao);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao inserir docente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
		}

		public void AtualizarDocente(int id, string novaTitulacao)
		{
			try
			{
				connection.Open();
				string query = "UPDATE Docente SET titulacao = @NovaTitulacao WHERE id = @Id";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@NovaTitulacao", novaTitulacao);
				cmd.Parameters.AddWithValue("@Id", id);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao atualizar docente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
		}

		public void ExcluirDocente(int id)
		{
			try
			{
				connection.Open();
				string query = "DELETE FROM Docente WHERE id = @Id";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@Id", id);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir docente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
		}

		public Docente LocalizarDocente(int id)
		{
			Docente docenteEncontrado = null;
			try
			{
				connection.Open();
				string query = "SELECT * FROM Docente WHERE id = @Id";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@Id", id);
				MySqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					docenteEncontrado = new Docente
					{
						Id = Convert.ToInt32(reader["id"]),
						Titulacao = reader["titulacao"].ToString()
					};
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao buscar docente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
			return docenteEncontrado;
		}

		public List<Docente> ListarDocentes()
		{
			List<Docente> listaDocentes = new List<Docente>();
			try
			{
				connection.Open();
				string query = "SELECT * FROM Docente";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					listaDocentes.Add(new Docente
					{
						Id = Convert.ToInt32(reader["id"]),
						Titulacao = reader["titulacao"].ToString()
					});
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao listar docentes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
			return listaDocentes;
		}

	}
}
