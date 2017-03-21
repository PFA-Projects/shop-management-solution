//Mariam Ait al
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
    /// User All Ready Exist !!
    /// </summary>

    [GwinEntity(Localizable = true, DisplayMember = "LastName")]
    [Menu(Group = "UserApp")]
    [Obsolete]
    public class AppUser:BaseEntity
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

        [DisplayProperty(Titre = "Email")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Email { get; set; }

        [DisplayProperty(Titre = "Login")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Login { get; set; }

        [DisplayProperty(Titre = "Password")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Password { get; set; }

        [DisplayProperty(Titre = "Tel")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Tel { get; set; }
    }
}
