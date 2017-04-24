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
    /// Customer Order Line Management
    /// </summary>
    public class CustomerOrderLineBLO : BaseBLO<CustomerOrderLine>
    {
        ModelContext db = new ModelContext();

        public CustomerOrderLineBLO(DbContext context) : base(context)
        {
        }
        public CustomerOrderLineBLO() : base()
        {
        }
       
        /// <summary>
        /// Get Customer Order Line by Operation Type 
        /// </summary>
        /// <param name="OperationType">Operation Type</param>
        /// <returns> 
        /// Customer Order Line Id 
        /// customer order id
        /// article reference
        /// quantoty required
        /// Total Price
        /// </returns>
        public List<Object> GetCOlByOpType(string OperationType)
        {
            var query = from col in db.CustomerOrderLines
                        join co in db.CustomerOrders
                        on col.customerOrder.Id equals co.Id
                        where co.OrderState == OperationType
                        select new
                        {
                            Id = col.Id,
                            PoId = co.Id,
                            ArticleReference = col.article.Reference,
                            QuantityRequiered = col.Quantity,
                            TotalPrice = col.Quantity * col.article.BuyingPrice
                            //ProviderLastName = po.provider.LastName,
                            //ProviderFirstName = po.provider.FirstName,
                        };
            return query.ToList<Object>();
        }
        
        /// <summary>
        /// Get sells by start date && end date && order state == "sell"
        /// </summary>
        /// <param name="StartDate"> Start Date (Date Debut)</param> //Periode
        /// <param name="EndDate">End Date (Date Fin) </param> //Periode
        /// <returns>
        /// customer order line id
        /// customer order id
        /// quantity
        /// article selling price
        /// </returns>
        public List<Object> GetCOLBySD_ED(DateTime StartDate , DateTime EndDate)
        {
            var query = from col in db.CustomerOrderLines
                        join co in db.CustomerOrders
                        on col.customerOrder.Id equals co.Id
                        where co.OrderState == "Sell"
                        && co.OrderDate.Day >= StartDate.Day
                        && co.OrderDate.Month >= StartDate.Month
                        && co.OrderDate.Year >= StartDate.Year
                        && co.OrderDate.Day <= EndDate.Day
                        && co.OrderDate.Month <= EndDate.Month
                        && co.OrderDate.Year <= EndDate.Year
                        select new
                        {
                            colId = col.Id,
                            coId = co.Id,
                            Quantity = col.Quantity ,
                            ArticleSellingPrice = col.article.SellingPrice
                        };
            return query.ToList<Object>();
        }


        /// <summary>
        /// Get articles list customer order line by start date && end date && order state = "sell"
        /// </summary>
        /// <param name="StartDate">Date Debut </param>//Periode
        /// <param name="EndDate">Date fin</param>//Periode
        /// <returns>Articles List </returns>
        public List<Article> GetArticles_SD_ED(DateTime StartDate , DateTime EndDate)
        {
            var query = from col in db.CustomerOrderLines
                        join co in db.CustomerOrders
                        on col.customerOrder.Id equals co.Id
                        where
                        co.OrderState == "Sell"
                        && co.OrderDate.Day >= StartDate.Day
                        && co.OrderDate.Month >= StartDate.Month
                        && co.OrderDate.Year >= StartDate.Year
                        && co.OrderDate.Day <= EndDate.Day
                        && co.OrderDate.Month <= EndDate.Month
                        && co.OrderDate.Year <= EndDate.Year
                        select col.article;
            return query.ToList<Article>();
        }

    }
}
