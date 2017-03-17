// Name : Mariam Aital
// Name : ES-SARRAJ Fouad
using App.Gwin.Attributes;
using App.Gwin.Entities;

namespace ShopManagement.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu(Group = "Articles")]
    public class Article:BaseEntity
    {

        [EntryForm]
        [DataGrid]
        [Filter]
        public string Reference { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public float BuyingPrice { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public float SellPrice { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public float QuantityInStock { get; set; }
    }
}
