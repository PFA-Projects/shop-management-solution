// Nom : Mariam Ait al
// Groupe : TDI204
//Annee : 2017
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    /// <summary>
    /// fr : Notification
    /// </summary>
   public class Notification:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime creationDate { get; set; }

        //initialiser Datetima
        public Notification()
        {
            creationDate = DateTime.Now;
        }
    }
}
