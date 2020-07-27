using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Biblioteca.DAO;
using Biblioteca.Model;
using Biblioteca;


namespace Processamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valida a existencia do banco de dados.
            string databasePath = System.Configuration.ConfigurationManager.AppSettings["SQLitePath"];
            if (!File.Exists(databasePath))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O banco de dados não foi encontrado.");
                Console.WriteLine("Ajuste o caminho para arquivo nas configurações da programa.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pressione qualquer tecla para encerrar.");
                Console.ReadKey();
                Environment.Exit(-1);

            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Iniciando ao processamento!");

            try
            {
                //Procura por processamentos ainda não realizados
                ProcessingDAO processingDAO = new ProcessingDAO();
                List<Processing> listOfProcessings = processingDAO.getPendingList();
                if (listOfProcessings.Count > 0)
                {
                    Console.WriteLine(String.Format("Total de processamento agendados: {0}", listOfProcessings.Count));
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Iniciado.");

                    
                    ConfigurationDAO configurationDAO = new ConfigurationDAO();
                    ResultDAO resultDAO = new ResultDAO();
                    foreach (Processing processing in listOfProcessings)
                    {
                        //Busca a configuração do processamento
                        Configuration configuration = configurationDAO.get(processing.configurationId);

                        //Realiza os calculos
                        PillarsAndDistance pillarsAndDistance = Calculation.maxPillarsDistance(configuration, processing.totalDistance);
                        List<int> rp = Calculation.ReinforcedPillars(configuration, pillarsAndDistance, processing.totalDistance);
                        
                        //Cria um novo resultado
                        Result result = new Result();
                        result.processingId = processing.id;
                        result.numberPillars = pillarsAndDistance.numberOfPillars;
                        result.spansDistance = pillarsAndDistance.pillarsDistance;
                        result.numberReinforcedBases = rp.Count;
                        List<ReinforcedPillar> reinforcedPillars = new List<ReinforcedPillar>();
                        foreach(int pillar in rp)
                        {
                            ReinforcedPillar reinforcedPillar = new ReinforcedPillar();
                            reinforcedPillar.number = pillar;
                            reinforcedPillars.Add(reinforcedPillar);
                        }
                        result.reinforcedPillars = reinforcedPillars;
                        resultDAO.insert(result);

                        //Atualiza a situação do preocessamento
                        processing.processed = true;
                        processingDAO.update(processing);

                    }
                    Console.WriteLine("Encerrado!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Nenhum processamento está agendado.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inesperado:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();


        }

    }
}
