using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace Biblioteca
{
    /// <summary>
    /// Realiza os calculos necessários
    /// </summary>
    public class Calculation
    {

        /// <summary>
        /// Efetua o calculo de número de pilares e a distancia entre eles
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="total_distance"></param>
        /// <returns>Retorna o objeto PillarsAndDistance</returns>
        public static PillarsAndDistance maxPillarsDistance(Configuration configuration, double  totalDistance)
        {
            //obtem o valor minimo de vãos na linha
            double mim_spans = totalDistance / configuration.maxSpansDistance;

            //usa o teto do minimo de vãos para obter um valor inteiro
            int spans = (int)Math.Ceiling(mim_spans);
            //ontem a quantidade de pilares acrescentando 1 ao numero de vãos
            int number_of_pillars = spans + 1;

            //obtem a distancia correta dos pilares 
            double pillars_distance = totalDistance / spans;
            return new PillarsAndDistance { numberOfPillars = number_of_pillars, pillarsDistance = pillars_distance };
        }

        /// <summary>
        /// Eftua o calculo para identificar os pilares com bases reforçadas
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="pillarsAndDistance"></param>
        /// <param name="totalDistance"></param>
        /// <returns></returns>
        public static List<int> ReinforcedPillars(Configuration configuration, PillarsAndDistance pillarsAndDistance, double totalDistance)
        {
            //Obtem o número de vãos com pilares reforçados necessários
            int spans_reinforced = ((int)Math.Floor(totalDistance / configuration.maxDistanceReinforcedBase));

            List<int> rp = new List<int>();
            //Adiciona o pilar 1, pois sempre será reforçado
            rp.Add(1);

            double dist_acum = pillarsAndDistance.pillarsDistance;

            int acum_spans_reinforced = 0;
            double maxDistanceReinforcedBase = configuration.maxDistanceReinforcedBase;
            
            //Percorre a lista de pilares
            for (int i=2;i<= pillarsAndDistance.numberOfPillars; i++)
            {
                //Se a distancia acumulada for maior que a distacia max para uma base reforçada fará a validação para selecionar os pilares
                if (dist_acum >= maxDistanceReinforcedBase)
                {

                    //Testa para saber se foi inclido no loop anterior como pilar subsequente
                    if (!rp.Contains(i-1))
                        rp.Add(i - 1);
                    //Se não for o ultimo pilar irá adicionar na lista
                    if (i < pillarsAndDistance.numberOfPillars)
                    {
                            rp.Add(i);
                    }

                    //Testa se o total de vãos com base reforçada já foi alcançado
                    if (acum_spans_reinforced < spans_reinforced)
                    {
                        //Se atingiu a distancia esperada para inlcuir as bases reforçadas incrementa a distância para o próximo cálculo
                        maxDistanceReinforcedBase += configuration.maxDistanceReinforcedBase;
                        acum_spans_reinforced++;
                    }
                }
                //Acumula a distância do vão percorrido
                dist_acum += pillarsAndDistance.pillarsDistance;
            }
            //Adiciona o último pilar pois sempre será reforçado
            rp.Add(pillarsAndDistance.numberOfPillars);
            return rp;
        }
    }
}
