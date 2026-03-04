using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_dotnet.Models;
using myfinance_web_dotnet_service.interfaces;

namespace myfinance_web_dotnet.Controllers
{
    public class PlanoContaController : Controller
    {
        private readonly IPlanoContaService _planoContaService;

        public PlanoContaController(IPlanoContaService planoContaService)
        {
            _planoContaService = planoContaService;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var listaPlanoContas = _planoContaService.ListarRegistros();
            List<PlanoContaModel> listaPlanoContasModel = new List<PlanoContaModel>();

            foreach (var item in listaPlanoContas)
            {
                var itemPlanoConta = new PlanoContaModel()
                {
                    Id = item.Id,
                    Descricao = item.Descricao,
                    Tipo = item.Tipo
                };
                
                listaPlanoContasModel.Add(itemPlanoConta);
            }

            ViewBag.ListaPlanoConta = listaPlanoContasModel;

            return View();
        }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
        
    }
}