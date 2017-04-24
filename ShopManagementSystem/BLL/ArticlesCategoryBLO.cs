// Nom : Mariam Ait al
// Groupe : TDI204
//Annee : 2017

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
    /// <summary>
    /// en : Articles Category Management
    /// fr : Gestion Category d'articles
    /// </summary>
    public class ArticlesCategoryBLO:BaseBLO<ArticleCategory>
    {
        ModelContext db = new ModelContext();

        public ArticlesCategoryBLO(DbContext context) : base(context)
        {
        }

        public ArticlesCategoryBLO() : base()
        {
        }

        /// <summary>
        /// Search Article Category Object By reference
        /// </summary>
        /// <param name="articleCategory_reference">Article Category reference</param>
        /// <returns>Article Category</returns>
        public ArticleCategory SearchByReference(string articleCategory_reference)
        {
            var query = from ac in db.ArticleCategories
                        where articleCategory_reference == ac.Reference
                        select ac;
            return query.ElementAt(0);
        }
    }
}
