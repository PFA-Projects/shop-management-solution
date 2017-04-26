// Nom : Mariam Ait al
// Groupe : TDI204
//Annee : 2017

using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    /// <summary>
    /// fr : Category Depense
    /// </summary>
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [Menu]
    public class ExpenseCategory:BaseEntity
    {
        [DisplayProperty(Titre = "Name")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Name { get; set; }
        [DisplayProperty(Titre = "Description")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Description { get; set; }
    }
}
