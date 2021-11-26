using ClimaTempo_AuvoSistemas.Context;
using ClimaTempo_AuvoSistemas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClimaTempo_AuvoSistemas.Repositorios
{
    public class RepositorioCidades
    {
        private readonly ClimaTempoSimplesContext _contexto = new ClimaTempoSimplesContext();

        public List<Cidade> CapturarCidades()
        {
            try
            {
                return _contexto.Cidades.ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
