//Mariam Ait al
using App;
using ShopManagement.BAL;
using ShopManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.BLL
{
    public class ArticlesBLO: BaseBLO<Article>
    {
        ModelContext db = new ModelContext();

        public ArticlesBLO(DbContext context) : base(context)
        {
        }

        //Search Articles By Category
        public List<Article> SearchByCateory(ArticleCategory articlecategory)
        {
            var query = from a in db.Articles
                        where a.articleCategory.Id == articlecategory.Id

                        select a;
            return query.ToList<Article>();
        }
    }
}
