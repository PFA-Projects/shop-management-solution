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
    [Menu(Group = "Sell")]
    public class Customer:BaseEntity
    {
        [DisplayProperty(Titre = "FirstName")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string FirstName { get; set; }

        [DisplayProperty(Titre = "LastName")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string LastName { get; set; }

        [DisplayProperty(Titre = "Adress")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Adress { get; set; }

        [DisplayProperty(Titre = "Tel")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Tel { get; set; }

        [DisplayProperty(Titre = "Email")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Email { get; set; }

        [DisplayProperty(Titre = "CNE")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string CNE { get; set; }

    }
}
