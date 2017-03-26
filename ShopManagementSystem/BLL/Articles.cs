//Mariam Ait Al
using App;
using ShopManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShopManagement.Operations
{
    public class Articles
    {
        ModelContext db = new ModelContext();
        // Articles
        public List<Article> ListArticles()
        {
            var query = from a in db.Articles
                        select a;
            return query.ToList<Article>();
        }

        //Filter search by refrence
        public List<Article> Filtrer(string message)
        {
            var resultat = db.Articles.AsQueryable().Where(a => a.Reference.Contains(message));
            return resultat.ToList<Article>();
        }

        //Search Articles By Category
        public List<Article> SearchByCateory(int CategoryArticleId)
        {
            var query = from a in db.Articles
                        where a.articleCategory.Id == CategoryArticleId
                        select a;
            return query.ToList<Article>();
            
        }
    }
}
