using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sugarrepo.Models;

namespace sugarrepo{
    public interface ISugarServices{
        Task<SugarModel> GetSugar(string upcno);
    }
}