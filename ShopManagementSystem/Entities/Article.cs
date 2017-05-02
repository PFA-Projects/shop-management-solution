// Name : Mariam Ait al
// Name : ES-SARRAJ Fouad
// Groupe : TDI204
//Annee : 2017
using App.Gwin.Attributes;
using App.Gwin.Entities;
using System.Collections.Generic;

namespace ShopManagement.Entities
{
    /// <summary>
    /// fr : Article
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [Menu(Group = "Buy")]
   // [ManagementForm(FormTitle =("Article_Manager"))]
    public class Article:BaseEntity
    {
        //
        // References
        //
        //[EntryForm(GroupeBox = "References")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Reference { get; set; }

        //[EntryForm(GroupeBox = "References")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Name { get; set; }


        // 
        // Price
        //
        //[EntryForm(GroupeBox = "Price")]
        [EntryForm]
        [DataGrid]
        public float BuyingPrice { get; set; }

        //[EntryForm(GroupeBox = "Price")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public float SellingPrice { get; set; }

        // 
        //  fr_stock
        //
        //[EntryForm(GroupeBox = "fr_stock")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public float Quantity { get; set; }

        // 
        //  Classification
        //
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        //[Filter]
        [DataGrid(WidthColonne = 100)]
        public ArticleCategory articleCategory { get; set; }

       
        
        
        

        
    }
}
