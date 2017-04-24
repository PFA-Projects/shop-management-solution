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
    /// fr : 
    /// Depense
    /// </summary>
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [Menu]
    public class Expense:BaseEntity
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

        [DisplayProperty(Titre = "ExpenseDate")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public DateTime ExpenseDate { get; set; }

        [DisplayProperty(Titre = "price")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public float price { get; set; }

        //Initialize DateTime
        public Expense()
        {
            ExpenseDate = DateTime.Now;
        }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public ExpenseCategory expenseCategory { get; set; }
    }
}
