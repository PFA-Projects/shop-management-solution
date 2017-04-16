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
    public class CustomerOrderLineBLO : BaseBLO<CustomerOrderLine>
    {
        ModelContext db = new ModelContext();

        public CustomerOrderLineBLO(DbContext context) : base(context)
        {
        }
        public CustomerOrderLineBLO() : base()
        {
        }

        //Get Customer Order Lines By Operation type !
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
        
        //Get Sell with StartDate and EndDate and OrderState = "sell"
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

       //Get Articles List COL whith StartDate , EndDate and orderStaet = "Sell"
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
