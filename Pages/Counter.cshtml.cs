
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace MyApp.Namespace
{
    public class CounterModel : PageModel
    {
        public int Count { get; set; }
        public void OnGet()
        {

        }

        public void OnPost(int counter)
        {
            // do something
        }
    }
}