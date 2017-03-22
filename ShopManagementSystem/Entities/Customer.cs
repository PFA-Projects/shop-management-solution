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
    [GwinEntity(Localizable = true, DisplayMember = "LastName")]
    [Menu]
    public class Customer:BaseEntity
    {
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //Relation Many To One
        public CustomerDelivery customerDelivery { get; set; }
    }
}
