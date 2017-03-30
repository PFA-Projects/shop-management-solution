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
    public class ProviderOrderBLO : BaseBLO<ProviderOrder>
    {
        ModelContext db = new ModelContext();

        public ProviderOrderBLO(DbContext context) : base(context)
        {
        }

        public ProviderOrderBLO() : base()
        {
        }
        //Get Provider Order By Provider
        public List<ProviderOrder> GetPOByProvider(Provider provider)
        {
            var query = from po in db.Orders
                        where po.provider.Id == provider.Id
                        select po;
            return query.ToList<ProviderOrder>();
        }
    }
}
