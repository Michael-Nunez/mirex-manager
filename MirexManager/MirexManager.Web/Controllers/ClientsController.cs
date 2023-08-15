using Microsoft.AspNetCore.Mvc;
using MirexManager.Application.Abstracts;
using MirexManager.Domain.Clients;

namespace MirexManager.Web.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var clients = _clientService.GetClients();
            return View(clients);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]
        public IActionResult Create(int id)
        {
            return View();
        }
    }
}
