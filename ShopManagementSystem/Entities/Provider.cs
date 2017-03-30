//Mariam Ait al
using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    [GwinEntity(Localizable = true, DisplayMember = "LastName")]
    [Menu(Group ="Buy")]
    public class Provider:BaseEntity  
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

        [DisplayProperty(Titre = "Adresse")]
        [EntryForm]
        [DataGrid]
        public string Adresse { get; set; }

        [DisplayProperty(Titre = "Phone")]
        [EntryForm]
        [DataGrid]
        public string Phone { get; set; }

        [DisplayProperty(Titre = "Email")]
        [EntryForm]
        [DataGrid]
        public string Email { get; set; }
    }
}
