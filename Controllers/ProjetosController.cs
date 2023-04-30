using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CylonApi.Models;
using CylonApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CylonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        public ProjetosController(ProjetoRepository projetoRepository){
            _projetoRepository = projetoRepository;
        }
        [HttpGet]
        public IActionResult Listar(){
            return Ok(_projetoRepository.Listar());
        }
    }
}