using ClimaTempo_AuvoSistemas.Context;
using ClimaTempo_AuvoSistemas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClimaTempo_AuvoSistemas.Repositorios
{
    public class RepositorioPrevisoes
    {
        private readonly ClimaTempoSimplesContext _contexto = new ClimaTempoSimplesContext();

        public List<PrevisaoClima> CapturarPrevisaoCidadesMaisQuentes()
        {
            try
            {
                List<PrevisaoClima> cidadesMaisQuentes = _contexto.PrevisaoClimas
                                                        .Include(p => p.Cidade)
                                                        .Include(p => p.Cidade.Estado)
                                                        .Where(p => p.DataPrevisao == DateTime.Parse("23/11/2021"))
                                                        .OrderByDescending(p => p.TemperaturaMaxima)
                                                        .Take(3)
                                                        .ToList();

                return cidadesMaisQuentes;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<PrevisaoClima> CapturarPrevisaoCidadesMaisFrias()
        {
            try
            {
                List<PrevisaoClima> cidadesMaisFrias = _contexto.PrevisaoClimas
                                                        .Include(p => p.Cidade)
                                                        .Include(p => p.Cidade.Estado)
                                                        .Where(p => p.DataPrevisao == DateTime.Parse("23/11/2021"))
                                                        .OrderBy(p => p.TemperaturaMinima)
                                                        .Take(3)
                                                        .ToList();

                return cidadesMaisFrias;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void CapturarPrevisaoSemanal(Cidade cidade)
        {
            try
            {
                cidade.PrevisaoClimas = _contexto.PrevisaoClimas
                                      .Where(p => p.DataPrevisao >= DateTime.Parse("23/11/2021")
                                               && p.DataPrevisao <= DateTime.Parse("29/11/2021")
                                               && p.CidadeId == cidade.Id)
                                      .ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
