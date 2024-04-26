using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace UMLTrabalho_Lucas_
{
	public class Medico
	{
		public int id { get; set; }
		public string nome { get; set; }
		public int crm { get; set; }

		MySqlConnection con = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm");

		public List<Medico> ListarMedicos()
		{
			List<Medico> listaMedicos = new List<Medico>();
			string sql = "SELECT * FROM Medico";
			con.Open();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			MySqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Medico medico = new Medico
				{
					id = (int)dr["Id"],
					nome = dr["nome"].ToString(),
					crm = (int)dr["crm"]
				};
				listaMedicos.Add(medico);
			}
			dr.Close();
			con.Close();
			return listaMedicos;
		}

		public void InserirMedico(Medico novoMedico)
		{
			string sql = "INSERT INTO Medico (nome, crm) VALUES (@Nome, @CRM)";
			con.Open();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@Nome", novoMedico.nome);
			cmd.Parameters.AddWithValue("@CRM", novoMedico.crm);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void AtualizarMedico(Medico medicoAtualizado)
		{
			string sql = "UPDATE Medico SET nome = @Nome, crm = @CRM WHERE id = @Id";
			con.Open();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@Nome", medicoAtualizado.nome);
			cmd.Parameters.AddWithValue("@CRM", medicoAtualizado.crm);
			cmd.Parameters.AddWithValue("@Id", medicoAtualizado.id);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public void ExcluirMedico(int id)
		{
			string sql = "DELETE FROM Medico WHERE id = @Id";
			con.Open();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@Id", id);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		public Medico BuscarMedicoPorID(int id)
		{
			Medico medicoEncontrado = null;
			string sql = "SELECT * FROM Medico WHERE id = @Id";
			con.Open();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@Id", id);
			MySqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				medicoEncontrado = new Medico
				{
					id = (int)dr["Id"],
					nome = dr["nome"].ToString(),
					crm = (int)dr["crm"]
				};
			}
			dr.Close();
			con.Close();
			return medicoEncontrado;
		}

		public bool RegistroRepetido(int crm)
		{
			string sql = "SELECT COUNT(*) FROM Medico WHERE crm = @CRM";
			con.Open();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@CRM", crm);
			int count = Convert.ToInt32(cmd.ExecuteScalar());
			con.Close();
			return count > 0;
		}

		public override string ToString()
		{
			return nome;
		}
	}
}
