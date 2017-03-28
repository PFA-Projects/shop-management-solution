//Mariam Ait Al

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
    public class ArticlesCategoryBLO:BaseBLO<ArticleCategory>
    {
        ModelContext db = new ModelContext();

        public ArticlesCategoryBLO(DbContext context) : base(context)
        {
        }

        public ArticlesCategoryBLO() : base()
        {
        }

        //Search LArticlesCategory List By Reference
        public ArticleCategory SearchByReference(string articleCategory_reference)
        {
            var query = from ac in db.ArticleCategories
                        where articleCategory_reference == ac.Reference
                        select ac;
            return query.ElementAt(0);
        }
    }
}
