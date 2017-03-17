using App.Gwin.Attributes;
using App.Gwin.Entities;

namespace ShopManagement.Entities
{
    /// <summary>
    /// Mariam Aital
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu(Group = "Articles")]
    public class Article:BaseEntity
    {
        [DisplayProperty(Titre = "Reference")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Reference { get; set; }

        [DisplayProperty(Titre = "BuyingPrice")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public int BuyingPrice { get; set; }

        [DisplayProperty(Titre = "SellPrice")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public int SellPrice { get; set; }

        [DisplayProperty(Titre = "QuantityInStock")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public int QuantityInStock { get; set; }
    }
}
