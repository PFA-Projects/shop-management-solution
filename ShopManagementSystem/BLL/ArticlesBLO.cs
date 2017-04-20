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

        public ArticlesBLO() : base()
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

        // Get Articles By Reference
        public List<Article> SearchByReference(string reference)
        {
            var query = from a in db.Articles
                        where a.Reference == reference
                        select a;
            return query.ToList<Article>();
        }

        //Get Articles By Provider and the state article is order

        //Search articles By Providers
        //public List<Article> SearchByProvider(Provider provider)
        //{
        //    var query = from a in db.Articles
        //                where a.providerorderline.providerOrder.provider.Id == provider.Id
        //                select a;
        //    return query.ToList<Article>();
        //}
        

        //Difference between 2 listes
        public List<Article> differenceListes(List<Article> liste1 , List<Article> liste2)
        {
            var query = liste1.Where(a => !liste2.Any(a2 => a2.Id == a.Id));
            return query.ToList<Article>();
        }

        
        
    }
}
