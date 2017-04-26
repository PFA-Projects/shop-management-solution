﻿// Nom : Mariam Ait al
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
    /// en : Articles Management
    /// fr : Gestion d'articles
    /// </summary>
    public class ArticlesBLO: BaseBLO<Article>
    {
        ModelContext db = new ModelContext();

        public ArticlesBLO(DbContext context) : base(context)
        {
        }

        public ArticlesBLO() : base()
        {
        }

        /// <summary>
        /// Search Articles By Category
        /// </summary>
        /// <param name="articlecategory"></param>
        /// <returns>Articles List</returns>
        public List<Article> SearchByCateory(ArticleCategory articlecategory)
        {
            var query = from a in db.Articles
                        where a.articleCategory.Id == articlecategory.Id

                        select a;
            return query.ToList<Article>();
        }

         /// <summary>
         /// Get Articles By Reference
         /// </summary>
         /// <param name="reference"></param>
         /// <returns>Articles List</returns>
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
        

        /// <summary>
        /// Defference between two lists
        /// </summary>
        /// <param name="liste1">The first Articles List</param>
        /// <param name="liste2">The second Articles list to compare</param>
        /// <returns>Articles List</returns>
        public List<Article> differenceListes(List<Article> liste1 , List<Article> liste2)
        {
            var query = liste1.Where(a => !liste2.Any(a2 => a2.Id == a.Id));
            return query.ToList<Article>();
        }

        
        
    }
}
