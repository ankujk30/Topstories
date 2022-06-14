using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TopstoriesWeb.Models;
using TopstoriesWeb.Repository.IRepository;

namespace TopstoriesWeb.Controllers
{
    public class TopstoriesController : Controller
    {
        private readonly ITopstoriesRepository _tsrepo;

        public TopstoriesController(ITopstoriesRepository tsrepo)
        {
            _tsrepo = tsrepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Topstories objTs)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpResponseMessage response = await _tsrepo.CreateAsync(Constants.TopstoriesAPIPath, objTs.ApiKey);

                    if(response.IsSuccessStatusCode)
                    {
                        ViewBag.successMessage = Constants.SaveSuccessMessage;
                        ModelState.Clear();
                        return View();
                    }
                    ViewBag.resposnseMesage = ErrorMessage.CheckErrorMEssage(response.StatusCode);

                    return View();
                }
                else
                {
                    return View(objTs);
                }
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
