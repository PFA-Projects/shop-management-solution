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
    public class DeponsesBLO : BaseBLO<Deponse>
    {
        ModelContext db = new ModelContext();

        public DeponsesBLO() : base()
        {
        }

        public DeponsesBLO(DbContext context) : base(context)
        {
        }
    }
}
