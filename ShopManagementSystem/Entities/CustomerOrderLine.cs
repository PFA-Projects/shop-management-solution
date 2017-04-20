﻿//Mariam Ait Al
using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
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
