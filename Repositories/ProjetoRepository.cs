using CylonApi.Contexts;
using CylonApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CylonApi.Repositories
{
    public class ProjetoRepository{
        private readonly CylonContext _context;
        public ProjetoRepository(CylonContext context)
        {
            _context = context;
        }
        public List<Projeto> Listar(){
            return _context.Projetos.ToList();
        }
        
    }
}