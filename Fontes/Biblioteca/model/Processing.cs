using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    /// <summary>
    /// Representa a entidade Processing (processamneto)
    /// </summary>
    public class Processing
    {
        //identificar do processamento
        public int id { get; set; }
        //identificador da configuração utilizada para o cálculo
        public int configurationId { get; set; }
        //distância total da reta
        public double totalDistance { get; set; }
        //indica se já ocorreu o processamento
        public bool processed { get; set; }
    }
}
