using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    /// <summary>
    /// Representa a entidade Result (resultado)
    /// </summary>
    public class Result
    {
        //identificador unico do resultado
        public int id { get; set; }
        //identificador do processamento utilizada para o cálculo
        public int processingId { get; set; }
        //quantidade de pilares a serem inlcuídos
        public int numberPillars { get; set; }
        //distância entre vãos
        public double spansDistance { get; set; }
        //quantidade de bases reforçadas
        public int numberReinforcedBases { get; set; }
        //lista de pilares que irão receber a base reforçada
        public List<ReinforcedPillar> reinforcedPillars { get; set; }
        //indica se foi vizualizado
        public bool viewed { get; set; }
    }
}
