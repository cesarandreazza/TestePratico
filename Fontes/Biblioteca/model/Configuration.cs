using System;

namespace Biblioteca.Model
{
    /// <summary>
    /// Representa a entidade Configuration (configuração)
    /// </summary>
    public class Configuration
    {
        //indetificado unico da configuração
        public int id { get; set; }
        //distância máxima dos vãos
        public double maxSpansDistance { get; set; }
        //distância minima total da estrutura
        public double minTotalDistance { get; set; }
        //distância máxima que podera ser instalada a base reforçada
        public double maxDistanceReinforcedBase { get; set; }
    }
}
