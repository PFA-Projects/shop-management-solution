﻿//Mariam Ait al
using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    

    [GwinEntity(Localizable = true, DisplayMember = "OrderName")]
    [Menu(Group = "Buy")]
    public class ProviderOrder:BaseEntity
    {
        [DisplayProperty(Titre = "OrderName")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Name { get; set; }

        [DisplayProperty(Titre = "orderDate")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public DateTime orderDate { get; set; }

        [DisplayProperty(Titre = "DeliveryDateExpected")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public DateTime DeliveryDateExpected { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public Provider provider { get; set; }

        //Define OrderState
        public string OrderState { get; set; }
        
        //Initialisier Datetime
        public ProviderOrder()
        {
            this.DeliveryDateExpected = DateTime.Now;
            this.orderDate = DateTime.Now;
        }

       
    }
}
