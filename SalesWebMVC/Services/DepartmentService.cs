using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoMVC.Models;
using ProjetoMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace ProjetoMVC.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMVCContext _context;
        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x=> x.Name).ToListAsync();
        }

    }
}
