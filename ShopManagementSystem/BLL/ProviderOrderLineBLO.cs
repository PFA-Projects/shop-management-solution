// Mariam Ait Al
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
    public class ProviderOrderLineBLO : BaseBLO<ProviderOrderLine>
    {
        ModelContext db = new ModelContext();

        public ProviderOrderLineBLO(DbContext context) : base(context)
        {
        }

        public ProviderOrderLineBLO() : base()
        {
        }

        //Get Provider Order Line By Provider Order
        public List<ProviderOrderLine> GetPOLByPO (ProviderOrder po)
        {
            var query = from pol in db.ProviderOrderLines
                        where pol.providerOrder.Id == po.Id
                        select pol;
            return query.ToList<ProviderOrderLine>();
        }

        //Get Provider Order Line By Article
        public ProviderOrderLine GetPOLByArticle(Article article)
        {
            var query = from pol in db.ProviderOrderLines
                        where pol.article.Id == article.Id
                        select pol;
            return query.ElementAt(0);
        }

        // Get Provider Order Line By Article and Provider Order
        public List<ProviderOrderLine> GetPoLByArticleandPO(Article article,ProviderOrder po)
        {
            var query = from pol in db.ProviderOrderLines
                        where (pol.article.Id == article.Id) && (pol.providerOrder.Id == po.Id)
                        select pol;
            return query.ToList<ProviderOrderLine>();
        }

        //
        // Get Provider order Lines By provider
        public List<ProviderOrderLine> GetSelectedArticles(ProviderOrder providerOrder)
        {
            var query = from pol in db.ProviderOrderLines
                        where (pol.providerOrder.Id == providerOrder.Id)
                        select pol;
            return query.ToList<ProviderOrderLine>();
        }




        /////////
        //Get Provider Order Lines By Operation type !
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

            // Get Provider Order Lines By Provider
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


        //Get Buys By Start Date and End Date and OrderState = "Buy"
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

