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
    public class IndexModel : PageModel
    {
        SugarServices _sugarService;

        public IndexModel(SugarServices services){
            _sugarService=services;
        }
        public SugarModel sugar{get;set;}
        [BindProperty(SupportsGet=true)]
        public string LongName{get;set;}
        [BindProperty]
        public string UPCNo{ get; set; }
        public ActionResult OnPostAsync(){
            if(string.IsNullOrEmpty(UPCNo)){
                return Page();
            }
            //var result = await _sugarService.GetSugar(UPCNo);
            Console.WriteLine(UPCNo);
           return RedirectToPage("/ResultPage", new { UPCNo });
            
        }
        // public async Task OnGetAsync(){
        //     //var upcno=Request.Form["UPCNo"];
        //     var upcno="019022128593";
        //     var result=await sugarService.GetSugar(upcno);
        //     if(result!=null){
        //         sugar=result;
        //         return;
        //     }

        //     sugar=new SugarModel();
        //     sugar.LongName="Not Found";
        // }
    }
}
