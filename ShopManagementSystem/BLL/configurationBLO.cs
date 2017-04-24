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
    /// en : Configuration Management
    /// fr : Gestion de configuration
    /// </summary>
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
