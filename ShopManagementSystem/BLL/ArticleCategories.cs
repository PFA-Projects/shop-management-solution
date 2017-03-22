using App;
using ShopManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Operations
{
    public class ArticleCategories
    {
        ModelContext db = new ModelContext();
        // Article Categories
        public List<ArticleCategory> ListCategoriesArticle()
        {
            var query = from a in db.ArticleCategories
                        select a;
            return query.ToList<ArticleCategory>();
        }
    }
}
