using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Biblioteca.Model;


namespace Biblioteca.DAO
{
    /// <summary>
    /// Implementa as operações do modelo ReinforcedPillar
    /// </summary>
    public class ReinforcedPillarDAO: DatabaseHelper
    {
        /// <summary>
        /// Retorna um objeto ReinforcedPillar pelo seu identificador
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ReinforcedPillar</returns>
        public ReinforcedPillar get(int id)
        {

            return null;
        }

        /// <summary>
        /// Retorna a lista completa de objetos ReinforcedPillar
        /// </summary>
        /// <returns></returns>
        public List<ReinforcedPillar> list(int result_id)
        {
            List<ReinforcedPillar> rp_list = new List<ReinforcedPillar>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT id, result_id, number from reinforced_pillar WHERE ressult_id = @resultID";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@resultId", result_id);
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        while (reader.HasRows)
                        {
                            ReinforcedPillar rp = new ReinforcedPillar();
                            rp.id = reader.GetInt32(0);
                            rp.resultId = reader.GetInt32(1);
                            rp.number = reader.GetInt32(2);
                            rp_list.Add(rp);
                            reader.NextResult();
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }

            return rp_list;
        }

        /// <summary>
        /// Insere um novo objeto ReinforcedPillar
        /// </summary>
        /// <param name="reinforcedPillar">ReinforcedPillar</param>
        public void insert(ReinforcedPillar reinforcedPillar)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO reinforced_pillar(result_id,number) VALUES (@resultId, @number)";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@resultId", reinforcedPillar.resultId);
                        cmd.Parameters.AddWithValue("@number", reinforcedPillar.number);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (SQLiteException ex)
                        {
                            throw ex;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
