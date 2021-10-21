using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevDevil.Models;
using DevDevil.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevDevil.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository ?? throw new ArgumentNullException(nameof(pieRepository));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }
        
        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;
            return View(piesListViewModel);
        }
    }
}
