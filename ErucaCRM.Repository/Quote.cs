//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErucaCRM.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quote
    {
        public Quote()
        {
            this.ProductQuoteAssociations = new HashSet<ProductQuoteAssociation>();
            this.SalesOrders = new HashSet<SalesOrder>();
        }
    
        public int QuoteId { get; set; }
        public string Subject { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> ContactId { get; set; }
        public Nullable<int> LeadId { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> OpportunityId { get; set; }
        public Nullable<System.DateTime> ValidTill { get; set; }
        public string Carrier { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<int> DiscountType { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<bool> TaxApplied { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<bool> VatApplied { get; set; }
        public Nullable<decimal> VatAmount { get; set; }
        public Nullable<int> AdjustmentType { get; set; }
        public Nullable<decimal> AdjustmentAmount { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
        public string Terms { get; set; }
        public Nullable<int> BillingAddressId { get; set; }
        public Nullable<int> ShippingAddressId { get; set; }
        public string Description { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool RecordDeleted { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual ICollection<ProductQuoteAssociation> ProductQuoteAssociations { get; set; }
        public virtual Address Address1 { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual Lead Lead { get; set; }
    }
}
