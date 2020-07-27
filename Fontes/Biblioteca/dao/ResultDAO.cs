using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Biblioteca.Model;

namespace Biblioteca.DAO
{
    /// <summary>
    /// Implementa as operações do modelo ReinforcedPillar
    /// </summary>
    public class ResultDAO: DatabaseHelper
    {

        /// <summary>
        /// Insere um novo objeto Result  e a lista de pilares que irão receber  a base reforçada
        /// </summary>
        /// <param name="result">Result</param>
        public void insert(Result result)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    SQLiteTransaction transaction = connection.BeginTransaction();
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.Transaction = transaction;
                        cmd.CommandText = "INSERT INTO result(processing_id, number_pillars, spans_distance, number_reinforced_bases) VALUES (@processingId, @numberPillars, @spansDistance, @numberReinforcedBases)";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@processingId", result.processingId);
                        cmd.Parameters.AddWithValue("@numberPillars", result.numberPillars);
                        cmd.Parameters.AddWithValue("@spansDistance", result.spansDistance);
                        cmd.Parameters.AddWithValue("@numberReinforcedBases", result.numberReinforcedBases);
                        try
                        {
                           
                            cmd.ExecuteNonQuery();
                            long rowID = connection.LastInsertRowId;

                            //Insere a lista de pilares com base reforçada
                            using (SQLiteCommand cmd_rp = new SQLiteCommand())
                            {
                                cmd_rp.Connection = connection;
                                cmd_rp.Transaction = transaction;

                                foreach (ReinforcedPillar rp in result.reinforcedPillars)
                                {
                                    cmd_rp.Reset();
                                    cmd_rp.CommandText = "INSERT INTO reinforced_pillar(result_id,number) VALUES (@resultId, @number)";
                                    cmd_rp.Prepare();
                                    cmd_rp.Parameters.AddWithValue("@resultId",rowID);
                                    cmd_rp.Parameters.AddWithValue("@number", rp.number);
                                    cmd_rp.ExecuteNonQuery();
                                }
                            }
                            //Se tudo ocorrer conforme esperado realiza o commit das alteração
                            transaction.Commit();
                        }
                        catch (SQLiteException ex)
                        {
                            transaction.Rollback();
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


        /// <summary>
        ///  Retorna uma lista com os resultadios com a indicação de não vizualizados
        /// </summary>
        /// <typeparam name="S">SQLiteConnection</typeparam>
        /// <typeparam name="T">SQLiteDataAdapter</typeparam>
        /// <returns>List<Result></returns>
        public List<Result> getUnviewedList(bool loadAll)
        {

            List<Result> returnList = new List<Result>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        if (loadAll)
                        {
                            cmd.CommandText = "SELECT id, processing_id, number_pillars, spans_distance, number_reinforced_bases from result  ORDER BY processing_id";
                            cmd.Prepare();
                        }
                        else
                        {
                            cmd.CommandText = "SELECT id, processing_id, number_pillars, spans_distance, number_reinforced_bases from result where viewed = @viewed ORDER BY processing_id";
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@viewed", 0);
                        }
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Result result = new Result();
                            result.id = reader.GetInt32(0);
                            result.processingId = reader.GetInt32(1);
                            result.numberPillars = reader.GetInt32(2);
                            result.spansDistance = reader.GetDouble(3);
                            result.numberReinforcedBases = reader.GetInt32(4);
                            result.reinforcedPillars = new List<ReinforcedPillar>();
                            using (SQLiteCommand cmd2 = new SQLiteCommand())
                            {
                                cmd2.Connection = connection;
                                cmd2.CommandText = "SELECT id, result_id, number from reinforced_pillar where result_id = @resultId";
                                cmd2.Prepare();
                                cmd2.Parameters.AddWithValue("@resultId", result.id);
                                SQLiteDataReader reader2 = cmd2.ExecuteReader();
                                while (reader2.Read())
                                {
                                    ReinforcedPillar rp = new ReinforcedPillar();
                                    rp.id = reader2.GetInt32(0);
                                    rp.resultId = reader2.GetInt32(1);
                                    rp.number = reader2.GetInt32(2);
                                    result.reinforcedPillars.Add(rp);
                                }
                                reader2.Close();
                            }
                            returnList.Add(result);
                        }
                        reader.Close();
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
            return returnList;

        }

        /// <summary>
        /// Atualiza um objeto Result
        /// </summary>
        /// <param name="result">Result</param>
        /// <returns>Boolean</returns>
        public bool update(Result result)
        {
            bool result_bool = false;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "UPDATE result SET viewed = @viewed WHERE id = @Id";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@viewed", 1);
                    cmd.Parameters.AddWithValue("@Id", result.id);
                    try
                    {
                        result_bool = cmd.ExecuteNonQuery() > 1;
                    }
                    catch (SQLiteException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return result_bool;
        }

    }
}
