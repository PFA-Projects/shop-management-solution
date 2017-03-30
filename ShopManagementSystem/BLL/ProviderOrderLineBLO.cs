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
    }
}
