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
    public class DeponseCategoryBLO : BaseBLO<DeponseCategory>
    {
        ModelContext db = new ModelContext();

        public DeponseCategoryBLO() : base()
        {
        }

        public DeponseCategoryBLO(DbContext context) : base(context)
        {
        }
    }
}
