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
    
    public partial class Tag
    {
        public Tag()
        {
            this.AccountTags = new HashSet<AccountTag>();
            this.ContactTags = new HashSet<ContactTag>();
            this.LeadTags = new HashSet<LeadTag>();
        }
    
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool RecordDeleted { get; set; }
    
        public virtual ICollection<AccountTag> AccountTags { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<ContactTag> ContactTags { get; set; }
        public virtual ICollection<LeadTag> LeadTags { get; set; }
    }
}
