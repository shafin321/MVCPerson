using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PersonMVCEntity.ViewModel
{
    public class PersonIndexModel
    {
        public IEnumerable<PersonViewModel> PersonList { get; set; }
        //public IEnumerable<Person> PersonList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTearm { get; set; }
    }
}
