using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using sugarrepo.Models;
using Newtonsoft.Json;
using System;
using MongoDB.Driver;

namespace sugarrepo.Services{
    public class SugarServices:ISugarServices{

        
        private readonly IMongoCollection<SugarModel> _products;

        public SugarServices(ISugarDBDatabaseSettings settings){
            var client=new MongoClient(settings.ConnectionString);
            var database=client.GetDatabase(settings.DatabaseName);

            _products=database.GetCollection<SugarModel>(settings.SugarDBCollectionName);
        }

        public async Task<SugarModel> GetSugar(string upcno){
            Console.WriteLine(upcno);
            var product=await _products.Find<SugarModel>(pd=>pd.UPCNo==upcno).FirstOrDefaultAsync();
            return product;
        }

        

       
    }
}