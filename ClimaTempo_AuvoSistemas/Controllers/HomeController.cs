using ClimaTempo_AuvoSistemas.Context;
using ClimaTempo_AuvoSistemas.Models;
using ClimaTempo_AuvoSistemas.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClimaTempo_AuvoSistemas.Controllers
{
    public class HomeController : Controller
    {
        RepositorioPrevisoes repositorioPrevisoes = new RepositorioPrevisoes();
        RepositorioCidades repositorioCidades = new RepositorioCidades();

        public IActionResult Index()
        {
            try
            {
                ListaDeDados listaDeDados = new ListaDeDados();

                listaDeDados.ListaCidadesMaisQuentes = repositorioPrevisoes.CapturarPrevisaoCidadesMaisQuentes();
                listaDeDados.ListaCidadesMaisFrias = repositorioPrevisoes.CapturarPrevisaoCidadesMaisFrias();
                listaDeDados.ListaCidades = repositorioCidades.CapturarCidades();

                return View(listaDeDados);
            }
            catch (Exception ex)
            {
                ViewBag.Exception = ex.Message;
                return View("Error");
            }
        }

        public ActionResult CapturarPrevisaoSemanal(Cidade cidade)
        {
            try
            {
                repositorioPrevisoes.CapturarPrevisaoSemanal(cidade);
                ViewBag.Cidade = cidade.Nome;

                return PartialView(cidade.PrevisaoClimas);
            }
            catch (Exception ex)
            {
                ViewBag.Exception = ex.Message;
                return View("Error");
            }
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }
}
