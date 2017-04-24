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
    /// Provider Order Manangement
    /// </summary>
    public class ProviderOrderBLO : BaseBLO<ProviderOrder>
    {
        ModelContext db = new ModelContext();

        public ProviderOrderBLO(DbContext context) : base(context)
        {
        }

        public ProviderOrderBLO() : base()
        {
        }
        /// <summary>
        /// Get ProviderOrders List by provider object
        /// </summary>
        /// <param name="provider"></param>
        /// <returns>Providers Orders List</returns>
        public List<ProviderOrder> GetPOByProvider(Provider provider)
        {
            var query = from po in db.Orders
                        where po.provider.Id == provider.Id
                        select po;
            return query.ToList<ProviderOrder>();
        }
    }
}
