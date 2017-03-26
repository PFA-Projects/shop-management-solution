//Mariam Ait Al
using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    [GwinEntity(Localizable = true, DisplayMember = "Nom")]
    [Menu]
    public class Deponse:BaseEntity
    {
        [DisplayProperty(Titre = "Nom")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Nom { get; set; }
        [DisplayProperty(Titre = "Description")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Description { get; set; }
        [DisplayProperty(Titre = "deponseDate")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public DateTime deponseDate { get; set; }
        [DisplayProperty(Titre = "prix")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public float prix { get; set; }

        public DeponseCategory deponseCategory { get; set; }

        //Initilise the datetime
       public Deponse()
        {
            deponseDate = DateTime.Now;
        }
    }
}
