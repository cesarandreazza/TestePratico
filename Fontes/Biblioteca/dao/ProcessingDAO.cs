using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Biblioteca.Model;

namespace Biblioteca.DAO
{    /// <summary>
     /// Implementa as operações do modelo Processing
     /// </summary>
    public class ProcessingDAO : DatabaseHelper
    {

        /// <summary>
        /// Retorna um objeto Processing pelo seu identificador
        /// </summary>
        /// <param name="id">int</param>
        public Processing get(int id)
        {
            Processing processing = null;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT id,total_distance, processed, configuration_id from processing WHERE id = @Id";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@Id", id);
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            processing = new Processing();
                            processing.id = reader.GetInt32(0);
                            processing.totalDistance = reader.GetDouble(1);
                            processing.processed = reader.GetInt32(2)==1;
                            processing.configurationId = reader.GetInt32(3);
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
            return processing;
        }

        /// <summary>
        ///  Retorna um DataTable com os processamentos pendentes
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable getPending() 
        {
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter())
                {
                    using (dataAdapter.SelectCommand = connection.CreateCommand())
                    {
                        dataAdapter.SelectCommand.CommandText = "SELECT processing.id, total_distance, max_spans_distance, min_total_distance, max_distance_reinforced_base FROM processing INNER JOIN configuration ON configuration.id = processing.configuration_id WHERE processed = @processed";
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@processed", 0);
                        dataAdapter.SelectCommand.Connection.ConnectionString = connectionString;
                        //Nãp precisa abrir a conexão. Ela é aberta pelo DataAdapter..
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        return dataSet.Tables[0];
                    }
                    
                }
            }

        }

        /// <summary>
        ///  Retorna um DataTable com os processamentos pendentes
        /// </summary>
        /// <returns>List<Processing></returns>
        public List<Processing> getPendingList()
        {
            List<Processing> returnList = new List<Processing>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT id, total_distance, configuration_id from processing where processed = @processed";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@processed", 0);
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Processing processing = new Processing();
                            processing.id = reader.GetInt32(0);
                            processing.totalDistance = reader.GetDouble(1);
                            processing.configurationId = reader.GetInt32(2);
                            returnList.Add(processing);
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
        /// Insere um novo objeto Processing
        /// </summary>
        /// <param name="processing">Processing</param>
        /// 
        public bool insert(Processing processing)
        {
            bool result = false;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO processing(total_distance,processed,configuration_id) VALUES (@totalDistance,@processed,@configurationId)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@totalDistance", processing.totalDistance);
                    cmd.Parameters.AddWithValue("@processed", processing.processed ? 1 : 0);
                    cmd.Parameters.AddWithValue("@configurationId", processing.configurationId);
                    try
                    {
                        result = cmd.ExecuteNonQuery()>0;
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
            return result;

        }

        /// <summary>
        /// Exclui um processamento
        /// </summary>
        /// <param name="processingId">Identificador do processamento</param>
        /// <returns>Boolean</returns>
        public bool delete(int processingId)
        {
            bool result = false;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "DELETE FROM processing WHERE id = @Id";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@Id", processingId);
                    try
                    {
                        result = cmd.ExecuteNonQuery()>0;
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
            return result;
        }


        /// <summary>
        /// Atualiza um objeto Processing
        /// </summary>
        /// <param name="processing">Processing</param>
        /// <returns>Boolean</returns>
        public bool update(Processing processing)
        {
            bool result = false;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "UPDATE processing SET processed = @processed WHERE id = @Id";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@processed", 1);
                    cmd.Parameters.AddWithValue("@Id", processing.id);
                    try
                    {
                        result = cmd.ExecuteNonQuery() > 1;
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
            return result;
        }
    }
}
