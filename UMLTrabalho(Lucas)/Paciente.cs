using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace UMLTrabalho_Lucas_
{
	public class Paciente
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Sexo { get; set; }
		public string Cor { get; set; }
		public int Idade { get; set; }

		MySqlConnection con = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm");

		public List<Paciente> ListarPacientes()
		{
			List<Paciente> listaPacientes = new List<Paciente>();
			string sql = "SELECT * FROM Paciente";
			con.Open();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			MySqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Paciente paciente = new Paciente();
				paciente.Id = (int)dr["Id"];
				paciente.Nome = dr["nome"].ToString();
				paciente.Sexo = dr["sexo"].ToString();
				paciente.Cor = dr["cor"].ToString();
				paciente.Idade = (int)dr["idade"];
				listaPacientes.Add(paciente);
			}
			dr.Close();
			con.Close();
			return listaPacientes;
		}

		public void InserirPaciente(Paciente novoPaciente)
		{
			string sql = "INSERT INTO Paciente (nome, sexo, cor, idade) VALUES (@Nome, @Sexo, @Cor, @Idade)";
			if (con.State == ConnectionState.Closed)
			{
				con.Open();
			}
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@Nome", novoPaciente.Nome);
			cmd.Parameters.AddWithValue("@Sexo", novoPaciente.Sexo);
			cmd.Parameters.AddWithValue("@Cor", novoPaciente.Cor);
			cmd.Parameters.AddWithValue("@Idade", novoPaciente.Idade);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void AtualizarPaciente(Paciente pacienteAtualizado)
		{
			string sql = "UPDATE Paciente SET nome = @Nome, sexo = @Sexo, cor = @Cor, idade = @Idade WHERE Id = @Id";
			con.Open();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@Nome", pacienteAtualizado.Nome);
			cmd.Parameters.AddWithValue("@Sexo", pacienteAtualizado.Sexo);
			cmd.Parameters.AddWithValue("@Cor", pacienteAtualizado.Cor);
			cmd.Parameters.AddWithValue("@Idade", pacienteAtualizado.Idade);
			cmd.Parameters.AddWithValue("@Id", pacienteAtualizado.Id);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void ExcluirPaciente(int id)
		{
			string sql = "DELETE FROM Paciente WHERE Id = @Id";
			con.Open();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@Id", id);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public Paciente BuscarPacientePorId(int id)
		{
			Paciente pacienteEncontrado = null;
			try
			{
				con.Open();
				string query = "SELECT * FROM Paciente WHERE Id = @Id";
				MySqlCommand cmd = new MySqlCommand(query, con);
				cmd.Parameters.AddWithValue("@Id", id);
				MySqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					pacienteEncontrado = new Paciente
					{
						Id = Convert.ToInt32(reader["Id"]),
						Nome = reader["nome"].ToString(),
						Sexo = reader["sexo"].ToString(),
						Cor = reader["cor"].ToString(),
						Idade = Convert.ToInt32(reader["idade"])
					};
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erro ao buscar paciente: " + ex.Message);
			}
			finally
			{
				con.Close();
			}
			return pacienteEncontrado;
		}
	}
}
