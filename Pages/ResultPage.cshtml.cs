using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sugarrepo.Models;
using sugarrepo.Services;

namespace sugarrepo.Pages
{
    public class ResultPageModel : PageModel
    {
        SugarServices _sugarService;
        public ResultPageModel(SugarServices services)
        {
            _sugarService = services;
        }
        [BindProperty]
        public SugarModel sugar { get; set; }
        //[BindProperty]
        ////public string ProductName{get=> sugar==null?sugar.LongName:"Not Found";}
        //public string ProductName { get; set; }
        //[BindProperty]
        ////public string UPC { get => sugar == null ? sugar.UPCNo : "Not Found"; }
        //public string UPC { get; set; }
        //[BindProperty]
        ////public string NDB { get => sugar == null ? sugar.NDBNo : "Not Found"; }
        //public string NDB { get; set; }
        [BindProperty(SupportsGet = true)]
        public string UPCNo { get; set; }
        public async Task OnGet()
        {
            if (string.IsNullOrEmpty(UPCNo))
            {
                return;
            }
            Console.WriteLine(UPCNo);
            sugar = await _sugarService.GetSugar(UPCNo);
        }
    }
}
