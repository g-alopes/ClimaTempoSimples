using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClimaTempo_AuvoSistemas.Models
{
    public class ListaDeDados
    {
        public List<PrevisaoClima> ListaCidadesMaisQuentes { get; set; }

        public List<PrevisaoClima> ListaCidadesMaisFrias { get; set; }

        public List<Cidade> ListaCidades { get; set; }
    }
}
