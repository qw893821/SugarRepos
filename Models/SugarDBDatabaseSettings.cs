namespace sugarrepo.Models
{
    public class SugarDBDatabaseSettings : ISugarDBDatabaseSettings
    {
        public string SugarDBCollectionName { get;set; }
        public string ConnectionString { get ;set; }
        public string DatabaseName { get;set; }
    }

    public interface ISugarDBDatabaseSettings{
        string SugarDBCollectionName{get;set;}
        string ConnectionString{get;set;}
        string DatabaseName{get;set;}
    }

}