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
    /// <summary>
    /// Mariam Aital
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "LastName")]
    [Menu]
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
        [Filter]
        public string Adresse { get; set; }

        [DisplayProperty(Titre = "Phone")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Phone { get; set; }

        [DisplayProperty(Titre = "Email")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Email { get; set; }
    }
}
