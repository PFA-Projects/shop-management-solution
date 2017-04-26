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
    /// fr : ligne commande client
    /// </summary>
    [GwinEntity(Localizable = true, DisplayMember = "customerOrder")]
    [Menu]
    public class CustomerOrderLine:BaseEntity
    {
        [DisplayProperty(Titre = "Quantity")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public float Quantity { get; set; }

        //Relations - OneToMany
        
        public CustomerOrder customerOrder { get; set; }


        public Article article { get; set; }
        
    }
}
