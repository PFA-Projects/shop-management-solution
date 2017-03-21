using App;
using ShopManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Operations
{
    /// <summary>
    /// ??
    /// </summary>
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
    }
}
