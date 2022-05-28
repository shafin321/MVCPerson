using Microsoft.AspNetCore.Mvc;
using PersonMVCEntity.Models;
using PersonMVCEntity.Services;
using PersonMVCEntity.ViewModel;
using System.Linq;

namespace PersonMVCEntity.Controllers
{
    public class PersonController : Controller
    {
        PersonService _peopleServie;
        public PersonController()
        {
            _peopleServie = new PersonService();
        }
        public IActionResult Index(string search)
        {
            var model = _peopleServie.GettAllPersonByName(search).Select(c => new PersonViewModel
            {
                Name = c.Name,
                Phone = c.PhoneNumber,
                City = c.City,

            });
            //var model = _peopleServie.GettAllPersonByName(search);
            PersonIndexModel viewModel = new PersonIndexModel
            {
                PersonList = model,
                SearchTearm = search,
            };

            return View(viewModel);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Person person)
        {
            _peopleServie.AddPerson(person);

            return RedirectToAction("Index");
        }
    }
}
