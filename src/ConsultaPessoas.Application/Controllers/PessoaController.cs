using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using ConsultaPessoas.Application.Models;
using ConsultaPessoas.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ConsultaPessoas.Application.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;

        public PessoaController(IPessoaRepository pessoaRepository, IMapper mapper)
        {
            _pessoaRepository = pessoaRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(string ordenacao)
        {
            var pessoas = await _pessoaRepository.ObterTodos();
            
            IEnumerable<PessoaViewModel> pessoaViewModel = _mapper.Map<IEnumerable<PessoaViewModel>>(pessoas);

            if(String.IsNullOrEmpty(ordenacao))
                return View(pessoaViewModel);   
            else
            {
                PropertyInfo prop = typeof(PessoaViewModel).GetProperty(ordenacao);
            
                return View(pessoaViewModel.OrderBy(x => prop.GetValue(x, null)).ToList());   
            }
        }
    }
}