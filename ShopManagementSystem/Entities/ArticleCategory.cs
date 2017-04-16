// Name : Mariam Ait al
using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    

    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [Menu(Group = "Configuration")]
    public class ArticleCategory:BaseEntity
    {
        [DisplayProperty(Titre = "Name")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Name{ get; set; }

        [DisplayProperty(Titre = "Description")]
        [EntryForm]
        [DataGrid]
        public string Description { get; set; }

        //Tostring 
        public override string ToString()
        {
            return this.Name;
        }
    }
}
