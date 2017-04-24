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
    /// Provider Order Line Management
    /// </summary>
    public class ProviderOrderLineBLO : BaseBLO<ProviderOrderLine>
    {
        ModelContext db = new ModelContext();

        public ProviderOrderLineBLO(DbContext context) : base(context)
        {
        }

        public ProviderOrderLineBLO() : base()
        {
        }

        /// <summary>
        /// Get ProviderOrderline list by provider order
        /// </summary>
        /// <param name="po">provider order</param>
        /// <returns>provider order lines list</returns>
        public List<ProviderOrderLine> GetPOLByPO (ProviderOrder po)
        {
            var query = from pol in db.ProviderOrderLines
                        where pol.providerOrder.Id == po.Id
                        select pol;
            return query.ToList<ProviderOrderLine>();
        }

        /// <summary>
        /// Get Provider order line vy article object
        /// </summary>
        /// <param name="article">object</param>
        /// <returns>provider order line object</returns>
        public ProviderOrderLine GetPOLByArticle(Article article)
        {
            var query = from pol in db.ProviderOrderLines
                        where pol.article.Id == article.Id
                        select pol;
            return query.ElementAt(0);
        }

       /// <summary>
       /// Get ProviderOrderline list by article object && providerorder object
       /// </summary>
       /// <param name="article">object</param>
       /// <param name="po">provider order</param>
       /// <returns>provider order lines list</returns>
        public List<ProviderOrderLine> GetPoLByArticleandPO(Article article,ProviderOrder po)
        {
            var query = from pol in db.ProviderOrderLines
                        where (pol.article.Id == article.Id) && (pol.providerOrder.Id == po.Id)
                        select pol;
            return query.ToList<ProviderOrderLine>();
        }

        //
        /// <summary>
        /// Get provider order line list by provider order object
        /// </summary>
        /// <param name="providerOrder">Object</param>
        /// <returns>ProviderOrderLine list</returns>
        public List<ProviderOrderLine> GetSelectedArticles(ProviderOrder providerOrder)
        {
            var query = from pol in db.ProviderOrderLines
                        where (pol.providerOrder.Id == providerOrder.Id)
                        select pol;
            return query.ToList<ProviderOrderLine>();
        }




        /// <summary>
        /// Get provider Order lines list by operation type
        /// </summary>
        /// <param name="OperationType">String</param>
        /// <returns>
        /// provider order line id 
        /// provider order id
        /// article reference
        /// total price
        /// </returns>
        public List<Object> GetPOlByOpType(string OperationType)
        {
            var query = from pol in db.ProviderOrderLines
                        join po in db.Orders 
                        on pol.providerOrder.Id equals po.Id
                        where po.OrderState == OperationType
                        select new
                        {
                            Id = pol.Id,
                            PoId = po.Id,
                            ArticleReference = pol.article.Reference,
                            QuantityRequiered = pol.Quantity,
                            TotalPrice = pol.Quantity * pol.article.BuyingPrice
                            //ProviderLastName = po.provider.LastName,
                            //ProviderFirstName = po.provider.FirstName,
                        };
            return query.ToList<Object>();
        }

            /// <summary>
            /// Get provider order line list by provider object
            /// </summary>
            /// <param name="provider">object</param>
            /// <returns>
            /// provider order line id
            /// provider order id
            /// article reference
            /// quantity required
            /// total price
            /// provider last name , provider first name
            /// </returns>
            public List<Object> GetPOLByp(Provider provider)
        {
            var query = from pol in db.ProviderOrderLines
                        join po in db.Orders
                        on pol.providerOrder.Id equals po.Id
                        where po.provider.Id == provider.Id
                        select new
                        {
                            Id = pol.Id,
                            PoId = po.Id,
                            ArticleReference = pol.article.Id,
                            QuantityRequiered = pol.Quantity,
                            TotalPrice = pol.Quantity * pol.article.BuyingPrice,
                            ProviderLastName = po.provider.LastName,
                            ProviderFirstName = po.provider.FirstName
                        };
            return query.ToList<Object>();
        }

        
        /// <summary>
        /// Get buys by start date && enddate (periode) && order state = "buy"
        /// </summary>
        /// <param name="StartDate">date debut</param>
        /// <param name="EndDate">date fin</param>
        /// <returns>
        /// provider order line id
        /// provider order id
        /// quantity
        /// article buying price
        /// </returns>
        public List<Object> GetPOLBySD_ED_OS(DateTime StartDate, DateTime EndDate)
        {
            var query = from pol in db.ProviderOrderLines
                        join po in db.Orders
                        on pol.providerOrder.Id equals po.Id
                        where po.OrderState == "Buy"
                        && po.orderDate.Day >= StartDate.Day
                        && po.orderDate.Month >= StartDate.Month
                        && po.orderDate.Year >= StartDate.Year
                        && po.orderDate.Day <= EndDate.Day
                        && po.orderDate.Month <= EndDate.Month
                        && po.orderDate.Year <= EndDate.Year
                        select new
                        {
                            polId = pol.Id,
                            poId = po.Id,
                            Quantity = pol.Quantity ,
                            ArticleBuyingPrice = pol.article.BuyingPrice
                        };
            return query.ToList<Object>();
        }

        //Get Articles List in Providers order Line with Start Date , EndDate
        public List<Article> GetArticlesList_SD_Ed(DateTime StartDate , DateTime EndDate)
        {
            var query = from pol in db.ProviderOrderLines
                        join po in db.Orders
                        on pol.providerOrder.Id equals po.Id
                        where
                        po.OrderState == "Buy"
                       && po.orderDate.Day >= StartDate.Day
                       && po.orderDate.Month >= StartDate.Month
                       && po.orderDate.Year >= StartDate.Year
                       && po.orderDate.Day <= EndDate.Day
                       && po.orderDate.Month <= EndDate.Month
                       && po.orderDate.Year <= EndDate.Year
                        select pol.article;
            return query.ToList<Article>();
        }
    }
    }

