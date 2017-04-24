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
    /// en :Providers Management
    /// fr : GGestion Fournisseurs
    /// </summary>
    public class ProviderBLO : BaseBLO<Provider>
    {
        ModelContext db = new ModelContext();

        public ProviderBLO(DbContext context) : base(context)
        {
        }

        public ProviderBLO() : base()
        {
        }
    }
}
