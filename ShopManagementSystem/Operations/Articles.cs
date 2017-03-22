//Mariam Ait Al
using App;
using ShopManagement.Entities;
using System;
using System.Collections.Generic;
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

        //Filters
        public List<Article> Filtrer()
        {
            var liste = from a in db.Articles
                        where a.Reference.Contains("reference")
                        select a;
            return liste;
            
        }
    }
}
