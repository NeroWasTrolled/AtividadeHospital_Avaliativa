using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySqlConnector;

namespace UMLTrabalho_Lucas_
{
	public class Residente
	{
		public int id { get; set; }
		public DateTime AnoResidencia { get; set; }

		private MySqlConnection connection = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm");

		public void InserirResidente(DateTime anoResidencia)
		{
			try
			{
				connection.Open();
				string query = "INSERT INTO Residente (anoResidencia) VALUES (@AnoResidencia)";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@AnoResidencia", anoResidencia);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao inserir residente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
		}

		public void AtualizarResidente(DateTime novoAnoResidencia, int idResidente)
		{
			try
			{
				connection.Open();
				string query = "UPDATE Residente SET anoResidencia = @NovoAnoResidencia WHERE id = @IdResidente";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@NovoAnoResidencia", novoAnoResidencia);
				cmd.Parameters.AddWithValue("@IdResidente", idResidente);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao atualizar residente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
		}

		public void ExcluirResidente(int id)
		{
			try
			{
				connection.Open();
				string query = "DELETE FROM Residente WHERE id = @Id";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@Id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Residente excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir residente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
		}

		public Residente LocalizarResidente(int id)
		{
			Residente residenteEncontrado = null;
			try
			{
				connection.Open();
				string query = "SELECT * FROM Residente WHERE id = @Id";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@Id", id);
				MySqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					residenteEncontrado = new Residente
					{
						AnoResidencia = Convert.ToDateTime(reader["anoResidencia"])
					};
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao buscar residente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
			return residenteEncontrado;
		}

		public List<Residente> ListarResidentes()
		{
			List<Residente> residentes = new List<Residente>();
			try
			{
				connection.Open();
				string query = "SELECT * FROM Residente";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					Residente residente = new Residente
					{
						id = (int)reader["Id"],
						AnoResidencia = Convert.ToDateTime(reader["anoResidencia"])
					};
					residentes.Add(residente);
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao listar residentes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
			return residentes;
		}
	}
}
