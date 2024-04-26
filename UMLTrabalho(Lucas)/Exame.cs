using System;
using System.Collections.Generic;
using MySqlConnector;
using System.Windows.Forms;

namespace UMLTrabalho_Lucas_
{
	public class Exame
	{
		private MySqlConnection connection;

		public Exame()
		{
			string connectionString = "server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm";
			connection = new MySqlConnection(connectionString);
		}

		public void InserirExame(Exame novoExame)
		{
			try
			{
				connection.Open();
				string query = "INSERT INTO Exame (tipo, DataPrevista, hipoteseDiagnostica, MedicoID, PacienteID, DocenteID) VALUES (@Tipo, @DataPrevista, @HipoteseDiagnostica, @MedicoID, @PacienteID, @DocenteID)";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@Tipo", novoExame.Tipo);
				cmd.Parameters.AddWithValue("@DataPrevista", novoExame.DataPrevista);
				cmd.Parameters.AddWithValue("@HipoteseDiagnostica", novoExame.HipoteseDiagnostica);
				cmd.Parameters.AddWithValue("@MedicoID", novoExame.MedicoID);
				cmd.Parameters.AddWithValue("@PacienteID", novoExame.PacienteID);
				cmd.Parameters.AddWithValue("@DocenteID", novoExame.DocenteID);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Exame inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao inserir exame: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
		}

		public void AtualizarExame(Exame exameAtualizado)
		{
			try
			{
				connection.Open();
				string query = "UPDATE Exame SET tipo = @Tipo, DataPrevista = @DataPrevista, hipoteseDiagnostica = @HipoteseDiagnostica, MedicoID = @MedicoID, PacienteID = @PacienteID, DocenteID = @DocenteID WHERE ID = @ID";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@Tipo", exameAtualizado.Tipo);
				cmd.Parameters.AddWithValue("@DataPrevista", exameAtualizado.DataPrevista);
				cmd.Parameters.AddWithValue("@HipoteseDiagnostica", exameAtualizado.HipoteseDiagnostica);
				cmd.Parameters.AddWithValue("@MedicoID", exameAtualizado.MedicoID);
				cmd.Parameters.AddWithValue("@PacienteID", exameAtualizado.PacienteID);
				cmd.Parameters.AddWithValue("@DocenteID", exameAtualizado.DocenteID);
				cmd.Parameters.AddWithValue("@ID", exameAtualizado.ID);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Exame atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao atualizar exame: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
		}

		public void ExcluirExame(int id)
		{
			try
			{
				connection.Open();
				string query = "DELETE FROM Exame WHERE ID = @ID";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@ID", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Exame excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir exame: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
		}

		public Exame LocalizarExame(int id)
		{
			Exame exameEncontrado = null;
			try
			{
				connection.Open();
				string query = "SELECT * FROM Exame WHERE ID = @ID";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@ID", id);
				MySqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					exameEncontrado = new Exame
					{
						ID = Convert.ToInt32(reader["ID"]),
						Tipo = reader["tipo"].ToString(),
						DataPrevista = Convert.ToDateTime(reader["DataPrevista"]),
						HipoteseDiagnostica = reader["hipoteseDiagnostica"].ToString(),
						MedicoID = Convert.ToInt32(reader["MedicoID"]),
						PacienteID = Convert.ToInt32(reader["PacienteID"]),
						DocenteID = Convert.ToInt32(reader["DocenteID"])
					};
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao buscar exame: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
			return exameEncontrado;
		}

		public List<Exame> ListarTodosExames()
		{
			List<Exame> listaDeExames = new List<Exame>();
			try
			{
				connection.Open();
				string query = "SELECT * FROM Exame";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					Exame exame = new Exame
					{
						ID = Convert.ToInt32(reader["ID"]),
						Tipo = reader["tipo"].ToString(),
						DataPrevista = Convert.ToDateTime(reader["DataPrevista"]),
						HipoteseDiagnostica = reader["hipoteseDiagnostica"].ToString(),
						MedicoID = Convert.ToInt32(reader["MedicoID"]),
						PacienteID = Convert.ToInt32(reader["PacienteID"]),
						DocenteID = Convert.ToInt32(reader["DocenteID"])
					};
					listaDeExames.Add(exame);
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao listar exames: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
			return listaDeExames;
		}

		public int ID { get; set; }
		public string Tipo { get; set; }
		public DateTime DataPrevista { get; set; }
		public string HipoteseDiagnostica { get; set; }
		public int MedicoID { get; set; }
		public int PacienteID { get; set; }
		public int DocenteID { get; set; }
	}
}
