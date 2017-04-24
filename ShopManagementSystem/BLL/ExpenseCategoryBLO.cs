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
    /// en : Expense Category Management
    /// fr : Gestion Category de depneses
    /// </summary>
    public class ExpenseCategoryBLO : BaseBLO<ExpenseCategory>
    {
        ModelContext db = new ModelContext();

        public ExpenseCategoryBLO() : base()
        {
        }

        public ExpenseCategoryBLO(DbContext context) : base(context)
        {
        }
    }
}
