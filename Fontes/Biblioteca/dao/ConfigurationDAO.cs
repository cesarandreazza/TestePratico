using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using Biblioteca.Model;

namespace Biblioteca.DAO
{
    /// <summary>
    /// Implementa as operações do modelo Configuration
    /// </summary>
    public class ConfigurationDAO: DatabaseHelper
    {

        /// <summary>
        /// Retorna um objeto Configuration pelo seu identificador
        /// </summary>
        /// <param name="id">int</param>
        public Configuration get(int id)
        {
            Configuration configuration = null;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT id, max_spans_distance, min_total_distance, max_distance_reinforced_base from configuration WHERE id = @Id";           
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@Id", id);
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            configuration = new Configuration();
                            configuration.id = reader.GetInt32(0);
                            configuration.maxSpansDistance = reader.GetDouble(1);
                            configuration.minTotalDistance = reader.GetDouble(2);
                            configuration.maxDistanceReinforcedBase = reader.GetDouble(3);
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
            return configuration;
        }

        /// <summary>
        /// Retorna a última configuração pelo seu identificador
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Configuration</returns>
        public Configuration getLast()
        {
            Configuration configuration = null;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT id, max_spans_distance, min_total_distance, max_distance_reinforced_base from configuration ORDER BY id DESC LIMIT 1";
                        cmd.Prepare();
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            configuration = new Configuration();
                            configuration.id = reader.GetInt32(0);
                            configuration.maxSpansDistance = reader.GetDouble(1);
                            configuration.minTotalDistance = reader.GetDouble(2);
                            configuration.maxDistanceReinforcedBase = reader.GetDouble(3);
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
            return configuration;

        }

        /// <summary>
        /// Retorna a lista completa de objetos Configuration
        /// </summary>
        /// <returns></returns>
        public List<Configuration> list()
        {
            List<Configuration> listConfig = new List<Configuration>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT id, max_spans_distance,min_total_distance,max_distance_reinforced_base from configuration";
                        cmd.Prepare();
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Configuration configuration = new Configuration();
                            configuration.id = reader.GetInt32(0);
                            configuration.maxSpansDistance = reader.GetDouble(1);
                            configuration.minTotalDistance = reader.GetDouble(2);
                            configuration.maxDistanceReinforcedBase = reader.GetDouble(3);
                            listConfig.Add(configuration);
         
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
            return listConfig;
        }

        /// <summary>
        /// Insere um novo objeto Configuration
        /// </summary>
        /// <param name="configuration">Configuration</param>
        public void insert(Configuration configuration)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO configuration(max_spans_distance,min_total_distance,max_distance_reinforced_base) VALUES (@maxSpansDistance,@minTotalDistance,@maxDistanceReinforcedBase)";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@maxSpansDistance", configuration.maxSpansDistance);
                        cmd.Parameters.AddWithValue("@minTotalDistance", configuration.minTotalDistance);
                        cmd.Parameters.AddWithValue("@maxDistanceReinforcedBase", configuration.maxDistanceReinforcedBase);
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
