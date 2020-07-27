using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    /// <summary>
    /// Representa a entidade ReinforcedPillar (pilar reforçado)
    /// </summary>
    public class ReinforcedPillar
    {
        //identificador unico do pilar reforçado
        public int id { get; set; }
        //identificar do resultado
        public int resultId { get; set; }
        //número do pilar
        public int number { get; set; }
    }
}
