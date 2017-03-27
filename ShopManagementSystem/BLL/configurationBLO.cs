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
    public class configurationBLO : BaseBLO<configuration>
    {
        ModelContext db = new ModelContext();

        public configurationBLO(DbContext context) : base(context)
        {
        }
        public configurationBLO() : base()
        {

        }
    }
}
