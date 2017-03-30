// Name : Mariam Ait al
// Name : ES-SARRAJ Fouad
using App.Gwin.Attributes;
using App.Gwin.Entities;
using System.Collections.Generic;

namespace ShopManagement.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu(Group = "Buy")]
    [ManagementForm(FormTitle =("Article_Manager"))]
    public class Article:BaseEntity
    {
        //
        // References
        //
        [EntryForm(GroupeBox = "References")]
        [DataGrid]
        [Filter]
        public string Reference { get; set; }

        [EntryForm(GroupeBox = "References")]
        [DataGrid]
        [Filter]
        public string Name { get; set; }


        // 
        // Price
        //
        [EntryForm(GroupeBox = "Price")]
        [DataGrid]
        public float BuyingPrice { get; set; }

        [EntryForm(GroupeBox = "Price")]
        [DataGrid]
        [Filter]
        public float SellingPrice { get; set; }

        // 
        //  fr_stock
        //
        [EntryForm(GroupeBox = "fr_stock")]
        [DataGrid]
        [Filter]
        public float Quantity { get; set; }

        // 
        //  Classification
        //
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public ArticleCategory articleCategory { get; set; }

       
        public CustomerOrderLine customerorderline { get; set; }
        

        
    }
}
